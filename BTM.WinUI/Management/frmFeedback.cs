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
    public partial class frmFeedback : MetroForm
    {
        private Feedback feedback = null;
        private Feedback ChangedFeedback = null;

        private IEnumerable<Feedback> Feedback = null;

        private int CurrentPage = 0;

        public frmFeedback()
        {
            InitializeComponent();
        }

        private async void FrmFeedback_Load(object sender, EventArgs e)
        {
            Feedback = await $"{Properties.Settings.Default.APIUrl}/Feedback"
                    .WithBasicAuth(APIService.Username, APIService.Password)
                    .GetJsonAsync<IEnumerable<Feedback>>();
            CurrentPage = 1;
            foreach (var item in Feedback.Take(100))
            {
                gridFeedback.Rows.Add(item.Id, item.Name, item.Addressed);
            }

            if (Feedback.Count() < 100)
            {
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
            }
            btnSave.Enabled = false;
        }

        private void TxtTitle_TextChanged(object sender, EventArgs e)
        {
            ChangedFeedback.Name = txtTitle.Text;
        }

        private void TxtDescription_TextChanged(object sender, EventArgs e)
        {
            ChangedFeedback.Content = txtDescription.Text;
        }

        private void CheckAddressed_CheckedChanged(object sender, EventArgs e)
        {
            ChangedFeedback.Addressed = !ChangedFeedback.Addressed;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                gridFeedback.Rows.Clear();
                CurrentPage--;
                //foreach (var item in Bugs.Skip(100).Take(100))
                foreach (var item in Feedback.Skip((CurrentPage - 1) * 100).Take(100))
                {
                    gridFeedback.Rows.Add(item.Id, item.Name, item.Addressed);
                }
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (gridFeedback.Rows.Count > 100)
            {
                gridFeedback.Rows.Clear();
                CurrentPage++;
                foreach (var item in Feedback.Skip((CurrentPage - 1) * 100).Take(100))
                {
                    gridFeedback.Rows.Add(item.Id, item.Name, item.Addressed);
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                if (gridFeedback.Rows.Count != Feedback.Count())
                {
                    gridFeedback.Rows.Clear();
                    foreach (var item in Feedback.Take(100))
                    {
                        gridFeedback.Rows.Add(item.Id, item.Name, item.Addressed);
                    }
                }
            }
            else
            {
                gridFeedback.Rows.Clear();
                var newFeedbackList = Feedback.Where(b => b.Name.Contains(txtSearch.Text)).AsEnumerable();
                foreach (var item in newFeedbackList)
                {
                    gridFeedback.Rows.Add(item.Id, item.Name, item.Addressed);
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
                if (!Compare(feedback, ChangedFeedback)) // If there is any difference
                {
                    try
                    {
                        feedback.Name = ChangedFeedback.Name;
                        feedback.Content = ChangedFeedback.Content;
                        feedback.Addressed = ChangedFeedback.Addressed;

                        Models.Requests.FeedbackEditModel model = new Models.Requests.FeedbackEditModel
                        {
                            Name = ChangedFeedback.Name,
                            Content = ChangedFeedback.Content,
                            Addressed = ChangedFeedback.Addressed,
                            UserID = ChangedFeedback.UserID
                        };

                        //await _bugService.Update<Bug>(Id, bug);
                        await $"{Properties.Settings.Default.APIUrl}/Feedback/{Id}"
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

        private async void GridFeedback_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = true;
            try
            {
                feedback = await $"{Properties.Settings.Default.APIUrl}/Feedback/{GetID()}"
                    .WithBasicAuth(APIService.Username, APIService.Password)
                    .GetJsonAsync<Feedback>();


                ChangedFeedback = new Feedback
                {
                    Id = feedback.Id,
                    Name = feedback.Name,
                    Content = feedback.Content,
                    Addressed = feedback.Addressed,
                    UserID = feedback.UserID
                };

                txtTitle.Text = feedback.Name;
                txtDescription.Text = feedback.Content;
                checkAddressed.Checked = feedback.Addressed;
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
                int selectedrowindex = gridFeedback.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = gridFeedback.Rows[selectedrowindex];

                string ID = Convert.ToString(selectedRow.Cells["FeedbackID"].Value);
                return int.Parse(ID);
            }
            catch
            {
                return -1;
            }
        }

        private bool Compare(Feedback ideaOne, Feedback ideaTwo)
        {
            return ideaOne.Id == ideaTwo.Id && ideaOne.Name == ideaTwo.Name &&
                ideaOne.Content == ideaTwo.Content && ideaOne.Addressed == ideaTwo.Addressed;
        }
        #endregion

        
    }
}
