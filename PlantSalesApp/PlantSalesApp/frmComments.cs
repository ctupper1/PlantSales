using PlantSalesApp.PlantsDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PlantSalesData;

namespace PlantSalesApp
{
    public partial class frmComments : Form
    {
        public int plantID;
        public frmComments(int plantID)
        {
            this.plantID = plantID;
            InitializeComponent();
        }

        
        private void frmComments_Load(object sender, EventArgs e)
        {
            this.commentsTableAdapter.FillByPlantId(this.plantsDBDataSet.Comments, plantID);
            this.txtComment.Enter += new EventHandler(txtComment_Enter);
            this.txtComment.Leave += new EventHandler(txtComment_Leave);
            txtComment_SetText();
        }

        // Code for default text: https://stackoverflow.com/questions/14544135/how-to-gray-out-default-text-in-textbox
        protected void txtComment_SetText()
        {
            this.txtComment.Text = "Add a comment...";
            txtComment.ForeColor = Color.Gray;
        }

        private void txtComment_Enter(object sender, EventArgs e)
        {
            if (txtComment.ForeColor == Color.Black)
                return;
            txtComment.Text = "";
            txtComment.ForeColor = Color.Black;
        }
        private void txtComment_Leave(object sender, EventArgs e)
        {
            if (txtComment.Text.Trim() == "")
                txtComment_SetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.txtComment.Text != "" && this.txtComment.Text != "Add a comment...")
                {
                    Comment newComment = new Comment();
                
                    newComment.PlantID = plantID;
                    newComment.CommentMsg = txtComment.Text;
                    newComment.UserID = Session.UserId;

                    //Add newComment to the database
                    CommentsDB.AddNewComment(newComment);
                    this.Close();
            } else
            {
                MessageBox.Show("You must enter a comment.",
                    "Add Failed");
            } 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = commentsDataGridView.CurrentRow;

            // Get userID of user that created currently selected listing
            // The cell index is found in the datagrid view's tooltip menu
            int listingCreator = (int)selectedRow.Cells[0].Value;

            if (Session.IsAdmin == true || Session.UserId == listingCreator)
            {
                // adds simple dialog to accept or deny
                // https://stackoverflow.com/questions/3036829/how-do-i-create-a-message-box-with-yes-no-choices-and-a-dialogresult
                DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete this comment?",
                    "Delete Comment", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    commentsDataGridView.Rows.RemoveAt(selectedRow.Index);
                    this.commentsTableAdapter.Update(this.plantsDBDataSet.Comments);
                }
            }
            else
            {
                MessageBox.Show("You can only delete your own comments.",
                    "Delete Failed");
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void commentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.plantsDBDataSet);

        }
    }
    
}
