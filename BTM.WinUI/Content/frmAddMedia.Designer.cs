namespace BTM.WinUI.Content
{
    partial class frmAddMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMedia));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.txtTitle = new MetroFramework.Controls.MetroTextBox();
            this.txtSynopsis = new MetroFramework.Controls.MetroTextBox();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.txtDirector = new MetroFramework.Controls.MetroTextBox();
            this.txtBudget = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxOffice = new MetroFramework.Controls.MetroTextBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.dropGenre = new MetroFramework.Controls.MetroComboBox();
            this.dropCountry = new MetroFramework.Controls.MetroComboBox();
            this.dropStudio = new MetroFramework.Controls.MetroComboBox();
            this.dropLanguage = new MetroFramework.Controls.MetroComboBox();
            this.dateRelease = new MetroFramework.Controls.MetroDateTime();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.lblGenre = new MetroFramework.Controls.MetroLabel();
            this.lblLanguage = new MetroFramework.Controls.MetroLabel();
            this.lblStudio = new MetroFramework.Controls.MetroLabel();
            this.lblCountry = new MetroFramework.Controls.MetroLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAllowedDimensions = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtTitle
            // 
            // 
            // 
            // 
            this.txtTitle.CustomButton.Image = null;
            this.txtTitle.CustomButton.Location = new System.Drawing.Point(345, 1);
            this.txtTitle.CustomButton.Name = "";
            this.txtTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitle.CustomButton.TabIndex = 1;
            this.txtTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitle.CustomButton.UseSelectable = true;
            this.txtTitle.CustomButton.Visible = false;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(39, 63);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PromptText = "Title";
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(367, 23);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTitle.UseSelectable = true;
            this.txtTitle.WaterMark = "Title";
            this.txtTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTitle_Validating);
            // 
            // txtSynopsis
            // 
            // 
            // 
            // 
            this.txtSynopsis.CustomButton.Image = null;
            this.txtSynopsis.CustomButton.Location = new System.Drawing.Point(277, 1);
            this.txtSynopsis.CustomButton.Name = "";
            this.txtSynopsis.CustomButton.Size = new System.Drawing.Size(89, 89);
            this.txtSynopsis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSynopsis.CustomButton.TabIndex = 1;
            this.txtSynopsis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSynopsis.CustomButton.UseSelectable = true;
            this.txtSynopsis.CustomButton.Visible = false;
            this.txtSynopsis.Lines = new string[0];
            this.txtSynopsis.Location = new System.Drawing.Point(39, 92);
            this.txtSynopsis.MaxLength = 32767;
            this.txtSynopsis.Multiline = true;
            this.txtSynopsis.Name = "txtSynopsis";
            this.txtSynopsis.PasswordChar = '\0';
            this.txtSynopsis.PromptText = "Synopsis";
            this.txtSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSynopsis.SelectedText = "";
            this.txtSynopsis.SelectionLength = 0;
            this.txtSynopsis.SelectionStart = 0;
            this.txtSynopsis.ShortcutsEnabled = true;
            this.txtSynopsis.Size = new System.Drawing.Size(367, 91);
            this.txtSynopsis.TabIndex = 1;
            this.txtSynopsis.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSynopsis.UseSelectable = true;
            this.txtSynopsis.WaterMark = "Synopsis";
            this.txtSynopsis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSynopsis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSynopsis.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSynopsis_Validating);
            // 
            // picCover
            // 
            this.picCover.Location = new System.Drawing.Point(445, 39);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(235, 345);
            this.picCover.TabIndex = 2;
            this.picCover.TabStop = false;
            // 
            // txtDirector
            // 
            // 
            // 
            // 
            this.txtDirector.CustomButton.Image = null;
            this.txtDirector.CustomButton.Location = new System.Drawing.Point(345, 1);
            this.txtDirector.CustomButton.Name = "";
            this.txtDirector.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDirector.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDirector.CustomButton.TabIndex = 1;
            this.txtDirector.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDirector.CustomButton.UseSelectable = true;
            this.txtDirector.CustomButton.Visible = false;
            this.txtDirector.Lines = new string[0];
            this.txtDirector.Location = new System.Drawing.Point(39, 189);
            this.txtDirector.MaxLength = 32767;
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.PasswordChar = '\0';
            this.txtDirector.PromptText = "Director";
            this.txtDirector.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDirector.SelectedText = "";
            this.txtDirector.SelectionLength = 0;
            this.txtDirector.SelectionStart = 0;
            this.txtDirector.ShortcutsEnabled = true;
            this.txtDirector.Size = new System.Drawing.Size(367, 23);
            this.txtDirector.TabIndex = 2;
            this.txtDirector.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtDirector.UseSelectable = true;
            this.txtDirector.WaterMark = "Director";
            this.txtDirector.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDirector.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDirector.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDirector_Validating);
            // 
            // txtBudget
            // 
            // 
            // 
            // 
            this.txtBudget.CustomButton.Image = null;
            this.txtBudget.CustomButton.Location = new System.Drawing.Point(345, 1);
            this.txtBudget.CustomButton.Name = "";
            this.txtBudget.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBudget.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBudget.CustomButton.TabIndex = 1;
            this.txtBudget.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBudget.CustomButton.UseSelectable = true;
            this.txtBudget.CustomButton.Visible = false;
            this.txtBudget.Lines = new string[0];
            this.txtBudget.Location = new System.Drawing.Point(39, 218);
            this.txtBudget.MaxLength = 32767;
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.PasswordChar = '\0';
            this.txtBudget.PromptText = "Budget";
            this.txtBudget.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBudget.SelectedText = "";
            this.txtBudget.SelectionLength = 0;
            this.txtBudget.SelectionStart = 0;
            this.txtBudget.ShortcutsEnabled = true;
            this.txtBudget.Size = new System.Drawing.Size(367, 23);
            this.txtBudget.TabIndex = 3;
            this.txtBudget.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtBudget.UseSelectable = true;
            this.txtBudget.WaterMark = "Budget";
            this.txtBudget.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBudget.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBudget.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBudget_Validating);
            // 
            // txtBoxOffice
            // 
            // 
            // 
            // 
            this.txtBoxOffice.CustomButton.Image = null;
            this.txtBoxOffice.CustomButton.Location = new System.Drawing.Point(345, 1);
            this.txtBoxOffice.CustomButton.Name = "";
            this.txtBoxOffice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxOffice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxOffice.CustomButton.TabIndex = 1;
            this.txtBoxOffice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxOffice.CustomButton.UseSelectable = true;
            this.txtBoxOffice.CustomButton.Visible = false;
            this.txtBoxOffice.Lines = new string[0];
            this.txtBoxOffice.Location = new System.Drawing.Point(39, 247);
            this.txtBoxOffice.MaxLength = 32767;
            this.txtBoxOffice.Name = "txtBoxOffice";
            this.txtBoxOffice.PasswordChar = '\0';
            this.txtBoxOffice.PromptText = "Box Office";
            this.txtBoxOffice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxOffice.SelectedText = "";
            this.txtBoxOffice.SelectionLength = 0;
            this.txtBoxOffice.SelectionStart = 0;
            this.txtBoxOffice.ShortcutsEnabled = true;
            this.txtBoxOffice.Size = new System.Drawing.Size(367, 23);
            this.txtBoxOffice.TabIndex = 4;
            this.txtBoxOffice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtBoxOffice.UseSelectable = true;
            this.txtBoxOffice.WaterMark = "Box Office";
            this.txtBoxOffice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxOffice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxOffice.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxOffice_Validating);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(605, 390);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(635, 449);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(554, 449);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dropGenre
            // 
            this.dropGenre.FormattingEnabled = true;
            this.dropGenre.ItemHeight = 23;
            this.dropGenre.Location = new System.Drawing.Point(39, 338);
            this.dropGenre.Name = "dropGenre";
            this.dropGenre.Size = new System.Drawing.Size(174, 29);
            this.dropGenre.Style = MetroFramework.MetroColorStyle.Black;
            this.dropGenre.TabIndex = 6;
            this.dropGenre.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dropGenre.UseSelectable = true;
            this.dropGenre.Validating += new System.ComponentModel.CancelEventHandler(this.DropGenre_Validating);
            // 
            // dropCountry
            // 
            this.dropCountry.FormattingEnabled = true;
            this.dropCountry.ItemHeight = 23;
            this.dropCountry.Location = new System.Drawing.Point(39, 398);
            this.dropCountry.Name = "dropCountry";
            this.dropCountry.Size = new System.Drawing.Size(174, 29);
            this.dropCountry.Style = MetroFramework.MetroColorStyle.Black;
            this.dropCountry.TabIndex = 8;
            this.dropCountry.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dropCountry.UseSelectable = true;
            this.dropCountry.Validating += new System.ComponentModel.CancelEventHandler(this.DropCountry_Validating);
            // 
            // dropStudio
            // 
            this.dropStudio.FormattingEnabled = true;
            this.dropStudio.ItemHeight = 23;
            this.dropStudio.Location = new System.Drawing.Point(232, 398);
            this.dropStudio.Name = "dropStudio";
            this.dropStudio.Size = new System.Drawing.Size(174, 29);
            this.dropStudio.Style = MetroFramework.MetroColorStyle.Black;
            this.dropStudio.TabIndex = 9;
            this.dropStudio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dropStudio.UseSelectable = true;
            this.dropStudio.Validating += new System.ComponentModel.CancelEventHandler(this.DropStudio_Validating);
            // 
            // dropLanguage
            // 
            this.dropLanguage.FormattingEnabled = true;
            this.dropLanguage.ItemHeight = 23;
            this.dropLanguage.Location = new System.Drawing.Point(232, 338);
            this.dropLanguage.Name = "dropLanguage";
            this.dropLanguage.Size = new System.Drawing.Size(174, 29);
            this.dropLanguage.Style = MetroFramework.MetroColorStyle.Black;
            this.dropLanguage.TabIndex = 7;
            this.dropLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dropLanguage.UseSelectable = true;
            this.dropLanguage.Validating += new System.ComponentModel.CancelEventHandler(this.DropLanguage_Validating);
            // 
            // dateRelease
            // 
            this.dateRelease.Location = new System.Drawing.Point(206, 276);
            this.dateRelease.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateRelease.Name = "dateRelease";
            this.dateRelease.Size = new System.Drawing.Size(200, 29);
            this.dateRelease.TabIndex = 5;
            this.dateRelease.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDate.Location = new System.Drawing.Point(39, 276);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(113, 25);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Release Date:";
            this.lblDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(39, 316);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(47, 19);
            this.lblGenre.TabIndex = 19;
            this.lblGenre.Text = "Genre:";
            this.lblGenre.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(232, 316);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(69, 19);
            this.lblLanguage.TabIndex = 20;
            this.lblLanguage.Text = "Language:";
            this.lblLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblStudio
            // 
            this.lblStudio.AutoSize = true;
            this.lblStudio.Location = new System.Drawing.Point(232, 376);
            this.lblStudio.Name = "lblStudio";
            this.lblStudio.Size = new System.Drawing.Size(49, 19);
            this.lblStudio.TabIndex = 21;
            this.lblStudio.Text = "Studio:";
            this.lblStudio.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(39, 376);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(59, 19);
            this.lblCountry.TabIndex = 22;
            this.lblCountry.Text = "Country:";
            this.lblCountry.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // lblAllowedDimensions
            // 
            this.lblAllowedDimensions.AutoSize = true;
            this.lblAllowedDimensions.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblAllowedDimensions.Location = new System.Drawing.Point(425, 416);
            this.lblAllowedDimensions.Name = "lblAllowedDimensions";
            this.lblAllowedDimensions.Size = new System.Drawing.Size(285, 15);
            this.lblAllowedDimensions.TabIndex = 23;
            this.lblAllowedDimensions.Text = "Allowed dimensions: 300x450px, 512x768px, 800x1200px";
            this.lblAllowedDimensions.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // frmAddMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 495);
            this.Controls.Add(this.lblAllowedDimensions);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblStudio);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateRelease);
            this.Controls.Add(this.dropStudio);
            this.Controls.Add(this.dropLanguage);
            this.Controls.Add(this.dropCountry);
            this.Controls.Add(this.dropGenre);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtBoxOffice);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.picCover);
            this.Controls.Add(this.txtSynopsis);
            this.Controls.Add(this.txtTitle);
            this.MaximizeBox = false;
            this.Name = "frmAddMedia";
            this.Resizable = false;
            this.Text = "Add Media";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FrmAddMedia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTextBox txtTitle;
        private MetroFramework.Controls.MetroTextBox txtSynopsis;
        private System.Windows.Forms.PictureBox picCover;
        private MetroFramework.Controls.MetroTextBox txtDirector;
        private MetroFramework.Controls.MetroTextBox txtBudget;
        private MetroFramework.Controls.MetroTextBox txtBoxOffice;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroComboBox dropGenre;
        private MetroFramework.Controls.MetroComboBox dropCountry;
        private MetroFramework.Controls.MetroComboBox dropStudio;
        private MetroFramework.Controls.MetroComboBox dropLanguage;
        private MetroFramework.Controls.MetroDateTime dateRelease;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroLabel lblGenre;
        private MetroFramework.Controls.MetroLabel lblLanguage;
        private MetroFramework.Controls.MetroLabel lblStudio;
        private MetroFramework.Controls.MetroLabel lblCountry;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MetroFramework.Controls.MetroLabel lblAllowedDimensions;
    }
}