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
using BTM.Models.Requests;
using Flurl.Http;
using MetroFramework.Forms;

namespace BTM.WinUI.Management
{
    public partial class frmModifyUsers : MetroForm
    {
        private bool isAdmin = false;
        private IEnumerable<UserModificationModel> Users = null;

        private int CurrentPage = 0;
        public frmModifyUsers()
        {
            InitializeComponent();
        }

        private async void FrmModifyUsers_Load(object sender, EventArgs e)
        {
            Users = await $"{Properties.Settings.Default.APIUrl}/Roles/GetRoles"
                    .WithBasicAuth(APIService.Username, APIService.Password)
                    .GetJsonAsync<IEnumerable<UserModificationModel>>();

            CurrentPage = 1;
            foreach (var item in Users.Take(100))
            {
                gridUsers.Rows.Add(item.Id, item.Username, item.FirstName, item.LastName);
            }

            if (Users.Count() < 100)
            {
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
            }
            btnSave.Enabled = false;
            checkAdmin.Enabled = false;
            gridUsers.MultiSelect = false;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                gridUsers.Rows.Clear();
                CurrentPage--;
                //foreach (var item in Bugs.Skip(100).Take(100))
                foreach (var item in Users.Skip((CurrentPage - 1) * 100).Take(100))
                {
                    gridUsers.Rows.Add(item.Id, item.Username, item.FirstName, item.LastName);
                }
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (gridUsers.Rows.Count > 100)
            {
                gridUsers.Rows.Clear();
                CurrentPage++;
                foreach (var item in Users.Skip((CurrentPage - 1) * 100).Take(100))
                {
                    gridUsers.Rows.Add(item.Id, item.Username, item.FirstName, item.LastName);
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                if (gridUsers.Rows.Count != Users.Count())
                {
                    gridUsers.Rows.Clear();
                    foreach (var item in Users.Take(100))
                    {
                        gridUsers.Rows.Add(item.Id, item.Username, item.FirstName, item.LastName);
                    }
                }
            }
            else
            {
                gridUsers.Rows.Clear();
                var newUsers = Users.Where(b => b.Username.Contains(txtSearch.Text)).AsEnumerable();
                foreach (var item in newUsers)
                {
                    gridUsers.Rows.Add(item.Id, item.Username, item.FirstName, item.LastName);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void GridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checkAdmin.Enabled = true;
            btnSave.Enabled = true;
            try
            {

                try
                {
                    int id = (int)gridUsers.SelectedRows[0].Cells["UserID"].Value;
                    string username = (string)gridUsers.SelectedRows[0].Cells["Username"].Value;

                    isAdmin = await $"{Properties.Settings.Default.APIUrl}/Roles?username={username}&roleName=Admin"
                        .WithBasicAuth(APIService.Username, APIService.Password)
                        .GetJsonAsync<bool>();

                    if (isAdmin)
                    {
                        checkAdmin.Checked = true;
                    }
                    else
                    {
                        checkAdmin.Checked = false;
                    }

                }
                catch
                {
                    MessageBox.Show("There's been an error parsing your selection! Please try something else.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)gridUsers.SelectedRows[0].Cells["UserID"].Value;
                string username = (string)gridUsers.SelectedRows[0].Cells["Username"].Value;

                await $"{Properties.Settings.Default.APIUrl}/Roles/SetAdmin/{id}"
                    .WithBasicAuth(APIService.Username, APIService.Password)
                    .PutJsonAsync(isAdmin);
            }
            catch
            {
                MessageBox.Show("You have to select an user first!", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CheckAdmin_CheckedChanged(object sender, EventArgs e)
        {
            isAdmin = checkAdmin.Checked;
        }
    }
}
