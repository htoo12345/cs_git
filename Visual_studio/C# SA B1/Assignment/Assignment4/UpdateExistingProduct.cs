using System;
using System.Data.SqlClient;

namespace Assignment4
{
    public class UpdateExistingProduct
    {
        public void UpdateProduct(ColumnsName columns)
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=ShopMgtDB;User Id=sa;Password=azono";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection != null)
                {
                    string query = $"update Product set Name = '{columns.Name}', Price = '{columns.Price}' , Category = '{columns.Category}' where Id = {columns.Id} ";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine($"Commands completed successfully. \nCompletion time: {DateTime.Now}\n");
                    }

                    sqlConnection.Close();
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occur " + error.Message);
            }
        } // end of UpdateProduct
    } // end of UpdateExistingProduct class
} // end of Assignment4

