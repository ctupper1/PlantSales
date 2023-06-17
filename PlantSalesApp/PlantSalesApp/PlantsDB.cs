﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PlantSalesApp
{
    public static class PlantDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost\\SqlExpress;Initial Catalog=Payables;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
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
