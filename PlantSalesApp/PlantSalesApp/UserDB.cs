using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PlantSalesApp
{
    public static class UserDB
    {
        public static User CheckUserLogin(string username, string password)
        {
            User user = new User();
            SqlConnection connection = PlantsDB.GetConnection();
            string selectStatement =
                "SELECT Username, Password " +
                "FROM Users " +
                "WHERE Username = @Username AND Password = @Password";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@Username", username);
            selectCommand.Parameters.AddWithValue("@Password", password);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow); 
                if (reader.Read())
                {
                    user.Username = (string)reader["Username"].ToString();
                    user.Password = (string)reader["Password"].ToString();
                }
                else
                {
                    user = null;
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
            return user;
        }

        public static void RegisterUser(User user) 
        {
            SqlConnection connection = PlantsDB.GetConnection();
            string insertStatement =
                "INSERT INTO Users " +
                "(Username, Password) " +
                "VALUES (@Username, @Password)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@Username",
                user.Username);
            insertCommand.Parameters.AddWithValue("@Password",
                user.Password);
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
