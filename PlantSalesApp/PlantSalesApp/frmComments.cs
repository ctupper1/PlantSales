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
            // TODO: This line of code loads data into the 'plantsDBDataSet.Comments' table. You can move, or remove it, as needed.
            //this.commentsTableAdapter.Fill(this.plantsDBDataSet.Comments);
            this.txtComment.Enter += new EventHandler(txtComment_Enter);
            this.txtComment.Leave += new EventHandler(txtComment_Leave);
            txtComment_SetText();

            // Execute the parameterized query to retrieve comments for the specified plant ID
            string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=PlantsDB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CommentID, PlantID, Comment, UserID, CommentDate FROM dbo.Comments WHERE PlantID = @PlantID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PlantID", plantID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int commentID = (int)reader["CommentID"];
                        int retrievedPlantID = (int)reader["PlantID"];
                        string comment = reader["Comment"].ToString();
                        int userID = (int)reader["UserID"];
                        DateTime commentDate = (DateTime)reader["CommentDate"];

                        // Source for 57-58: https://stackoverflow.com/questions/20520966/additional-information-unable-to-cast-object-of-type-system-windows-forms-bind
                        // Source for 61-68: https://stackoverflow.com/questions/8708057/rows-cannot-be-programmatically-added-to-the-datagridviews-row-collection-when
                        var bindingSource = this.commentsBindingSource;
                        var dt = (DataTable)bindingSource.DataSource;

                        DataRow dataRow = dt.NewRow();

                        dataRow["ID"] = commentID;
                        dataRow["Comment"] = comment;
                        dataRow["Date"] = commentDate;

                        dt.Rows.Add(dataRow);
                        dt.AcceptChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
                finally
                {
                    connection.Close();
                }
            }
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
            if (Validator.IsPresent(txtComment))
            {
                Comment newComment = new Comment();
                
                newComment.PlantID = plantID;
                newComment.CommentMsg = txtComment.Text;
                newComment.UserID = Session.UserId;

                //Add newComment to the database
                CommentsDB.AddNewComment(newComment);
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtComment.Clear();
            txtComment_SetText();
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
