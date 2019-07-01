using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTM.Models;
using BTM.WinUI.Content;
using BTM.WinUI.Management;
using BTM.WinUI.Official;
using Flurl.Http;
using MetroFramework.Forms;
namespace BTM.WinUI
{
    public partial class frmHome : MetroForm
    {
        APIService _mediaService = new APIService("Media");
        APIService _imageService = new APIService("Images");
        //APIService _newsService = new APIService("News");
        //APIService _infoService = new APIService("Info");

        //List<string> BoxOfficeList = null;
        //List<string> HighestGrossingList = null;

        public frmHome()
        {
            InitializeComponent();
        }

        private async void FrmHome_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager;

            var boxOffice = await _mediaService.Get<IEnumerable<Media>>(null);
            var grossingAllTime = await _mediaService.Get<IEnumerable<Media>>(null);

            boxOffice = boxOffice.OrderByDescending(x => x.Budget).Take(10);
            grossingAllTime = grossingAllTime.OrderByDescending(x => x.WorldwideGross).Take(10);

            lblBoxOfficeList.Text = "";
            lblBoxOfficeList.MaximumSize = new Size(230, 200);
            lblBoxOfficeList.AutoSize = true;

            lblHighestAllTime.Text = "";
            lblHighestAllTime.MaximumSize = new Size(230, 200);
            lblHighestAllTime.AutoSize = true;

            int counter = 1;
            foreach (var item in boxOffice)
            {
                lblBoxOfficeList.Text += $"{counter++}. {item.Title}\n";
            }
            counter = 1;
            foreach (var item in grossingAllTime)
            {
                lblHighestAllTime.Text += $"{counter++}. {item.Title}\n";
            }
            var topBox = await _imageService.GetById<Models.Image>(boxOffice.ElementAt(0).MediaID);
            var topGross = await _imageService.GetById<Models.Image>(grossingAllTime.ElementAt(0).MediaID);

            string path = await $"{Properties.Settings.Default.APIUrl}/info/covers".GetStringAsync();
            string fullImagePath = $@"{path}\{System.IO.Path.GetFileName(topBox.Location)}";
            picBoxOffice.Image = new Bitmap(System.Drawing.Image.FromFile(fullImagePath), picBoxOffice.Width, picBoxOffice.Height);

            fullImagePath = $@"{path}\{System.IO.Path.GetFileName(topGross.Location)}";
            picAllTime.Image = new Bitmap(System.Drawing.Image.FromFile(fullImagePath), picBoxOffice.Width, picBoxOffice.Height);
        }

        private void BtmLogout_Click(object sender, EventArgs e)
        {
            APIService.Username = "";
            APIService.Password = "";
            this.Close();
        }

        private void BtnMedia_Click(object sender, EventArgs e)
        {
            frmAddMedia addMedia = new frmAddMedia();
            addMedia.Show();
        }

        private void BtnNews_Click(object sender, EventArgs e)
        {
            frmAddNews addNews = new frmAddNews();
            addNews.Show();
        }

        private void BtnMediaContent_Click(object sender, EventArgs e)
        {
            frmAddMediaContent frmAddMediaContent = new frmAddMediaContent();
            frmAddMediaContent.Show();
        }

        private void BtnPeople_Click(object sender, EventArgs e)
        {
            frmAddPeople frmAddPeople = new frmAddPeople();
            frmAddPeople.Show();
        }

        private void BtnBugs_Click(object sender, EventArgs e)
        {
            frmBugs frmBugs = new frmBugs();
            frmBugs.Show();
        }

        private void BtnFeedback_Click(object sender, EventArgs e)
        {
            frmFeedback frmFeedback = new frmFeedback();
            frmFeedback.Show();
        }

        private void BtnSupport_Click(object sender, EventArgs e)
        {
            frmSupport frmSupport = new frmSupport();
            frmSupport.Show();
        }

        private void BtnAwards_Click(object sender, EventArgs e)
        {
            frmAwards frmAwards = new frmAwards();
            frmAwards.Show();
        }

        private void BtnAddAdmin_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister(true);
            frmRegister.Show();
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            frmModifyUsers frmModifyUsers = new frmModifyUsers();
            frmModifyUsers.Show();
        }
    }
}
