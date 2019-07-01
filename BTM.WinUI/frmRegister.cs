using BTM.Models;
using BTM.Models.Requests;
using Flurl.Http;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTM.WinUI
{
    public partial class frmRegister : MetroForm
    {
        APIService _service = new APIService("Users");
        private bool registerAdmin = false;
        public frmRegister(bool registerAdmin = false)
        {
            InitializeComponent();
            this.registerAdmin = registerAdmin;
            this.errorProvider.Icon = new System.Drawing.Icon(Global.ErrorIcon);
            this.picAvatar.Image = new System.Drawing.Bitmap(Global.DefAvatar);
        }
         
        private async void FrmRegister_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager;
            SetAvatar();
            string Default = await $"{Properties.Settings.Default.APIUrl}/Info/defaultavatar".GetStringAsync();
            Global.DefaultAvatar = System.Drawing.Image.FromFile(Default);
            //btnCancel.CausesValidation = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBrowse_Click(object sender, EventArgs e)
        {
            this.txtBrowse.Text = Browse();
            SetAvatar();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            this.txtBrowse.Text = Browse();
            SetAvatar();
        }

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
			if (txtUsername.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || 
                txtPasswordConfirmation.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "")
            {
                MessageBox.Show("Enter all the required fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
			
            var entity = new UserRegistrationModel
            {
                Username = txtUsername.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                PasswordConfirmation = txtPasswordConfirmation.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                MiddleName = txtMiddleName.Text,
                //Avatar to be set later
                DateOfBirth = dateBirthdate.Value,
                FBLink = txtFacebook.Text,
                InstagramLink = txtInstagram.Text,
                LinkedInLink = txtLinkedIn.Text,
                TwitterLink = txtTwitter.Text,
                Roles = new List<int>()
            };
            entity.Roles.Add(1);
            if (registerAdmin)
            {
                entity.Roles.Add(2); //Admin
            }

            // Copy newly added avatar to Assets/Avatars
            string avatarLocation = await $"{Properties.Settings.Default.APIUrl}/info/avatars".GetStringAsync();
            string fileName = await GetFileName();
            if (fileName != "Default.png" && fileName != "")
            {
                System.IO.File.Copy(txtBrowse.Text, $@"{avatarLocation}\{fileName}");
            }

            entity.Avatar = $"/Assets/Avatars/{fileName}";

            try
            {
                var createdUser = await _service.Insert<User>(entity);
				MessageBox.Show("Registration successful");
				this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Obsolete
        private async void Backup()
        {
            var entity = new UserRegistrationModel
            {
                Username = "root",
                Email = "root@root.com",
                Password = "root",
                PasswordConfirmation = "root",
                FirstName = "Root",
                LastName = "User",
                MiddleName = "TBA",
                Roles = new List<int>()
            };
            entity.Roles.Add(1);
            entity.Roles.Add(2); //Admin

            var createdUser = await _service.Insert<User>(entity);
        }
        #endregion

        #region Support Methods
        // Tries to set the picture box (avatar) to the image from the txtBrowse textbox
        // Sets to default image if any exception occurs
        private void SetAvatar()
        {
            try
            {
                if (txtBrowse.Text != "")
                {
                    picAvatar.Image = CreatePicture();
                }
            }
            catch
            {
                picAvatar.Image = Global.DefaultAvatar;
            }
        }

        // Creates an Image object depending on the txtBrowse.Text value
        private System.Drawing.Image CreatePicture()
        {
            return new Bitmap(System.Drawing.Image.FromFile(txtBrowse.Text), picAvatar.Width, picAvatar.Height);
        }

        // Opens a file dialog for picture selection and returns the selected picture location
        private string Browse()
        {
            //return "../BTM.WebAPI/Assets/Avatars/default.gif";

            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "PNG Files|*.png" /*+ "|All Files|*.*"*/;
            Open.InitialDirectory = $"{Properties.Settings.Default.InitialDirectory}";
            Open.Multiselect = false;


            if (Open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return Open.FileName;
            }
            return txtBrowse.Text;
        }

        private async Task<string> GetFileName()
        {
            string fullDefault = await $"{Properties.Settings.Default.APIUrl}/info/defaultavatar".GetStringAsync();
            try
            {
                if (txtBrowse.Text == "")
                {
                    throw new Exception();
                }
                return Path.GetFileName(txtBrowse.Text); // Filename.png
            }
            catch
            {
                return Path.GetFileName(fullDefault); // Default.png
            }
        }

        private bool allowSubmit = true;
        private void SetErrorProvider(Control control, string message, int padding, CancelEventArgs e/*, bool checkPassword = false*/)
        {
            Regex regex = new Regex("^[a-zA-Z ]*$");


            // Check if the control is empty
            if (string.IsNullOrWhiteSpace(control.Text) || control.Text == "")
            {
                allowSubmit = false;
                //e.Cancel = true;
                errorProvider.SetIconPadding(control, padding);
                errorProvider.SetError(control, message);
            }
            else // If not empty, then proceed
            {
                allowSubmit = true;
                //e.Cancel = false;
                errorProvider.SetError(control, null);

                // Check whether passwords are different
                if (control == txtPasswordConfirmation && txtPassword.Text != txtPasswordConfirmation.Text)
                {
                    message = "Passwords do not match";
                    allowSubmit = false;
                    //e.Cancel = true;
                    errorProvider.SetIconPadding(control, padding);
                    errorProvider.SetError(control, message);
                }
                else if ((control == txtFirstName || control == txtLastName) && 
                    (control.Text.Any(char.IsDigit) || control.Text.Any(char.IsPunctuation)))
                {
                    message = "Can't contain any numbers or punctuation characters";
                    allowSubmit = false;
                    errorProvider.SetIconPadding(control, padding);
                    errorProvider.SetError(control, message);
                }
                else if (control == txtEmail)
                {
                    try
                    {
                        MailAddress mailAddress = new MailAddress(txtEmail.Text);
                    }
                    catch 
                    {
                        message = "Invalid email!";
                        allowSubmit = false;
                        errorProvider.SetIconPadding(control, padding);
                        errorProvider.SetError(control, message);
                    }
                }
            }

            if (!allowSubmit)
            {
                btnRegister.Enabled = false;
            }
            else
            {
                btnRegister.Enabled = true;
            }
        }
        #endregion

        private void TxtUsername_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider(txtUsername, "Required field", 5, e);
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider(txtEmail, "Required field", 5, e);
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider(txtPassword, "Required field", 5, e);
        }

        private void TxtPasswordConfirmation_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider(txtPasswordConfirmation, "Required field", 5, e);
        }

        private void TxtFirstName_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider(txtFirstName, "Required field", 5, e);
        }

        private void TxtLastName_Validating(object sender, CancelEventArgs e)
        {
            SetErrorProvider(txtLastName, "Required field", 5, e);
        }
    }
}
