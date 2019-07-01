namespace BTM.WinUI.Content
{
    partial class frmAddMediaContent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.verticalDivider = new System.Windows.Forms.PictureBox();
            this.txtTitle = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.gridResults = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPlotKeywords = new MetroFramework.Controls.MetroTextBox();
            this.lblPlotKeywords = new MetroFramework.Controls.MetroLabel();
            this.lblTrailer = new MetroFramework.Controls.MetroLabel();
            this.txtTrailer = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSoundtrack = new MetroFramework.Controls.MetroTextBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.verticalDivider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // verticalDivider
            // 
            this.verticalDivider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verticalDivider.Location = new System.Drawing.Point(343, 63);
            this.verticalDivider.Name = "verticalDivider";
            this.verticalDivider.Size = new System.Drawing.Size(1, 201);
            this.verticalDivider.TabIndex = 0;
            this.verticalDivider.TabStop = false;
            // 
            // txtTitle
            // 
            // 
            // 
            // 
            this.txtTitle.CustomButton.Image = null;
            this.txtTitle.CustomButton.Location = new System.Drawing.Point(196, 1);
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
            this.txtTitle.Size = new System.Drawing.Size(218, 23);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTitle.UseSelectable = true;
            this.txtTitle.WaterMark = "Title";
            this.txtTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(247, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // gridResults
            // 
            this.gridResults.AllowUserToAddRows = false;
            this.gridResults.AllowUserToDeleteRows = false;
            this.gridResults.AllowUserToResizeRows = false;
            this.gridResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.ReleaseDate});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridResults.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridResults.EnableHeadersVisualStyles = false;
            this.gridResults.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridResults.Location = new System.Drawing.Point(23, 92);
            this.gridResults.Name = "gridResults";
            this.gridResults.ReadOnly = true;
            this.gridResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridResults.Size = new System.Drawing.Size(299, 154);
            this.gridResults.Style = MetroFramework.MetroColorStyle.Purple;
            this.gridResults.TabIndex = 4;
            this.gridResults.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gridResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridResults_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 20;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 135;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            // 
            // txtPlotKeywords
            // 
            // 
            // 
            // 
            this.txtPlotKeywords.CustomButton.Image = null;
            this.txtPlotKeywords.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.txtPlotKeywords.CustomButton.Name = "";
            this.txtPlotKeywords.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPlotKeywords.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPlotKeywords.CustomButton.TabIndex = 1;
            this.txtPlotKeywords.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPlotKeywords.CustomButton.UseSelectable = true;
            this.txtPlotKeywords.CustomButton.Visible = false;
            this.txtPlotKeywords.Lines = new string[0];
            this.txtPlotKeywords.Location = new System.Drawing.Point(369, 92);
            this.txtPlotKeywords.MaxLength = 32767;
            this.txtPlotKeywords.Name = "txtPlotKeywords";
            this.txtPlotKeywords.PasswordChar = '\0';
            this.txtPlotKeywords.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPlotKeywords.SelectedText = "";
            this.txtPlotKeywords.SelectionLength = 0;
            this.txtPlotKeywords.SelectionStart = 0;
            this.txtPlotKeywords.ShortcutsEnabled = true;
            this.txtPlotKeywords.Size = new System.Drawing.Size(281, 23);
            this.txtPlotKeywords.TabIndex = 5;
            this.txtPlotKeywords.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPlotKeywords.UseSelectable = true;
            this.txtPlotKeywords.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPlotKeywords.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPlotKeywords
            // 
            this.lblPlotKeywords.AutoSize = true;
            this.lblPlotKeywords.Location = new System.Drawing.Point(369, 67);
            this.lblPlotKeywords.Name = "lblPlotKeywords";
            this.lblPlotKeywords.Size = new System.Drawing.Size(94, 19);
            this.lblPlotKeywords.TabIndex = 6;
            this.lblPlotKeywords.Text = "Plot Keywords:";
            this.lblPlotKeywords.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTrailer
            // 
            this.lblTrailer.AutoSize = true;
            this.lblTrailer.Location = new System.Drawing.Point(369, 129);
            this.lblTrailer.Name = "lblTrailer";
            this.lblTrailer.Size = new System.Drawing.Size(48, 19);
            this.lblTrailer.TabIndex = 8;
            this.lblTrailer.Text = "Trailer:";
            this.lblTrailer.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtTrailer
            // 
            // 
            // 
            // 
            this.txtTrailer.CustomButton.Image = null;
            this.txtTrailer.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.txtTrailer.CustomButton.Name = "";
            this.txtTrailer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTrailer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTrailer.CustomButton.TabIndex = 1;
            this.txtTrailer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTrailer.CustomButton.UseSelectable = true;
            this.txtTrailer.CustomButton.Visible = false;
            this.txtTrailer.Lines = new string[0];
            this.txtTrailer.Location = new System.Drawing.Point(369, 154);
            this.txtTrailer.MaxLength = 32767;
            this.txtTrailer.Name = "txtTrailer";
            this.txtTrailer.PasswordChar = '\0';
            this.txtTrailer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTrailer.SelectedText = "";
            this.txtTrailer.SelectionLength = 0;
            this.txtTrailer.SelectionStart = 0;
            this.txtTrailer.ShortcutsEnabled = true;
            this.txtTrailer.Size = new System.Drawing.Size(281, 23);
            this.txtTrailer.TabIndex = 7;
            this.txtTrailer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTrailer.UseSelectable = true;
            this.txtTrailer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTrailer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTrailer.TextChanged += new System.EventHandler(this.TxtTrailer_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(369, 198);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Soundtrack:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtSoundtrack
            // 
            // 
            // 
            // 
            this.txtSoundtrack.CustomButton.Image = null;
            this.txtSoundtrack.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtSoundtrack.CustomButton.Name = "";
            this.txtSoundtrack.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSoundtrack.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSoundtrack.CustomButton.TabIndex = 1;
            this.txtSoundtrack.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSoundtrack.CustomButton.UseSelectable = true;
            this.txtSoundtrack.CustomButton.Visible = false;
            this.txtSoundtrack.Lines = new string[0];
            this.txtSoundtrack.Location = new System.Drawing.Point(369, 223);
            this.txtSoundtrack.MaxLength = 32767;
            this.txtSoundtrack.Name = "txtSoundtrack";
            this.txtSoundtrack.PasswordChar = '\0';
            this.txtSoundtrack.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSoundtrack.SelectedText = "";
            this.txtSoundtrack.SelectionLength = 0;
            this.txtSoundtrack.SelectionStart = 0;
            this.txtSoundtrack.ShortcutsEnabled = true;
            this.txtSoundtrack.Size = new System.Drawing.Size(200, 23);
            this.txtSoundtrack.TabIndex = 9;
            this.txtSoundtrack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSoundtrack.UseSelectable = true;
            this.txtSoundtrack.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSoundtrack.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(575, 223);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(619, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(538, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // frmAddMediaContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 340);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtSoundtrack);
            this.Controls.Add(this.lblTrailer);
            this.Controls.Add(this.txtTrailer);
            this.Controls.Add(this.lblPlotKeywords);
            this.Controls.Add(this.txtPlotKeywords);
            this.Controls.Add(this.gridResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.verticalDivider);
            this.MaximizeBox = false;
            this.Name = "frmAddMediaContent";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Add Media Content";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FrmAddMediaContent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.verticalDivider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox verticalDivider;
        private MetroFramework.Controls.MetroTextBox txtTitle;
        private MetroFramework.Controls.MetroButton btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        public MetroFramework.Controls.MetroGrid gridResults;
        private MetroFramework.Controls.MetroTextBox txtPlotKeywords;
        private MetroFramework.Controls.MetroLabel lblPlotKeywords;
        private MetroFramework.Controls.MetroLabel lblTrailer;
        private MetroFramework.Controls.MetroTextBox txtTrailer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSoundtrack;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}