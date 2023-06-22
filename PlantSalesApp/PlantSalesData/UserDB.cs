using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PlantSalesData
{
    public static class UserDB
    {

        public static bool CheckIfUsernameExists(string username)
        {
            SqlConnection connection = PlantsDB.GetConnection();
            string selectStatement =
                "SELECT Username, Password " +
                "FROM Users " +
                "WHERE Username = @Username";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@Username", username);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    username = (string)reader["Username"].ToString();
                }
                else
                {
                    username = null;
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

            if (username != null) return true;
            else return false;
        }

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

        // Retrieves user id from login credentials. UserID is saved to session
        // store admin credentials here too in order to extend higher privileges to admin users
        // Admin should be able to remove any listing, users limited to listings that they created
        public static void GetUserId(User user)
        {
            SqlConnection connection = PlantsDB.GetConnection();
            string selectStatement =
                "SELECT UserId, IsAdmin FROM Users WHERE username = @Username AND password = @Password";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@Username", user.Username);
            selectCommand.Parameters.AddWithValue("@Password", user.Password);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    //Set userId and isAdmin to results of select statement
                    Session.UserId = (int)reader["UserId"];
                    Session.IsAdmin = (bool)reader["IsAdmin"];
                }
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

        public static void DeleteUser(int userId)
        {
            SqlConnection connection = PlantsDB.GetConnection();
            string deleteStatement =
                "Delete FROM Users WHERE UserId = @UserId";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@UserId", Session.UserId);

            try
            {
                connection.Open();
                deleteCommand.ExecuteNonQuery();
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
