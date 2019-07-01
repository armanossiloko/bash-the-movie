using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTM.Models;
using BTM.Models.Requests;
using Flurl.Http;
using MetroFramework.Forms;

namespace BTM.WinUI.Content
{
    public partial class frmAddMedia : MetroForm
    {
        private OpenFileDialog Cover = new OpenFileDialog();
        private string CoverFileName = "";
        private System.Drawing.Image NewCoverImage = null;

        APIService _genreService = new APIService("Genres");
        APIService _languageService = new APIService("Languages");
        APIService _countryService = new APIService("Countries");
        APIService _studioService = new APIService("Studios");
        APIService _mediaService = new APIService("Media");
        APIService _imagesService = new APIService("Images");

        public frmAddMedia()
        {
            InitializeComponent();
            this.errorProvider.Icon = new System.Drawing.Icon(Global.ErrorIcon);
        }

        private async void FrmAddMedia_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager;

            string coverLocation = await $"{Properties.Settings.Default.APIUrl}/info/defaultCover".GetStringAsync();
            NewCoverImage = System.Drawing.Image.FromFile(coverLocation);
            this.picCover.Image = new Bitmap(NewCoverImage, picCover.Width, picCover.Height);

            btnAdd.Enabled = false;

            #region Dropdown
            IEnumerable<Genre> genres = await _genreService.Get<IEnumerable<Genre>>(null);
            foreach (var item in genres)
            {
                dropGenre.Items.Add(item);
            }

            IEnumerable<Country> countries = await _countryService.Get<IEnumerable<Country>>(null);
            foreach (var item in countries)
            {
                dropCountry.Items.Add(item);
            }

            IEnumerable<Studio> studios = await _studioService.Get<IEnumerable<Studio>>(null);
            foreach (var item in studios)
            {
                dropStudio.Items.Add(item);
            }

            IEnumerable<Language> languages = await _languageService.Get<IEnumerable<Language>>(null);
            foreach (var item in languages)
            {
                dropLanguage.Items.Add(item);
            }
            #endregion
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            Cover.Filter = "PNG Files|*.png|JPG Files|*.jpg" /*+ "|All Files|*.*"*/;
            Cover.InitialDirectory = $"{Properties.Settings.Default.InitialDirectory}";
            Cover.Multiselect = false;


