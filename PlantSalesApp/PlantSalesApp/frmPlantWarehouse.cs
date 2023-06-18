using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;using System.Text;
using System.Windows.Forms;


namespace PlantSalesApp
{
    public partial class frmPlantWarehouse : Form
    {

        bool isUserLoggedIn = false;

        public frmPlantWarehouse()
        {
            InitializeComponent();
        }


        //Filter event handlers
        //TODO: filters should combine until cleared
        private void cboPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.plantsTableAdapter.FilterByPrice(this.plantsDBDataSet.Plants, Convert.ToDecimal(cboPrice.SelectedItem));
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.plantsTableAdapter.FilterByType(this.plantsDBDataSet.Plants, cboType.SelectedItem.ToString());
        }

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.plantsTableAdapter.FilterBySize(this.plantsDBDataSet.Plants, cboSize.SelectedItem.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPlantWarehouse_Load(object sender, EventArgs e)
        {
            // When form first loads, all listings are displayed in datagrid view control, add/delete/comment is disabled until logged in
            this.plantsTableAdapter.Fill(this.plantsDBDataSet.Plants);
            btnAddNew.Enabled = false;
            btnDelete.Enabled = false;
            btnComment.Enabled = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            handleRegisterForm(false);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            handleRegisterForm(true);
        }

        private void handleRegisterForm(bool newUser)
        {
            if (!isUserLoggedIn)
            {
                // https://stackoverflow.com/questions/22133358/how-to-open-new-form-pass-parameter-and-return-parameter-back
                frmRegisterUser registerUserForm = new frmRegisterUser(newUser);
                DialogResult result = registerUserForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    isUserLoggedIn = true;
                    btnLogin.Text = "Log Out";
                    btnRegister.Visible = false;

                    btnDelete.Enabled = true;
                    btnAddNew.Enabled = true;
                    btnComment.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(
                        "You are now logged out.",
                        "User Logged Out");
                isUserLoggedIn = false;
                btnLogin.Text = "Log In";
                btnRegister.Visible = true;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNew addNewPlantForm = new frmAddNew(Session.UserId);
            DialogResult result = addNewPlantForm.ShowDialog(); 
            
            // I think Update should work here as it does with delete but it doesn't

            // yeah, i was not able to figure it out either. It looks like it has to do with the
            // binding source for the data grid?
            
            if (result==DialogResult.OK)
            {
                // this.plantsTableAdapter.Update(this.plantsDBDataSet.Plants);
                this.plantsTableAdapter.Fill(this.plantsDBDataSet.Plants);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            int selectedRowIndex = selectedRow.Index;
            //int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            // Get userID of user that created currently selected listing
            // Find userId in first column of selected row
            int listingCreator = (int)selectedRow.Cells[1].Value;
            if (Session.IsAdmin == 0 && Session.UserId != listingCreator)
            {
                MessageBox.Show("You can only delete your own listings.",
                    "Delete Failed");
                return;
            }
            else
            {
                // adds simple dialog to accept or deny
                // https://stackoverflow.com/questions/3036829/how-do-i-create-a-message-box-with-yes-no-choices-and-a-dialogresult
                DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete this listing?",
                    "Delete Listing", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(selectedRowIndex);
                    this.plantsTableAdapter.Update(this.plantsDBDataSet.Plants);
                }
            }
        }
        private void btnComment_Click(object sender, EventArgs e)
        {
            // probably need to add comments table
            // fields might need to be:
            // userId
            // plantId
            // comment
            // dateTimeAdded
        }
    }
}
