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
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace BTM.WinUI.Content
{
    public partial class frmAddPeople : MetroForm
    {
        APIService _peopleService = new APIService("People");

        public frmAddPeople()
        {
            InitializeComponent();
            this.errorProvider.Icon = new System.Drawing.Icon(Global.ErrorIcon);
        }

        private void FrmAddPeople_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
			if (txtName.Text == "" || txtMiddleName.Text == "" || 
					txtLastName.Text == "" || txtDescription.Text == "")
			{
				MessageBox.Show("Please add all the necessary details!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
			}
			
            try
            {
                People people = new People
                {
                    FirstName = txtName.Text,
                    MiddleName = txtMiddleName.Text,
                    LastName = txtLastName.Text,
                    DateOfBirth = dateBirth.Value,
                    Description = txtDescription.Text
                };

                var model = await _peopleService.Insert<People>(people);

                MessageBox.Show("The person has been added to the database!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            CheckErrors((MetroTextBox)sender);
        }

        private void TxtMiddleName_Validating(object sender, CancelEventArgs e)
        {
            CheckErrors((MetroTextBox)sender);
        }

        private void TxtLastName_Validating(object sender, CancelEventArgs e)
        {
            CheckErrors((MetroTextBox)sender);
        }

        private void TxtDescription_Validating(object sender, CancelEventArgs e)
        {
            CheckErrors((MetroTextBox)sender);
        }

        #region Support Methods
        private void CheckErrors(Control control)
        {
            bool Enable = true;
            if (control.Text == "" && control != txtMiddleName)
            {
                errorProvider.SetError(control, "Required field");
                errorProvider.SetIconPadding(control, 5);
                btnAdd.Enabled = false;
                Enable = false;
            }
            else
            {
                errorProvider.SetError(control, null);
            }

            foreach (var item in this.Controls.OfType<MetroTextBox>())
            {
                if (item.Text == "" && item != txtMiddleName)
                {
                    Enable = false;
                }
            }

            if (Enable)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
        #endregion
    }
}