            if (Cover.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CoverFileName = Cover.FileName;
                NewCoverImage = System.Drawing.Image.FromFile(CoverFileName);
                picCover.Image = new Bitmap(NewCoverImage, picCover.Width, picCover.Height);
            }
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtBudget.Text);
                double.Parse(txtBoxOffice.Text);
            }
            catch
            {
                MessageBox.Show("Both the budget and box office amount must be numbers!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtTitle.Text == "" || txtSynopsis.Text == "" ||
                txtDirector.Text == "" || txtBoxOffice.Text == "" || txtBudget.Text == "") {
                MessageBox.Show("Please enter all the required fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dropCountry.SelectedIndex == -1 || dropLanguage.SelectedIndex == -1 ||
                dropGenre.SelectedIndex == -1 || dropStudio.SelectedIndex == -1)
            {
                MessageBox.Show("Make sure you assigned the country, studio, genre and a language to the movie you're adding!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int width = NewCoverImage.Width;
            int height = NewCoverImage.Height;
            if (!((width == 300 && height == 450) ||
                (width == 512 && height == 768) ||
                (width == 800 && height == 1200)))
            {
                MessageBox.Show("The film cover's resolution is disallowed! Please try another image.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var model = new MediaInputModel
            {
                Title = txtTitle.Text,
                Synopsis = txtSynopsis.Text,
                Director = txtDirector.Text,
                ReleaseDate = dateRelease.Value,
                Budget = int.Parse(txtBudget.Text),
                WorldwideGross = double.Parse(txtBoxOffice.Text),
                GenreID = dropGenre.SelectedIndex + 1,
                CountryID = dropCountry.SelectedIndex + 1,
                LanguageID = dropLanguage.SelectedIndex + 1,
                StudioID = dropStudio.SelectedIndex + 1,
                RatingID = 1 // G default rating
            };

            var returns = await _mediaService.Insert<Media>(model);

            // Genre
            MediaGenre mediaGenre = new MediaGenre
            {
                MediaID = returns.MediaID,
                GenreID = model.GenreID
            };
            await $"{Properties.Settings.Default.APIUrl}/MediaContent/Genres"
                .WithBasicAuth(APIService.Username, APIService.Password)
                .PostJsonAsync(mediaGenre);

            // Country
            MediaCountry mediaCountry = new MediaCountry
            {
                MediaID = returns.MediaID,
                CountryID = model.CountryID
            };
            await $"{Properties.Settings.Default.APIUrl}/MediaContent/Countries"
                .WithBasicAuth(APIService.Username, APIService.Password)
                .PostJsonAsync(mediaCountry);

            // Language
            MediaLanguage mediaLanguage = new MediaLanguage
            {
                MediaID = returns.MediaID,
                LanguageID = model.LanguageID
            };
            await $"{Properties.Settings.Default.APIUrl}/MediaContent/Languages"
                .WithBasicAuth(APIService.Username, APIService.Password)
                .PostJsonAsync(mediaLanguage);

            // Copy newly added avatar to Assets/Avatars
            string coverLocation = await $"{Properties.Settings.Default.APIUrl}/info/covers".GetStringAsync();
            string fileName = "";
            try
            {
                fileName = Path.GetFileName(Cover.FileName);
            }
            catch
            {
                fileName = "Default.png";
            }

            if (fileName != "Default.png" && fileName != "")
            {
                System.IO.File.Copy(Cover.FileName, $@"{coverLocation}\{fileName}");
            }
            else if (fileName == "")
            {
                fileName = "Default.png";
            }
            model.CoverLocation = $"/Assets/Covers/{fileName}";

            Models.Image cover = new Models.Image
            {
                Location = model.CoverLocation,
                MediaID = returns.MediaID
            };
            var imgReturns = await _imagesService.Insert<Models.Image>(cover);

            MessageBox.Show("Media added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtTitle_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider((MetroFramework.Controls.MetroTextBox)sender, e, "Required", 5);
        }

        private void TxtSynopsis_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider((MetroFramework.Controls.MetroTextBox)sender, e, "Required", 5);
        }

        private void TxtDirector_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider((MetroFramework.Controls.MetroTextBox)sender, e, "Required", 5);
        }

        private void TxtBudget_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider((MetroFramework.Controls.MetroTextBox)sender, e, "Required", 5);
        }

        private void TxtBoxOffice_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider((MetroFramework.Controls.MetroTextBox)sender, e, "Required", 5);
        }

        private void DropGenre_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider((MetroFramework.Controls.MetroComboBox)sender, e, "Required", 2);
        }

        private void DropLanguage_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider((MetroFramework.Controls.MetroComboBox)sender, e, "Required", 2);
        }

        private void DropCountry_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider((MetroFramework.Controls.MetroComboBox)sender, e, "Required", 2);
        }

        private void DropStudio_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider((MetroFramework.Controls.MetroComboBox)sender, e, "Required", 2);
        }

        bool allowSubmit = true;
        private void SetErrorProvider(Control control, CancelEventArgs e, string message, int padding)
        {
            // Check if the control is empty
            if (string.IsNullOrWhiteSpace(control.Text) || control.Text == "")
            {
                allowSubmit = false;
                errorProvider.SetIconPadding(control, padding);
                errorProvider.SetError(control, message);
            }
            else // If not empty, then proceed
            {
                allowSubmit = true;
                errorProvider.SetError(control, null);

                // Check for digit and punctuation problems
                if ((control == txtDirector) && 
                    (control.Text.Any(char.IsDigit) || control.Text.Any(char.IsPunctuation)))
                {
                    message = "Can't contain any numbers or punctuation characters";
                    allowSubmit = false;
                    errorProvider.SetIconPadding(control, padding);
                    errorProvider.SetError(control, message);
                }
                else if ((control == txtBudget || control == txtBoxOffice) && 
                    (!control.Text.Any(char.IsDigit)))
                {
                    message = "Field allows only numbers";
                    allowSubmit = false;
                    errorProvider.SetIconPadding(control, padding);
                    errorProvider.SetError(control, message);
                }
            }

            if (!allowSubmit)
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }
    }
}
