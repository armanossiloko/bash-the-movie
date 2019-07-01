using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using MaterialSkin.Controls;

namespace BTM.WinUI
{
    public partial class frmLogin : MaterialForm
    {
        APIService _service = new APIService("Users");
        public frmLogin()
        {
            InitializeComponent();
        }
        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;
            try
            {
                // TODO: Disable member login / allow admin login only
                bool isAdmin = await $"{Properties.Settings.Default.APIUrl}/Roles?username={APIService.Username}&roleName=Admin".GetJsonAsync<bool>();
                if (!isAdmin)
                {
                    MessageBox.Show("Forbidden", "You must be an admin to login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    APIService.Username = APIService.Password = "";
                    return;
                }

                var model = await _service.Get<dynamic>(null);
                frmHome home = new frmHome();
                home.Show();
                this.Hide();
                home.FormClosing += FrmDashboard_Closing;
            }
            catch { }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Grey800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Yellow100, MaterialSkin.Accent.Blue200, MaterialSkin.TextShade.WHITE);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
            this.Hide();
            frmRegister.FormClosing += Frmregister_Closing;
        }

        private void Frmregister_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void FrmDashboard_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
