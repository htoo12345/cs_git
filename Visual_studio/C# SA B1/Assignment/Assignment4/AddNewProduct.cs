using System;
using System.Data.SqlClient;

namespace Assignment4
{
    public class AddNewProduct
    { 
        public void AddProduct(ColumnsName columns)
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=ShopMgtDB;User Id=sa;Password=azono";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection != null)
                {
                    string query = $"insert into Product values ({columns.Id},'{columns.Name}','{columns.Price}','{columns.Category}')";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine("Commands completed successfully. \nCompletion time: " + DateTime.Now);
                    }

                    sqlConnection.Close();
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occur " + error.Message);
            }
        }
    }
}
