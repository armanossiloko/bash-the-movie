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
using Flurl.Http;
using MetroFramework.Forms;

namespace BTM.WinUI.Management
{
    public partial class frmBugs : MetroForm
    {
        APIService _bugService = new APIService("Bugs");

        private Bug bug = null;
        private Bug ChangedBug = null;

        private IEnumerable<Bug> Bugs = null;

        private int CurrentPage = 0;
        public frmBugs()
        {
            InitializeComponent();
        }

        private async void FrmBugs_Load(object sender, EventArgs e)
        {
            //Bugs = await _bugService.Get<IEnumerable<Bug>>(null);
            Bugs = await $"{Properties.Settings.Default.APIUrl}/Bugs"
                    .WithBasicAuth(APIService.Username, APIService.Password)
                    .GetJsonAsync<IEnumerable<Bug>>();
            CurrentPage = 1;
            foreach (var item in Bugs.Take(100))
            {
                gridBugs.Rows.Add(item.Id, item.Title, item.Resolved);
            }

            if (Bugs.Count() < 100)
            {
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
            }
            btnSave.Enabled = false;
        }

        private void TxtTitle_TextChanged(object sender, EventArgs e)
        {
            ChangedBug.Title = txtTitle.Text;
        }

        private void TxtDescription_TextChanged(object sender, EventArgs e)
        {
            ChangedBug.Description = txtDescription.Text;
        }

        private void CheckAddressed_Click(object sender, EventArgs e)
        {
            ChangedBug.Resolved = !ChangedBug.Resolved;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                gridBugs.Rows.Clear();
                CurrentPage--;
                //foreach (var item in Bugs.Skip(100).Take(100))
                foreach (var item in Bugs.Skip((CurrentPage - 1) * 100).Take(100))
                {
                    gridBugs.Rows.Add(item.Id, item.Title, item.Resolved);
                }
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (gridBugs.Rows.Count > 100)
            {
                gridBugs.Rows.Clear();
                CurrentPage++;
                foreach (var item in Bugs.Skip((CurrentPage - 1) * 100).Take(100))
                {
                    gridBugs.Rows.Add(item.Id, item.Title, item.Resolved);
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                if (gridBugs.Rows.Count != Bugs.Count())
                {
                    gridBugs.Rows.Clear();
                    foreach (var item in Bugs.Take(100))
                    {
                        gridBugs.Rows.Add(item.Id, item.Title, item.Resolved);
                    }
                }
            }
            else
            {
                gridBugs.Rows.Clear();
                var newBugs = Bugs.Where(b => b.Title.Contains(txtSearch.Text)).AsEnumerable();
                foreach (var item in newBugs)
                {
                    gridBugs.Rows.Add(item.Id, item.Title, item.Resolved);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            int Id = GetID();
            if (Id != -1)
            {
                if (!Compare(bug, ChangedBug)) // If there is any difference
                {
                    try
                    {
                        bug.Title = ChangedBug.Title;
                        bug.Description = ChangedBug.Description;
                        bug.Resolved = ChangedBug.Resolved;

                        Models.Requests.BugEditModel model = new Models.Requests.BugEditModel
                        {
                            Title = ChangedBug.Title,
                            Description = ChangedBug.Description,
                            Resolved = ChangedBug.Resolved,
                            Url = bug.Url,
                            UserID = bug.UserID
                        };

                        //await _bugService.Update<Bug>(Id, bug);
                        await $"{Properties.Settings.Default.APIUrl}/Bugs/{Id}"
                                .WithBasicAuth(APIService.Username, APIService.Password)
                                .PutJsonAsync(model);

                        MessageBox.Show("The submission has been updated", "Updated",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private async void GridBugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = true;
            try
            {
                bug = await $"{Properties.Settings.Default.APIUrl}/bugs/{GetID()}"
                    .WithBasicAuth(APIService.Username, APIService.Password)
                    .GetJsonAsync<Bug>();


                ChangedBug = new Bug
                {
                    Id = bug.Id,
                    Title = bug.Title,
                    Description = bug.Description,
                    Resolved = bug.Resolved,
                    DateAdded = bug.DateAdded,
                    Url = bug.Url,
                    UserID = bug.UserID
                };

                txtTitle.Text = bug.Title;
                txtDescription.Text = bug.Description;
                checkAddressed.Checked = bug.Resolved;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Support Methods
        private int GetID()
        {
            try
            {
                int selectedrowindex = gridBugs.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = gridBugs.Rows[selectedrowindex];

                string ID = Convert.ToString(selectedRow.Cells["BugID"].Value);
                return int.Parse(ID);
            }
            catch
            {
                return -1;
            }
           
        }

        private bool Compare(Bug bugOne, Bug bugTwo)
        {
            return bugOne.Id == bugTwo.Id && bugOne.Title == bugTwo.Title && 
                bugOne.Description == bugTwo.Description && bugOne.Resolved == bugTwo.Resolved;
        }
        #endregion
    }
}
