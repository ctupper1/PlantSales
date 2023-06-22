using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PlantSalesApp
{
    public partial class frmPlantWarehouse : Form
    {

        bool isUserLoggedIn = false;

        public frmPlantWarehouse()
        {
            InitializeComponent();
        }

        private void frmPlantWarehouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'plantsDBDataSet1.Plants' table. You can move, or remove it, as needed.
            this.plantsTableAdapter.Fill(this.plantsDBDataSet1.Plants);
            // When form first loads, all listings are displayed in datagrid view control, add/delete/comment is disabled until logged in
            this.plantsTableAdapter.Fill(this.plantsDBDataSet.Plants);          
            btnAddNew.Enabled = false;
            btnDelete.Enabled = false;
            btnComment.Enabled = false;

        }

        public void filterDataGrid()
        {
            decimal price;
            string type;
            string size;
            int careDifficultyStart = 1;
            int careDifficultyEnd = 10;

            if (cboPrice.SelectedIndex == -1) price = 10000;
            else price = Convert.ToDecimal(cboPrice.SelectedItem);
            if (cboType.SelectedIndex == -1) type = null;
            else type = cboType.SelectedItem.ToString();
            if (cboSize.SelectedIndex == -1) size = null;
            else size = cboSize.SelectedItem.ToString();
            if (cboDifficulty.SelectedIndex == -1)
            {
                careDifficultyStart = 1;
                careDifficultyEnd = 10;
            }
            else
            {
                if (cboDifficulty.SelectedItem.ToString() == "Low-Maintenance")
                {
                    careDifficultyStart = 1;
                    careDifficultyEnd = 3;
                }
                else if (cboDifficulty.SelectedItem.ToString() == "Moderate Care")
                {
                    careDifficultyStart = 4;
                    careDifficultyEnd = 7;
                }
                if (cboDifficulty.SelectedItem.ToString() == "Challenging")
                {
                    careDifficultyStart = 8;
                    careDifficultyEnd = 10;
                }
            }
            this.plantsTableAdapter.FillByFilters(this.plantsDBDataSet.Plants, price, type, 
                size, careDifficultyStart, careDifficultyEnd);
        }
        
        private void cboPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filterDataGrid();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filterDataGrid();
        }

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filterDataGrid();
        }

        private void cboDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filterDataGrid();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            this.ClearFilters();
        }

        private void ClearFilters()
        {
            cboType.SelectedIndex = -1;
            cboType.Text = "Type";
            cboSize.SelectedIndex = -1;
            cboSize.Text = "Size";
            cboPrice.SelectedIndex = -1;
            cboPrice.Text = "Max Price";
            cboDifficulty.SelectedIndex = -1;
            cboDifficulty.Text = "Difficulty";
            this.plantsTableAdapter.Fill(this.plantsDBDataSet.Plants);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            handleRegisterForm(false, false);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            handleRegisterForm(true, false);
        }

        private void enableFormControls(bool e)
        {

            btnDelete.Enabled = e;
            btnAddNew.Enabled = e;
            btnComment.Enabled = e;
            chkShowAll.Checked = false;
            chkShowAll.Enabled = e;
        }

        private void handleRegisterForm(bool newUser, bool userDeleted)
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
                    btnDeleteUser.Visible = true;
                    this.plantsTableAdapter.FillByUserId(this.plantsDBDataSet.Plants, Session.UserId);

                    enableFormControls(true);
                }
            }
            else
            {
                if (userDeleted)
                {
                    MessageBox.Show(
                        "Your user and all listings have been deleted. \r\n" +
                        "You are logged out now.",
                        "User Delete");
                } else
                {
                    MessageBox.Show(
                        "You are logged out now.",
                        "User Logged Out");
                    btnDeleteUser.Visible = false;
                }

                isUserLoggedIn = false;
                btnLogin.Text = "Log In";
                btnRegister.Visible = true;
                
                enableFormControls(false);
                this.plantsTableAdapter.Fill(this.plantsDBDataSet.Plants);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNew addNewPlantForm = new frmAddNew(Session.UserId);
            DialogResult result = addNewPlantForm.ShowDialog();

            this.plantsTableAdapter.Fill(this.plantsDBDataSet.Plants);
            this.ClearFilters();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;

            // Get userID of user that created currently selected listing
            // The cell index is found in the datagrid view's tooltip menu
            int listingCreator = (int)selectedRow.Cells[7].Value;

            if (Session.IsAdmin == true || Session.UserId == listingCreator)
            {
                // adds simple dialog to accept or deny
                // https://stackoverflow.com/questions/3036829/how-do-i-create-a-message-box-with-yes-no-choices-and-a-dialogresult
                DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete this listing?",
                    "Delete Listing", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(selectedRow.Index);
                    this.plantsTableAdapter.Update(this.plantsDBDataSet.Plants);
                }
            }
            else
            {
                MessageBox.Show("You can only delete your own listings.",
                    "Delete Failed");
                return;
            }
        }
        private void btnComment_Click(object sender, EventArgs e)
        {
            //If a row is selected, open the comments form passing in the Id of the selected plant          
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;

            int plantId = (int)selectedRow.Cells[0].Value;

            frmComments frmComments = new frmComments(plantId);
            frmComments.ShowDialog();
        }

        private void chkShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowAll.Checked)
            {
                filterDataGrid();
            }
            else
            {
                this.plantsTableAdapter.FillByUserId(this.plantsDBDataSet.Plants, Session.UserId);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

            DialogResult confirmDelete = MessageBox.Show("You are about to delete your account. This action cannot be undone.",
                               "Delete User", MessageBoxButtons.OKCancel);
            if (confirmDelete == DialogResult.OK) 
            { 
                UserDB.DeleteUser(Session.UserId);
                handleRegisterForm(false, true);
            }

        }
    }
}
