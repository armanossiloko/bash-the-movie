namespace BTM.WinUI
{
    partial class frmHome
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
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.tabHome = new MetroFramework.Controls.MetroTabPage();
            this.lblHighestAllTime = new MetroFramework.Controls.MetroLabel();
            this.lblBoxOfficeList = new MetroFramework.Controls.MetroLabel();
            this.lblAllTime = new MetroFramework.Controls.MetroLabel();
            this.lblBoxOffice = new MetroFramework.Controls.MetroLabel();
            this.picAllTime = new System.Windows.Forms.PictureBox();
            this.picBoxOffice = new System.Windows.Forms.PictureBox();
            this.tabAdminDashboard = new MetroFramework.Controls.MetroTabPage();
            this.btnAddAdmin = new MetroFramework.Controls.MetroTile();
            this.btnPeople = new MetroFramework.Controls.MetroTile();
            this.btnAwards = new MetroFramework.Controls.MetroTile();
            this.lblHollywood = new MetroFramework.Controls.MetroLabel();
            this.btnSupport = new MetroFramework.Controls.MetroTile();
            this.btnFeedback = new MetroFramework.Controls.MetroTile();
            this.btnBugs = new MetroFramework.Controls.MetroTile();
            this.btnMediaContent = new MetroFramework.Controls.MetroTile();
            this.btnNews = new MetroFramework.Controls.MetroTile();
            this.btnMedia = new MetroFramework.Controls.MetroTile();
            this.lblCommunity = new MetroFramework.Controls.MetroLabel();
            this.lblAdd = new MetroFramework.Controls.MetroLabel();
            this.btmLogout = new MetroFramework.Controls.MetroButton();
            this.btnUsers = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.metroPanel.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAllTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOffice)).BeginInit();
            this.tabAdminDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel
            // 
            this.metroPanel.Controls.Add(this.tabs);
            this.metroPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(20, 60);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(960, 520);
            this.metroPanel.TabIndex = 3;
            this.metroPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabHome);
            this.tabs.Controls.Add(this.tabAdminDashboard);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 1;
            this.tabs.Size = new System.Drawing.Size(960, 520);
            this.tabs.TabIndex = 2;
            this.tabs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabs.UseSelectable = true;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.lblHighestAllTime);
            this.tabHome.Controls.Add(this.lblBoxOfficeList);
            this.tabHome.Controls.Add(this.lblAllTime);
            this.tabHome.Controls.Add(this.lblBoxOffice);
            this.tabHome.Controls.Add(this.picAllTime);
            this.tabHome.Controls.Add(this.picBoxOffice);
            this.tabHome.HorizontalScrollbarBarColor = true;
            this.tabHome.HorizontalScrollbarHighlightOnWheel = false;
            this.tabHome.HorizontalScrollbarSize = 10;
            this.tabHome.Location = new System.Drawing.Point(4, 38);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(952, 478);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabHome.VerticalScrollbarBarColor = true;
            this.tabHome.VerticalScrollbarHighlightOnWheel = false;
            this.tabHome.VerticalScrollbarSize = 10;
            // 
            // lblHighestAllTime
            // 
            this.lblHighestAllTime.AutoSize = true;
            this.lblHighestAllTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHighestAllTime.Location = new System.Drawing.Point(481, 58);
            this.lblHighestAllTime.Name = "lblHighestAllTime";
            this.lblHighestAllTime.Size = new System.Drawing.Size(196, 25);
            this.lblHighestAllTime.TabIndex = 7;
            this.lblHighestAllTime.Text = "$INSERT MOVIES HERE$";
            this.lblHighestAllTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblBoxOfficeList
            // 
            this.lblBoxOfficeList.AutoSize = true;
            this.lblBoxOfficeList.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBoxOfficeList.Location = new System.Drawing.Point(3, 58);
            this.lblBoxOfficeList.Name = "lblBoxOfficeList";
            this.lblBoxOfficeList.Size = new System.Drawing.Size(196, 25);
            this.lblBoxOfficeList.TabIndex = 6;
            this.lblBoxOfficeList.Text = "$INSERT MOVIES HERE$";
            this.lblBoxOfficeList.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblAllTime
            // 
            this.lblAllTime.AutoSize = true;
            this.lblAllTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAllTime.Location = new System.Drawing.Point(490, 11);
            this.lblAllTime.Name = "lblAllTime";
            this.lblAllTime.Size = new System.Drawing.Size(208, 25);
            this.lblAllTime.TabIndex = 5;
            this.lblAllTime.Text = "Highest grossing (all time)";
            this.lblAllTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblBoxOffice
            // 
            this.lblBoxOffice.AutoSize = true;
            this.lblBoxOffice.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBoxOffice.Location = new System.Drawing.Point(54, 11);
            this.lblBoxOffice.Name = "lblBoxOffice";
            this.lblBoxOffice.Size = new System.Drawing.Size(128, 25);
            this.lblBoxOffice.TabIndex = 4;
            this.lblBoxOffice.Text = "Highest Budget";
            this.lblBoxOffice.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // picAllTime
            // 
            this.picAllTime.BackColor = System.Drawing.Color.Transparent;
            this.picAllTime.Location = new System.Drawing.Point(715, 2);
            this.picAllTime.Name = "picAllTime";
            this.picAllTime.Size = new System.Drawing.Size(235, 345);
            this.picAllTime.TabIndex = 3;
            this.picAllTime.TabStop = false;
            // 
            // picBoxOffice
            // 
            this.picBoxOffice.BackColor = System.Drawing.Color.Transparent;
            this.picBoxOffice.Location = new System.Drawing.Point(240, 2);
            this.picBoxOffice.Name = "picBoxOffice";
            this.picBoxOffice.Size = new System.Drawing.Size(235, 345);
            this.picBoxOffice.TabIndex = 2;
            this.picBoxOffice.TabStop = false;
            // 
            // tabAdminDashboard
            // 
            this.tabAdminDashboard.Controls.Add(this.btnUsers);
            this.tabAdminDashboard.Controls.Add(this.btnAddAdmin);
            this.tabAdminDashboard.Controls.Add(this.btnPeople);
            this.tabAdminDashboard.Controls.Add(this.btnAwards);
            this.tabAdminDashboard.Controls.Add(this.lblHollywood);
            this.tabAdminDashboard.Controls.Add(this.btnSupport);
            this.tabAdminDashboard.Controls.Add(this.btnFeedback);
            this.tabAdminDashboard.Controls.Add(this.btnBugs);
            this.tabAdminDashboard.Controls.Add(this.btnMediaContent);
            this.tabAdminDashboard.Controls.Add(this.btnNews);
            this.tabAdminDashboard.Controls.Add(this.btnMedia);
            this.tabAdminDashboard.Controls.Add(this.lblCommunity);
            this.tabAdminDashboard.Controls.Add(this.lblAdd);
            this.tabAdminDashboard.HorizontalScrollbarBarColor = true;
            this.tabAdminDashboard.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAdminDashboard.HorizontalScrollbarSize = 10;
            this.tabAdminDashboard.Location = new System.Drawing.Point(4, 38);
            this.tabAdminDashboard.Name = "tabAdminDashboard";
            this.tabAdminDashboard.Size = new System.Drawing.Size(952, 478);
            this.tabAdminDashboard.TabIndex = 1;
            this.tabAdminDashboard.Text = "Admin";
            this.tabAdminDashboard.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabAdminDashboard.VerticalScrollbarBarColor = true;
            this.tabAdminDashboard.VerticalScrollbarHighlightOnWheel = false;
            this.tabAdminDashboard.VerticalScrollbarSize = 10;
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.ActiveControl = null;
            this.btnAddAdmin.Location = new System.Drawing.Point(741, 90);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(181, 36);
            this.btnAddAdmin.Style = MetroFramework.MetroColorStyle.Black;
            this.btnAddAdmin.TabIndex = 16;
            this.btnAddAdmin.Text = "Administrators";
            this.btnAddAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAdmin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddAdmin.UseSelectable = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.BtnAddAdmin_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.ActiveControl = null;
            this.btnPeople.Location = new System.Drawing.Point(24, 174);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(181, 36);
            this.btnPeople.Style = MetroFramework.MetroColorStyle.Black;
            this.btnPeople.TabIndex = 15;
            this.btnPeople.Text = "People";
            this.btnPeople.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPeople.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPeople.UseSelectable = true;
            this.btnPeople.Click += new System.EventHandler(this.BtnPeople_Click);
            // 
            // btnAwards
            // 
            this.btnAwards.ActiveControl = null;
            this.btnAwards.Location = new System.Drawing.Point(741, 48);
            this.btnAwards.Name = "btnAwards";
            this.btnAwards.Size = new System.Drawing.Size(181, 36);
            this.btnAwards.Style = MetroFramework.MetroColorStyle.Black;
            this.btnAwards.TabIndex = 14;
            this.btnAwards.Text = "Awards";
            this.btnAwards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAwards.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAwards.UseSelectable = true;
            this.btnAwards.Click += new System.EventHandler(this.BtnAwards_Click);
            // 
            // lblHollywood
            // 
            this.lblHollywood.AutoSize = true;
            this.lblHollywood.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHollywood.Location = new System.Drawing.Point(713, 14);
            this.lblHollywood.Name = "lblHollywood";
            this.lblHollywood.Size = new System.Drawing.Size(69, 25);
            this.lblHollywood.TabIndex = 13;
            this.lblHollywood.Text = "Official:";
            this.lblHollywood.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnSupport
            // 
            this.btnSupport.ActiveControl = null;
            this.btnSupport.Location = new System.Drawing.Point(380, 132);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(181, 36);
            this.btnSupport.Style = MetroFramework.MetroColorStyle.Black;
            this.btnSupport.TabIndex = 12;
            this.btnSupport.Text = "Support";
            this.btnSupport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSupport.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSupport.UseSelectable = true;
            this.btnSupport.Click += new System.EventHandler(this.BtnSupport_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.ActiveControl = null;
            this.btnFeedback.Location = new System.Drawing.Point(380, 90);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(181, 36);
            this.btnFeedback.Style = MetroFramework.MetroColorStyle.Black;
            this.btnFeedback.TabIndex = 11;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFeedback.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnFeedback.UseSelectable = true;
            this.btnFeedback.Click += new System.EventHandler(this.BtnFeedback_Click);
            // 
            // btnBugs
            // 
            this.btnBugs.ActiveControl = null;
            this.btnBugs.Location = new System.Drawing.Point(380, 48);
            this.btnBugs.Name = "btnBugs";
            this.btnBugs.Size = new System.Drawing.Size(181, 36);
            this.btnBugs.Style = MetroFramework.MetroColorStyle.Black;
            this.btnBugs.TabIndex = 10;
            this.btnBugs.Text = "Bugs";
            this.btnBugs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBugs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBugs.UseSelectable = true;
            this.btnBugs.Click += new System.EventHandler(this.BtnBugs_Click);
            // 
            // btnMediaContent
            // 
            this.btnMediaContent.ActiveControl = null;
            this.btnMediaContent.Location = new System.Drawing.Point(24, 132);
            this.btnMediaContent.Name = "btnMediaContent";
            this.btnMediaContent.Size = new System.Drawing.Size(181, 36);
            this.btnMediaContent.Style = MetroFramework.MetroColorStyle.Black;
            this.btnMediaContent.TabIndex = 8;
            this.btnMediaContent.Text = "Media Content";
            this.btnMediaContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMediaContent.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnMediaContent.UseSelectable = true;
            this.btnMediaContent.Click += new System.EventHandler(this.BtnMediaContent_Click);
            // 
            // btnNews
            // 
            this.btnNews.ActiveControl = null;
            this.btnNews.Location = new System.Drawing.Point(24, 90);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(181, 36);
            this.btnNews.Style = MetroFramework.MetroColorStyle.Black;
            this.btnNews.TabIndex = 7;
            this.btnNews.Text = "News";
            this.btnNews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNews.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnNews.UseSelectable = true;
            this.btnNews.Click += new System.EventHandler(this.BtnNews_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.ActiveControl = null;
            this.btnMedia.Location = new System.Drawing.Point(24, 48);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(181, 36);
            this.btnMedia.Style = MetroFramework.MetroColorStyle.Black;
            this.btnMedia.TabIndex = 6;
            this.btnMedia.Text = "Media";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMedia.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnMedia.UseSelectable = true;
            this.btnMedia.Click += new System.EventHandler(this.BtnMedia_Click);
            // 
            // lblCommunity
            // 
            this.lblCommunity.AutoSize = true;
            this.lblCommunity.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCommunity.Location = new System.Drawing.Point(358, 14);
            this.lblCommunity.Name = "lblCommunity";
            this.lblCommunity.Size = new System.Drawing.Size(104, 25);
            this.lblCommunity.TabIndex = 5;
            this.lblCommunity.Text = "Community:";
            this.lblCommunity.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAdd.Location = new System.Drawing.Point(3, 14);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(76, 25);
            this.lblAdd.TabIndex = 2;
            this.lblAdd.Text = "Content:";
            this.lblAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btmLogout
            // 
            this.btmLogout.Location = new System.Drawing.Point(900, 68);
            this.btmLogout.Name = "btmLogout";
            this.btmLogout.Size = new System.Drawing.Size(75, 23);
            this.btmLogout.TabIndex = 5;
            this.btmLogout.Text = "Logout";
            this.btmLogout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btmLogout.UseSelectable = true;
            this.btmLogout.Click += new System.EventHandler(this.BtmLogout_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.ActiveControl = null;
            this.btnUsers.Location = new System.Drawing.Point(380, 174);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(181, 36);
            this.btnUsers.Style = MetroFramework.MetroColorStyle.Black;
            this.btnUsers.TabIndex = 17;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUsers.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnUsers.UseSelectable = true;
            this.btnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btmLogout);
            this.Controls.Add(this.metroPanel);
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.Resizable = false;
            this.Text = "Dashboard";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.metroPanel.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAllTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOffice)).EndInit();
            this.tabAdminDashboard.ResumeLayout(false);
            this.tabAdminDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel metroPanel;
        private MetroFramework.Controls.MetroTabControl tabs;
        private MetroFramework.Controls.MetroTabPage tabHome;
        private MetroFramework.Controls.MetroTabPage tabAdminDashboard;
        private MetroFramework.Controls.MetroButton btmLogout;
        private MetroFramework.Controls.MetroLabel lblAdd;
        private MetroFramework.Controls.MetroLabel lblCommunity;
        private MetroFramework.Controls.MetroTile btnSupport;
        private MetroFramework.Controls.MetroTile btnFeedback;
        private MetroFramework.Controls.MetroTile btnBugs;
        private MetroFramework.Controls.MetroTile btnMediaContent;
        private MetroFramework.Controls.MetroTile btnNews;
        private MetroFramework.Controls.MetroTile btnMedia;
        private MetroFramework.Controls.MetroLabel lblHollywood;
        private MetroFramework.Controls.MetroTile btnAwards;
        private System.Windows.Forms.PictureBox picBoxOffice;
        private System.Windows.Forms.PictureBox picAllTime;
        private MetroFramework.Controls.MetroLabel lblAllTime;
        private MetroFramework.Controls.MetroLabel lblBoxOffice;
        private MetroFramework.Controls.MetroLabel lblBoxOfficeList;
        private MetroFramework.Controls.MetroLabel lblHighestAllTime;
        private MetroFramework.Controls.MetroTile btnPeople;
        private MetroFramework.Controls.MetroTile btnAddAdmin;
        private MetroFramework.Controls.MetroTile btnUsers;
    }
}