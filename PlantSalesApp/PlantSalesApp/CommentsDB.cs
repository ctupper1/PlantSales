using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PlantSalesApp
{
    public static class CommentsDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost\\SqlExpress;Initial Catalog=PlantsDB;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public static void AddNewComment(Comment comment)
        {
            
            SqlConnection connection = GetConnection();
            string insertStatement =
                "INSERT INTO Comments " +
                "(PlantID, Comment, UserID, CommentDate) " +
                "VALUES (@PlantID, @Comment, @UserID, @CommentDate)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@PlantID", comment.PlantId);
            insertCommand.Parameters.AddWithValue("@Comment", comment.CommentText);
            insertCommand.Parameters.AddWithValue("@UserID", comment.UserId);
            insertCommand.Parameters.AddWithValue("@CommentDate", comment.CommentDate);


            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        /*public static List<Plant> GetPlants()
        {
            List<Plant> invoiceList = new List<Plant>();
            SqlConnection connection = GetConnection();
            string selectStatement =
                "SELECT PlantID, Name, Description, Size, " +
                "       PotColor, Price, Quantity, " +
                "       UserID " +
                "FROM Plants " +
                "ORDER BY PlantDate";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@PlantID", vendorID);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Plant invoice = new Plant();
                    invoice.PlantID = (int)reader["PlantID"];
                    invoice.PlantID = (int)reader["PlantID"];
                    invoice.PlantNumber = reader["PlantNumber"].ToString();
                    invoice.PlantDate = (DateTime)reader["PlantDate"];
                    invoice.PlantTotal = (decimal)reader["PlantTotal"];
                    invoice.PaymentTotal = (decimal)reader["PaymentTotal"];
                    invoice.CreditTotal = (decimal)reader["CreditTotal"];
                    invoice.TermsID = (int)reader["TermsID"];
                    invoice.DueDate = (DateTime)reader["DueDate"];
                    if (reader["PaymentDate"] == DBNull.Value)
                        invoice.PaymentDate = null;
                    else
                        invoice.PaymentDate = (DateTime)reader["PaymentDate"];
                    invoiceList.Add(invoice);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return invoiceList;
        }*/
    }
}
