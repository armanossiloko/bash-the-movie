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
using BTM.Models.Requests;
using Flurl.Http;
using MetroFramework.Controls;
using MetroFramework.Forms;
namespace BTM.WinUI.Content
{
    public partial class frmAddNews : MetroForm
    {
        private System.Drawing.Image Render = null;
        private System.Drawing.Image Logo = null;

        private OpenFileDialog RenderDialog = new OpenFileDialog();
        private OpenFileDialog LogoDialog = new OpenFileDialog();

        private string RenderFile = "";
        private string LogoFile = "";

        APIService _newsService = new APIService("news");

        public frmAddNews()
        {
            InitializeComponent();
            this.errorProvider.Icon = new System.Drawing.Icon(Global.ErrorIcon);
        }

        private void FrmAddNews_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            RenderDialog.Filter = "PNG Files|*.png|JPG Files|*.jpg" /*+ "|All Files|*.*"*/;
            RenderDialog.InitialDirectory = $"{Properties.Settings.Default.InitialDirectory}";
            RenderDialog.Multiselect = false;


            if (RenderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RenderFile = RenderDialog.FileName;
                Render = System.Drawing.Image.FromFile(RenderFile);
                picPreview.Image = new Bitmap(Render, picPreview.Width, picPreview.Height);
            }
        }

        private void BtnBrowseLogo_Click(object sender, EventArgs e)
        {
            LogoDialog.Filter = "PNG Files|*.png|JPG Files|*.jpg" /*+ "|All Files|*.*"*/;
            LogoDialog.InitialDirectory = $"{Properties.Settings.Default.InitialDirectory}";
            LogoDialog.Multiselect = false;


            if (LogoDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LogoFile = LogoDialog.FileName;
                Logo = System.Drawing.Image.FromFile(LogoFile);
                picLogo.Image = new Bitmap(Logo, picLogo.Width, picLogo.Height);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
			if (txtTitle.Text == "" || txtArticle.Text == "" || txtDescription.Text == "")
			{
				MessageBox.Show("Please add a title and description!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
			}
			
            if (Logo == null || Render == null)
            {
                MessageBox.Show("You must upload a logo and a render!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int logoWidth = Logo.Width;
            int logoHeight = Logo.Height;
            if (!(logoWidth == 256 && logoHeight == 256))
            {
                MessageBox.Show("The logo's resolution must be 256x256px!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int renderWidth = Render.Width;
            int renderHeight = Render.Height;
            if (!(renderWidth == 1920 && renderHeight == 1080))
            {
                MessageBox.Show("The render must be in Full HD (1920x1080px)!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Models.User submitter = await $"{Properties.Settings.Default.APIUrl}/users/userid/{APIService.Username}".GetJsonAsync<Models.User>();

            if (submitter == null)
            {
                MessageBox.Show("Your user ID is invalid!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var model = new NewsInputModel
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                Content = txtArticle.Text,
                DateAdded = DateTime.Now,
                UserID = submitter.Id
            };

            string News = await $"{Properties.Settings.Default.APIUrl}/info/news".GetStringAsync();
            string Logos = await $"{Properties.Settings.Default.APIUrl}/info/news/logos".GetStringAsync();

            string RenderFileName = Path.GetFileName(RenderDialog.FileName);
            string LogoFileName = Path.GetFileName(LogoDialog.FileName);

            try
            {
                System.IO.File.Copy(RenderDialog.FileName, $@"{News}\{RenderFileName}");
                System.IO.File.Copy(LogoDialog.FileName, $@"{Logos}\{LogoFileName}");
            }
            catch { }

            model.Logo = $"/Assets/News/{LogoFileName}";
			model.Image = $"/Assets/News/Logos/{RenderFileName}";

            try
            {
                var returns = await _newsService.Insert<dynamic>(model);
                MessageBox.Show("News article added successfully", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TxtTitle_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider((MetroTextBox)sender, e, "Required", 5);
        }

        private void TxtDescription_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider((MetroTextBox)sender, e, "Required", 5);
        }

        private void TxtArticle_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider((MetroTextBox)sender, e, "Required", 5);
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
            else
            {
                allowSubmit = true;
                errorProvider.SetError(control, null);
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
