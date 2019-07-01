namespace BTM.WinUI.Official
{
    partial class frmAwards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAwards));
            this.txtYear = new MetroFramework.Controls.MetroTextBox();
            this.lblYear = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.comboAwardType = new MetroFramework.Controls.MetroComboBox();
            this.lblAwardType = new MetroFramework.Controls.MetroLabel();
            this.lblAwardShow = new MetroFramework.Controls.MetroLabel();
            this.comboAwardShow = new MetroFramework.Controls.MetroComboBox();
            this.lblMovie = new MetroFramework.Controls.MetroLabel();
            this.comboMovie = new MetroFramework.Controls.MetroComboBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYear
            // 
            // 
            // 
            // 
            this.txtYear.CustomButton.Image = null;
            this.txtYear.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtYear.CustomButton.Name = "";
            this.txtYear.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtYear.CustomButton.TabIndex = 1;
            this.txtYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtYear.CustomButton.UseSelectable = true;
            this.txtYear.CustomButton.Visible = false;
            this.txtYear.Lines = new string[0];
            this.txtYear.Location = new System.Drawing.Point(145, 118);
            this.txtYear.MaxLength = 32767;
            this.txtYear.Name = "txtYear";
            this.txtYear.PasswordChar = '\0';
            this.txtYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtYear.SelectedText = "";
            this.txtYear.SelectionLength = 0;
            this.txtYear.SelectionStart = 0;
            this.txtYear.ShortcutsEnabled = true;
            this.txtYear.Size = new System.Drawing.Size(214, 23);
            this.txtYear.TabIndex = 2;
            this.txtYear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtYear.UseSelectable = true;
            this.txtYear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtYear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtYear.Validating += new System.ComponentModel.CancelEventHandler(this.TxtYear_Validating);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(42, 118);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 19);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Year:";
            this.lblYear.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(145, 89);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(214, 23);
            this.txtName.TabIndex = 1;
            this.txtName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtName_Validating);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 19);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name: ";
            this.lblName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // comboAwardType
            // 
            this.comboAwardType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboAwardType.FormattingEnabled = true;
            this.comboAwardType.ItemHeight = 19;
            this.comboAwardType.Location = new System.Drawing.Point(145, 178);
            this.comboAwardType.Name = "comboAwardType";
            this.comboAwardType.Size = new System.Drawing.Size(214, 25);
            this.comboAwardType.TabIndex = 4;
            this.comboAwardType.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.comboAwardType.UseSelectable = true;
            // 
            // lblAwardType
            // 
            this.lblAwardType.AutoSize = true;
            this.lblAwardType.Location = new System.Drawing.Point(42, 178);
            this.lblAwardType.Name = "lblAwardType";
            this.lblAwardType.Size = new System.Drawing.Size(85, 19);
            this.lblAwardType.TabIndex = 14;
            this.lblAwardType.Text = "Award Type: ";
            this.lblAwardType.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblAwardShow
            // 
            this.lblAwardShow.AutoSize = true;
            this.lblAwardShow.Location = new System.Drawing.Point(42, 209);
            this.lblAwardShow.Name = "lblAwardShow";
            this.lblAwardShow.Size = new System.Drawing.Size(85, 19);
            this.lblAwardShow.TabIndex = 16;
            this.lblAwardShow.Text = "Award Show:";
            this.lblAwardShow.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // comboAwardShow
            // 
            this.comboAwardShow.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboAwardShow.FormattingEnabled = true;
            this.comboAwardShow.ItemHeight = 19;
            this.comboAwardShow.Location = new System.Drawing.Point(145, 209);
            this.comboAwardShow.Name = "comboAwardShow";
            this.comboAwardShow.Size = new System.Drawing.Size(214, 25);
            this.comboAwardShow.TabIndex = 5;
            this.comboAwardShow.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.comboAwardShow.UseSelectable = true;
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(42, 147);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(48, 19);
            this.lblMovie.TabIndex = 18;
            this.lblMovie.Text = "Movie:";
            this.lblMovie.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // comboMovie
            // 
            this.comboMovie.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboMovie.FormattingEnabled = true;
            this.comboMovie.ItemHeight = 19;
            this.comboMovie.Location = new System.Drawing.Point(145, 147);
            this.comboMovie.Name = "comboMovie";
            this.comboMovie.Size = new System.Drawing.Size(214, 25);
            this.comboMovie.TabIndex = 3;
            this.comboMovie.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.comboMovie.UseSelectable = true;
            this.comboMovie.SelectedIndexChanged += new System.EventHandler(this.ComboMovie_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(376, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(457, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // picCover
            // 
            this.picCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCover.Location = new System.Drawing.Point(397, 32);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(135, 202);
            this.picCover.TabIndex = 21;
            this.picCover.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmAwards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 289);
            this.Controls.Add(this.picCover);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.comboMovie);
            this.Controls.Add(this.lblAwardShow);
            this.Controls.Add(this.comboAwardShow);
            this.Controls.Add(this.lblAwardType);
            this.Controls.Add(this.comboAwardType);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.Name = "frmAwards";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Awards";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FrmAwards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtYear;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroComboBox comboAwardType;
        private MetroFramework.Controls.MetroLabel lblYear;
        private MetroFramework.Controls.MetroLabel lblAwardType;
        private MetroFramework.Controls.MetroLabel lblAwardShow;
        private MetroFramework.Controls.MetroComboBox comboAwardShow;
        private MetroFramework.Controls.MetroLabel lblMovie;
        private MetroFramework.Controls.MetroComboBox comboMovie;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnCancel;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}