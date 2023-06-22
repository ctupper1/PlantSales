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
            insertCommand.Parameters.AddWithValue("@PlantID", comment.PlantID);
            insertCommand.Parameters.AddWithValue("@Comment", comment.CommentMsg);
            insertCommand.Parameters.AddWithValue("@UserID", comment.UserID);
            insertCommand.Parameters.AddWithValue("@CommentDate", DateTime.Now);

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
    }
}
