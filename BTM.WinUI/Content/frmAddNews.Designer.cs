namespace BTM.WinUI.Content
{
    partial class frmAddNews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNews));
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtTitle = new MetroFramework.Controls.MetroTextBox();
            this.txtArticle = new MetroFramework.Controls.MetroTextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnBrowseLogo = new MetroFramework.Controls.MetroButton();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.lblAllowedDimensions = new MetroFramework.Controls.MetroLabel();
            this.lblLogoDimensions = new MetroFramework.Controls.MetroLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(744, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(663, 432);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // picPreview
            // 
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Location = new System.Drawing.Point(399, 63);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(420, 236);
            this.picPreview.TabIndex = 2;
            this.picPreview.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(744, 305);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(283, 2);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(23, 92);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PromptText = "Description";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(339, 58);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMark = "Description";
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDescription_Validating);
            // 
            // txtTitle
            // 
            // 
            // 
            // 
            this.txtTitle.CustomButton.Image = null;
            this.txtTitle.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.txtTitle.CustomButton.Name = "";
            this.txtTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitle.CustomButton.TabIndex = 1;
            this.txtTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitle.CustomButton.UseSelectable = true;
            this.txtTitle.CustomButton.Visible = false;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(23, 63);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PromptText = "Title";
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(339, 23);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTitle.UseSelectable = true;
            this.txtTitle.WaterMark = "Title";
            this.txtTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTitle_Validating);
            // 
            // txtArticle
            // 
            // 
            // 
            // 
            this.txtArticle.CustomButton.Image = null;
            this.txtArticle.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtArticle.CustomButton.Name = "";
            this.txtArticle.CustomButton.Size = new System.Drawing.Size(141, 141);
            this.txtArticle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtArticle.CustomButton.TabIndex = 1;
            this.txtArticle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtArticle.CustomButton.UseSelectable = true;
            this.txtArticle.CustomButton.Visible = false;
            this.txtArticle.Lines = new string[0];
            this.txtArticle.Location = new System.Drawing.Point(23, 156);
            this.txtArticle.MaxLength = 32767;
            this.txtArticle.Multiline = true;
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.PasswordChar = '\0';
            this.txtArticle.PromptText = "Article";
            this.txtArticle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtArticle.SelectedText = "";
            this.txtArticle.SelectionLength = 0;
            this.txtArticle.SelectionStart = 0;
            this.txtArticle.ShortcutsEnabled = true;
            this.txtArticle.Size = new System.Drawing.Size(339, 143);
            this.txtArticle.TabIndex = 8;
            this.txtArticle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtArticle.UseSelectable = true;
            this.txtArticle.WaterMark = "Article";
            this.txtArticle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtArticle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtArticle.Validating += new System.ComponentModel.CancelEventHandler(this.TxtArticle_Validating);
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(23, 305);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 150);
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // btnBrowseLogo
            // 
            this.btnBrowseLogo.Location = new System.Drawing.Point(179, 432);
            this.btnBrowseLogo.Name = "btnBrowseLogo";
            this.btnBrowseLogo.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseLogo.TabIndex = 10;
            this.btnBrowseLogo.Text = "Browse";
            this.btnBrowseLogo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBrowseLogo.UseSelectable = true;
            this.btnBrowseLogo.Click += new System.EventHandler(this.BtnBrowseLogo_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDate.Location = new System.Drawing.Point(179, 305);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 25);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Logo";
            this.lblDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblAllowedDimensions
            // 
            this.lblAllowedDimensions.AutoSize = true;
            this.lblAllowedDimensions.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblAllowedDimensions.Location = new System.Drawing.Point(399, 305);
            this.lblAllowedDimensions.Name = "lblAllowedDimensions";
            this.lblAllowedDimensions.Size = new System.Drawing.Size(173, 15);
            this.lblAllowedDimensions.TabIndex = 24;
            this.lblAllowedDimensions.Text = "Allowed dimensions: 1920x1080px";
            this.lblAllowedDimensions.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblLogoDimensions
            // 
            this.lblLogoDimensions.AutoSize = true;
            this.lblLogoDimensions.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblLogoDimensions.Location = new System.Drawing.Point(179, 330);
            this.lblLogoDimensions.Name = "lblLogoDimensions";
            this.lblLogoDimensions.Size = new System.Drawing.Size(165, 15);
            this.lblLogoDimensions.TabIndex = 25;
            this.lblLogoDimensions.Text = "Allowed dimensions: 256x256px";
            this.lblLogoDimensions.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmAddNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 481);
            this.Controls.Add(this.lblLogoDimensions);
            this.Controls.Add(this.lblAllowedDimensions);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnBrowseLogo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.txtArticle);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmAddNews";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Add News";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FrmAddNews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.PictureBox picPreview;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroTextBox txtTitle;
        private MetroFramework.Controls.MetroTextBox txtArticle;
        private System.Windows.Forms.PictureBox picLogo;
        private MetroFramework.Controls.MetroButton btnBrowseLogo;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroLabel lblAllowedDimensions;
        private MetroFramework.Controls.MetroLabel lblLogoDimensions;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}