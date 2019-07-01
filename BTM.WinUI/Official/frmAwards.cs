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

namespace BTM.WinUI.Official
{
    public partial class frmAwards : MetroForm
    {
        APIService _mediaService = new APIService("Media");
        APIService _imagesService = new APIService("Images");

        public frmAwards()
        {
            InitializeComponent();
            this.errorProvider.Icon = new System.Drawing.Icon(Global.ErrorIcon);
        }

        private async void FrmAwards_Load(object sender, EventArgs e)
        {
            IEnumerable<Media> movies = await _mediaService.Get<IEnumerable<Media>>(null);
            foreach (var item in movies)
            {
                comboMovie.Items.Add(item);
            }

            IEnumerable<AwardShow> awardShows = await $"{Properties.Settings.Default.APIUrl}/AwardInfo/awardshows".GetJsonAsync<IEnumerable<AwardShow>>();
            foreach (var item in awardShows)
            {
                comboAwardShow.Items.Add(item);
            }

            IEnumerable<AwardType> awardTypes = await $"{Properties.Settings.Default.APIUrl}/AwardInfo/awardtypes".GetJsonAsync<IEnumerable<AwardType>>();
            foreach (var item in awardTypes)
            {
                comboAwardType.Items.Add(item);
            }

            btnAdd.Enabled = false;
        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            Control control = (MetroFramework.Controls.MetroTextBox)sender;
            if (control.Text == "")
            {
                errorProvider.SetError(control, "Required");
                errorProvider.SetIconPadding(control, 5);
            }
            else
            {
                errorProvider.SetError(control, null);
            }
        }

        private void TxtYear_Validating(object sender, CancelEventArgs e)
        {
            bool allowSubmit = true;
            Control control = (MetroFramework.Controls.MetroTextBox)sender;
            if (control.Text == "")
            {
                errorProvider.SetError(control, "Required");
                errorProvider.SetIconPadding(control, 5);
                allowSubmit = false;
            }
            else
            {
                try
                {
                    int a = int.Parse(control.Text);
                    errorProvider.SetError(control, null);
                    allowSubmit = true;
                }
                catch (Exception)
                {
                    errorProvider.SetError(control, "Year can contain only numbers");
                    allowSubmit = false;
                }
            }

            if (allowSubmit)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
			try
            {
                int.Parse(txtYear.Text);
            }
            catch
            {
                MessageBox.Show("The year you entered is invalid!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

			if (txtName.Text == "" || txtYear.Text == "")
			{
				MessageBox.Show("Enter all the required fields!", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
			}

            if (comboAwardShow.SelectedIndex == -1 || comboAwardType.SelectedIndex == -1 ||
                comboMovie.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Award show, and award type and a movie to assing the award to!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
			
            try
            {
                AwardInputModel model = new AwardInputModel
                {
                    Name = txtName.Text,
                    Year = int.Parse(txtYear.Text),
                    AwardShowID = comboAwardShow.SelectedIndex + 1,
                    AwardTypeID = comboAwardType.SelectedIndex + 1,
                    MediaID = comboMovie.SelectedIndex + 1
                };
                var returns = await $"{Properties.Settings.Default.APIUrl}/Awards"
                    .WithBasicAuth(APIService.Username, APIService.Password)
                    .PostJsonAsync(model)
                    .ReceiveJson<Award>();
                MessageBox.Show("Award added successfully!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ComboMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BTM.Models.Image image = await $"{Properties.Settings.Default.APIUrl}/Images/{comboMovie.SelectedIndex + 1}"
                .GetJsonAsync<BTM.Models.Image>();

                string Images = await $"{Properties.Settings.Default.APIUrl}/Info/covers".GetStringAsync();
                string ImageName = Path.GetFileName(image.Location);
                Bitmap bitmap = new Bitmap(System.Drawing.Image.FromFile($"{Images}/{ImageName}"), picCover.Width, picCover.Height);
                picCover.Image = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
