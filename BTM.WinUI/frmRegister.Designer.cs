namespace BTM.WinUI
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.lblPasswordConfirmation = new MetroFramework.Controls.MetroLabel();
            this.txtPasswordConfirmation = new MetroFramework.Controls.MetroTextBox();
            this.lblFirstName = new MetroFramework.Controls.MetroLabel();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.lblMiddleName = new MetroFramework.Controls.MetroLabel();
            this.txtMiddleName = new MetroFramework.Controls.MetroTextBox();
            this.lblLastName = new MetroFramework.Controls.MetroLabel();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.lblFacebook = new MetroFramework.Controls.MetroLabel();
            this.txtFacebook = new MetroFramework.Controls.MetroTextBox();
            this.lblInstagram = new MetroFramework.Controls.MetroLabel();
            this.txtInstagram = new MetroFramework.Controls.MetroTextBox();
            this.lblLinkedIn = new MetroFramework.Controls.MetroLabel();
            this.txtLinkedIn = new MetroFramework.Controls.MetroTextBox();
            this.lblTwitter = new MetroFramework.Controls.MetroLabel();
            this.txtTwitter = new MetroFramework.Controls.MetroTextBox();
            this.dateBirthdate = new MetroFramework.Controls.MetroDateTime();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.txtBrowse = new MetroFramework.Controls.MetroTextBox();
            this.lblBirthdate = new MetroFramework.Controls.MetroLabel();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(180, 81);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(166, 23);
            this.txtUsername.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUsername_Validating);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(46, 85);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 19);
            this.lblUsername.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            this.lblUsername.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(46, 114);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 19);
            this.lblEmail.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(180, 110);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(166, 23);
            this.txtEmail.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(46, 143);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 19);
            this.lblPassword.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(180, 139);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(166, 23);
            this.txtPassword.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPassword_Validating);
            // 
            // lblPasswordConfirmation
            // 
            this.lblPasswordConfirmation.AutoSize = true;
            this.lblPasswordConfirmation.Location = new System.Drawing.Point(46, 172);
            this.lblPasswordConfirmation.Name = "lblPasswordConfirmation";
            this.lblPasswordConfirmation.Size = new System.Drawing.Size(121, 19);
            this.lblPasswordConfirmation.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPasswordConfirmation.TabIndex = 7;
            this.lblPasswordConfirmation.Text = "Re-enter Password:";
            this.lblPasswordConfirmation.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPasswordConfirmation
            // 
            // 
            // 
            // 
            this.txtPasswordConfirmation.CustomButton.Image = null;
            this.txtPasswordConfirmation.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtPasswordConfirmation.CustomButton.Name = "";
            this.txtPasswordConfirmation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPasswordConfirmation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswordConfirmation.CustomButton.TabIndex = 1;
            this.txtPasswordConfirmation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasswordConfirmation.CustomButton.UseSelectable = true;
            this.txtPasswordConfirmation.CustomButton.Visible = false;
            this.txtPasswordConfirmation.Lines = new string[0];
            this.txtPasswordConfirmation.Location = new System.Drawing.Point(180, 168);
            this.txtPasswordConfirmation.MaxLength = 32767;
            this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            this.txtPasswordConfirmation.PasswordChar = '*';
            this.txtPasswordConfirmation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordConfirmation.SelectedText = "";
            this.txtPasswordConfirmation.SelectionLength = 0;
            this.txtPasswordConfirmation.SelectionStart = 0;
            this.txtPasswordConfirmation.ShortcutsEnabled = true;
            this.txtPasswordConfirmation.Size = new System.Drawing.Size(166, 23);
            this.txtPasswordConfirmation.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswordConfirmation.TabIndex = 6;
            this.txtPasswordConfirmation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPasswordConfirmation.UseSelectable = true;
            this.txtPasswordConfirmation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasswordConfirmation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPasswordConfirmation.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPasswordConfirmation_Validating);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(46, 231);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 19);
            this.lblFirstName.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First name:";
            this.lblFirstName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtFirstName
            // 
            // 
            // 
            // 
            this.txtFirstName.CustomButton.Image = null;
            this.txtFirstName.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtFirstName.CustomButton.Name = "";
            this.txtFirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstName.CustomButton.TabIndex = 1;
            this.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstName.CustomButton.UseSelectable = true;
            this.txtFirstName.CustomButton.Visible = false;
            this.txtFirstName.Lines = new string[0];
            this.txtFirstName.Location = new System.Drawing.Point(180, 227);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.ShortcutsEnabled = true;
            this.txtFirstName.Size = new System.Drawing.Size(166, 23);
            this.txtFirstName.TabIndex = 8;
            this.txtFirstName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtFirstName.UseSelectable = true;
            this.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtFirstName_Validating);
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(46, 260);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(90, 19);
            this.lblMiddleName.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblMiddleName.TabIndex = 11;
            this.lblMiddleName.Text = "Middle name:";
            this.lblMiddleName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtMiddleName
            // 
            // 
            // 
            // 
            this.txtMiddleName.CustomButton.Image = null;
            this.txtMiddleName.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtMiddleName.CustomButton.Name = "";
            this.txtMiddleName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMiddleName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMiddleName.CustomButton.TabIndex = 1;
            this.txtMiddleName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMiddleName.CustomButton.UseSelectable = true;
            this.txtMiddleName.CustomButton.Visible = false;
            this.txtMiddleName.Lines = new string[0];
            this.txtMiddleName.Location = new System.Drawing.Point(180, 256);
            this.txtMiddleName.MaxLength = 32767;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.PasswordChar = '\0';
            this.txtMiddleName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMiddleName.SelectedText = "";
            this.txtMiddleName.SelectionLength = 0;
            this.txtMiddleName.SelectionStart = 0;
            this.txtMiddleName.ShortcutsEnabled = true;
            this.txtMiddleName.Size = new System.Drawing.Size(166, 23);
            this.txtMiddleName.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMiddleName.TabIndex = 10;
            this.txtMiddleName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtMiddleName.UseSelectable = true;
            this.txtMiddleName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMiddleName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(46, 289);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(71, 19);
            this.lblLastName.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblLastName.TabIndex = 13;
            this.lblLastName.Text = "Last name:";
            this.lblLastName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtLastName
            // 
            // 
            // 
            // 
            this.txtLastName.CustomButton.Image = null;
            this.txtLastName.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtLastName.CustomButton.Name = "";
            this.txtLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastName.CustomButton.TabIndex = 1;
            this.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastName.CustomButton.UseSelectable = true;
            this.txtLastName.CustomButton.Visible = false;
            this.txtLastName.Lines = new string[0];
            this.txtLastName.Location = new System.Drawing.Point(180, 285);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.Size = new System.Drawing.Size(166, 23);
            this.txtLastName.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastName.TabIndex = 12;
            this.txtLastName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtLastName.UseSelectable = true;
            this.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLastName_Validating);
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.Location = new System.Drawing.Point(46, 348);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(68, 19);
            this.lblFacebook.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblFacebook.TabIndex = 15;
            this.lblFacebook.Text = "Facebook:";
            this.lblFacebook.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtFacebook
            // 
            // 
            // 
            // 
            this.txtFacebook.CustomButton.Image = null;
            this.txtFacebook.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtFacebook.CustomButton.Name = "";
            this.txtFacebook.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFacebook.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFacebook.CustomButton.TabIndex = 1;
            this.txtFacebook.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFacebook.CustomButton.UseSelectable = true;
            this.txtFacebook.CustomButton.Visible = false;
            this.txtFacebook.Lines = new string[0];
            this.txtFacebook.Location = new System.Drawing.Point(180, 344);
            this.txtFacebook.MaxLength = 32767;
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.PasswordChar = '\0';
            this.txtFacebook.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFacebook.SelectedText = "";
            this.txtFacebook.SelectionLength = 0;
            this.txtFacebook.SelectionStart = 0;
            this.txtFacebook.ShortcutsEnabled = true;
            this.txtFacebook.Size = new System.Drawing.Size(166, 23);
            this.txtFacebook.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFacebook.TabIndex = 14;
            this.txtFacebook.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtFacebook.UseSelectable = true;
            this.txtFacebook.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFacebook.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblInstagram
            // 
            this.lblInstagram.AutoSize = true;
            this.lblInstagram.Location = new System.Drawing.Point(46, 377);
            this.lblInstagram.Name = "lblInstagram";
            this.lblInstagram.Size = new System.Drawing.Size(70, 19);
            this.lblInstagram.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblInstagram.TabIndex = 17;
            this.lblInstagram.Text = "Instagram:";
            this.lblInstagram.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtInstagram
            // 
            // 
            // 
            // 
            this.txtInstagram.CustomButton.Image = null;
            this.txtInstagram.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtInstagram.CustomButton.Name = "";
            this.txtInstagram.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInstagram.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInstagram.CustomButton.TabIndex = 1;
            this.txtInstagram.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInstagram.CustomButton.UseSelectable = true;
            this.txtInstagram.CustomButton.Visible = false;
            this.txtInstagram.Lines = new string[0];
            this.txtInstagram.Location = new System.Drawing.Point(180, 373);
            this.txtInstagram.MaxLength = 32767;
            this.txtInstagram.Name = "txtInstagram";
            this.txtInstagram.PasswordChar = '\0';
            this.txtInstagram.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInstagram.SelectedText = "";
            this.txtInstagram.SelectionLength = 0;
            this.txtInstagram.SelectionStart = 0;
            this.txtInstagram.ShortcutsEnabled = true;
            this.txtInstagram.Size = new System.Drawing.Size(166, 23);
            this.txtInstagram.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInstagram.TabIndex = 16;
            this.txtInstagram.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtInstagram.UseSelectable = true;
            this.txtInstagram.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInstagram.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblLinkedIn
            // 
            this.lblLinkedIn.AutoSize = true;
            this.lblLinkedIn.Location = new System.Drawing.Point(46, 406);
            this.lblLinkedIn.Name = "lblLinkedIn";
            this.lblLinkedIn.Size = new System.Drawing.Size(59, 19);
            this.lblLinkedIn.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblLinkedIn.TabIndex = 19;
            this.lblLinkedIn.Text = "LinkedIn:";
            this.lblLinkedIn.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtLinkedIn
            // 
            // 
            // 
            // 
            this.txtLinkedIn.CustomButton.Image = null;
            this.txtLinkedIn.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtLinkedIn.CustomButton.Name = "";
            this.txtLinkedIn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLinkedIn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLinkedIn.CustomButton.TabIndex = 1;
            this.txtLinkedIn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLinkedIn.CustomButton.UseSelectable = true;
            this.txtLinkedIn.CustomButton.Visible = false;
            this.txtLinkedIn.Lines = new string[0];
            this.txtLinkedIn.Location = new System.Drawing.Point(180, 402);
            this.txtLinkedIn.MaxLength = 32767;
            this.txtLinkedIn.Name = "txtLinkedIn";
            this.txtLinkedIn.PasswordChar = '\0';
            this.txtLinkedIn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLinkedIn.SelectedText = "";
            this.txtLinkedIn.SelectionLength = 0;
            this.txtLinkedIn.SelectionStart = 0;
            this.txtLinkedIn.ShortcutsEnabled = true;
            this.txtLinkedIn.Size = new System.Drawing.Size(166, 23);
            this.txtLinkedIn.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLinkedIn.TabIndex = 18;
            this.txtLinkedIn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtLinkedIn.UseSelectable = true;
            this.txtLinkedIn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLinkedIn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTwitter
            // 
            this.lblTwitter.AutoSize = true;
            this.lblTwitter.Location = new System.Drawing.Point(46, 435);
            this.lblTwitter.Name = "lblTwitter";
            this.lblTwitter.Size = new System.Drawing.Size(51, 19);
            this.lblTwitter.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblTwitter.TabIndex = 21;
            this.lblTwitter.Text = "Twitter:";
            this.lblTwitter.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtTwitter
            // 
            // 
            // 
            // 
            this.txtTwitter.CustomButton.Image = null;
            this.txtTwitter.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtTwitter.CustomButton.Name = "";
            this.txtTwitter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTwitter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTwitter.CustomButton.TabIndex = 1;
            this.txtTwitter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTwitter.CustomButton.UseSelectable = true;
            this.txtTwitter.CustomButton.Visible = false;
            this.txtTwitter.Lines = new string[0];
            this.txtTwitter.Location = new System.Drawing.Point(180, 431);
            this.txtTwitter.MaxLength = 32767;
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.PasswordChar = '\0';
            this.txtTwitter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTwitter.SelectedText = "";
            this.txtTwitter.SelectionLength = 0;
            this.txtTwitter.SelectionStart = 0;
            this.txtTwitter.ShortcutsEnabled = true;
            this.txtTwitter.Size = new System.Drawing.Size(166, 23);
            this.txtTwitter.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTwitter.TabIndex = 20;
            this.txtTwitter.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTwitter.UseSelectable = true;
            this.txtTwitter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTwitter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dateBirthdate
            // 
            this.dateBirthdate.Location = new System.Drawing.Point(455, 424);
            this.dateBirthdate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateBirthdate.Name = "dateBirthdate";
            this.dateBirthdate.Size = new System.Drawing.Size(200, 29);
            this.dateBirthdate.TabIndex = 22;
            this.dateBirthdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(555, 474);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnRegister.TabIndex = 23;
            this.btnRegister.Text = "Register";
            this.btnRegister.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(636, 474);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(455, 63);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(256, 256);
            this.picAvatar.TabIndex = 25;
            this.picAvatar.TabStop = false;
            // 
            // txtBrowse
            // 
            // 
            // 
            // 
            this.txtBrowse.CustomButton.Image = null;
            this.txtBrowse.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txtBrowse.CustomButton.Name = "";
            this.txtBrowse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBrowse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBrowse.CustomButton.TabIndex = 1;
            this.txtBrowse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBrowse.CustomButton.UseSelectable = true;
            this.txtBrowse.CustomButton.Visible = false;
            this.txtBrowse.Lines = new string[0];
            this.txtBrowse.Location = new System.Drawing.Point(455, 352);
            this.txtBrowse.MaxLength = 32767;
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.PasswordChar = '\0';
            this.txtBrowse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBrowse.SelectedText = "";
            this.txtBrowse.SelectionLength = 0;
            this.txtBrowse.SelectionStart = 0;
            this.txtBrowse.ShortcutsEnabled = true;
            this.txtBrowse.Size = new System.Drawing.Size(175, 23);
            this.txtBrowse.TabIndex = 28;
            this.txtBrowse.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtBrowse.UseSelectable = true;
            this.txtBrowse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBrowse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBrowse.Click += new System.EventHandler(this.TxtBrowse_Click);
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(455, 402);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(66, 19);
            this.lblBirthdate.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblBirthdate.TabIndex = 29;
            this.lblBirthdate.Text = "Birthdate:";
            this.lblBirthdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(636, 352);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnBrowse.TabIndex = 30;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.txtBrowse);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dateBirthdate);
            this.Controls.Add(this.lblTwitter);
            this.Controls.Add(this.txtTwitter);
            this.Controls.Add(this.lblLinkedIn);
            this.Controls.Add(this.txtLinkedIn);
            this.Controls.Add(this.lblInstagram);
            this.Controls.Add(this.txtInstagram);
            this.Controls.Add(this.lblFacebook);
            this.Controls.Add(this.txtFacebook);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblPasswordConfirmation);
            this.Controls.Add(this.txtPasswordConfirmation);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.Resizable = false;
            this.Text = "Register";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel lblPasswordConfirmation;
        private MetroFramework.Controls.MetroTextBox txtPasswordConfirmation;
        private MetroFramework.Controls.MetroLabel lblFirstName;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
        private MetroFramework.Controls.MetroLabel lblMiddleName;
        private MetroFramework.Controls.MetroTextBox txtMiddleName;
        private MetroFramework.Controls.MetroLabel lblLastName;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroLabel lblFacebook;
        private MetroFramework.Controls.MetroTextBox txtFacebook;
        private MetroFramework.Controls.MetroLabel lblInstagram;
        private MetroFramework.Controls.MetroTextBox txtInstagram;
        private MetroFramework.Controls.MetroLabel lblLinkedIn;
        private MetroFramework.Controls.MetroTextBox txtLinkedIn;
        private MetroFramework.Controls.MetroLabel lblTwitter;
        private MetroFramework.Controls.MetroTextBox txtTwitter;
        private MetroFramework.Controls.MetroDateTime dateBirthdate;
        private MetroFramework.Controls.MetroButton btnRegister;
        private MetroFramework.Controls.MetroButton btnCancel;
        private System.Windows.Forms.PictureBox picAvatar;
        private MetroFramework.Controls.MetroTextBox txtBrowse;
        private MetroFramework.Controls.MetroLabel lblBirthdate;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}