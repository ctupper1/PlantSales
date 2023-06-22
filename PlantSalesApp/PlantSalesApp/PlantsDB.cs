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
    public static class PlantsDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost\\SqlExpress;Initial Catalog=PlantsDB;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public static void AddNewItem(Plant plant)
        {
            SqlConnection connection = GetConnection();
            string insertStatement =
                "INSERT INTO Plants " +
                "(Name, Type, Size, Price, Colors, Description, Availability, DateAdded, CareDifficulty, CareDetails, UserId) " +
                "VALUES (@Name, @Type, @Size, @Price, @Colors, @Description, @Availability, @DateAdded, @CareDifficulty, @CareDetails, @UserId)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@Name", plant.Name);
            insertCommand.Parameters.AddWithValue("@Type", plant.Type);
            insertCommand.Parameters.AddWithValue("@Size", plant.Size);
            insertCommand.Parameters.AddWithValue("@Price", plant.Price);
            insertCommand.Parameters.AddWithValue("@Colors", plant.Colors);
            insertCommand.Parameters.AddWithValue("@Description", plant.Description);
            insertCommand.Parameters.AddWithValue("@Availability", plant.Availability);
            insertCommand.Parameters.AddWithValue("@DateAdded", DateTime.Now);
            insertCommand.Parameters.AddWithValue("@CareDifficulty", plant.CareDifficulty);
            insertCommand.Parameters.AddWithValue("@CareDetails", plant.CareDetails);
            insertCommand.Parameters.AddWithValue("@UserId", plant.UserID);

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
