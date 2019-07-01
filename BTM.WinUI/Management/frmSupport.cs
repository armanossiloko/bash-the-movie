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
    public partial class frmSupport : MetroForm
    {
        private Ticket ticket = null;
        private Ticket ChangedTicket= null;

        private IEnumerable<Ticket> Tickets = null;

        private int CurrentPage = 0;
        public frmSupport()
        {
            InitializeComponent();
        }

        private async void FrmBugs_Load(object sender, EventArgs e)
        {
            //Bugs = await _bugService.Get<IEnumerable<Bug>>(null);
            Tickets = await $"{Properties.Settings.Default.APIUrl}/Support"
                    .WithBasicAuth(APIService.Username, APIService.Password)
                    .GetJsonAsync<IEnumerable<Ticket>>();
            CurrentPage = 1;
            foreach (var item in Tickets.Take(100))
            {
                gridBugs.Rows.Add(item.Id, item.Title, item.Resolved);
            }

            if (Tickets.Count() < 100)
            {
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
            }
            btnSave.Enabled = false;
        }

        private void TxtTitle_TextChanged(object sender, EventArgs e)
        {
            ChangedTicket.Title = txtTitle.Text;
        }

        private void TxtDescription_TextChanged(object sender, EventArgs e)
        {
            ChangedTicket.Content = txtDescription.Text;
        }

        private void CheckAddressed_Click(object sender, EventArgs e)
        {
            ChangedTicket.Resolved = !ChangedTicket.Resolved;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                gridBugs.Rows.Clear();
                CurrentPage--;
                //foreach (var item in Bugs.Skip(100).Take(100))
                foreach (var item in Tickets.Skip((CurrentPage - 1) * 100).Take(100))
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
                foreach (var item in Tickets.Skip((CurrentPage - 1) * 100).Take(100))
                {
                    gridBugs.Rows.Add(item.Id, item.Title, item.Resolved);
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                if (gridBugs.Rows.Count != Tickets.Count())
                {
                    gridBugs.Rows.Clear();
                    foreach (var item in Tickets.Take(100))
                    {
                        gridBugs.Rows.Add(item.Id, item.Title, item.Resolved);
                    }
                }
            }
            else
            {
                gridBugs.Rows.Clear();
                var newBugs = Tickets.Where(b => b.Title.Contains(txtSearch.Text)).AsEnumerable();
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
                if (!Compare(ticket, ChangedTicket)) // If there is any difference
                {
                    try
                    { 
                        ticket.Title = ChangedTicket.Title;
                        ticket.Content = ChangedTicket.Content;
                        ticket.Resolved = ChangedTicket.Resolved;

                        Models.Requests.TicketEditModel model = new Models.Requests.TicketEditModel
                        {
                            Title = ChangedTicket.Title,
                            Content = ChangedTicket.Content,
                            Resolved = ChangedTicket.Resolved,
                            UserID = ticket.UserID
                        };

                        //await _bugService.Update<Bug>(Id, bug);
                        await $"{Properties.Settings.Default.APIUrl}/Support/{Id}"
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
                ticket = await $"{Properties.Settings.Default.APIUrl}/Support/{GetID()}"
                    .WithBasicAuth(APIService.Username, APIService.Password)
                    .GetJsonAsync<Ticket>();


                ChangedTicket = new Ticket
                {
                    Id = ticket.Id,
                    Title = ticket.Title,
                    Content = ticket.Content,
                    Resolved = ticket.Resolved,
                    DateAdded = ticket.DateAdded,
                    UserID = ticket.UserID
                };

                txtTitle.Text = ticket.Title;
                txtDescription.Text = ticket.Content;
                checkAddressed.Checked = ticket.Resolved;
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

                string ID = Convert.ToString(selectedRow.Cells["TicketID"].Value);
                return int.Parse(ID);
            }
            catch
            {
                return -1;
            }
           
        }

        private bool Compare(Ticket ticketOne, Ticket ticketTwo)
        {
            return ticketOne.Id == ticketTwo.Id && ticketOne.Title == ticketTwo.Title &&
                ticketOne.Content == ticketTwo.Content && ticketOne.Resolved == ticketTwo.Resolved;
        }
        #endregion
    }
}
