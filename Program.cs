using System;
using Oracle.ManagedDataAccess.Client;

class Program
{
    static void Main(string[] args)
    {
        // Connection string (update with your database details)
        string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=172.30.3.3)(PORT=9905))(CONNECT_DATA=(SERVICE_NAME=ORCL)));User Id=QR_SMSDATA;Password=super;";

        // Create a new connection
        using (var connection = new OracleConnection(connectionString))
        {
            try
            {
                // Open the connection
                connection.Open();
                Console.WriteLine("Connection successful!");
            }
            catch (OracleException ex)
            {
                // Handle database-specific exceptions
                Console.WriteLine($"OracleException: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
