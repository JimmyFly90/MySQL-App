using System;
using MySql.Data.MySqlClient;

public class MySqlCreateDB
{
    // You can modify the connection string here
    public static string connectionString = "server=localhost;user=root;password=Cadhla24!;";

    public static void Main(string[] args)
    {
        CreateDatabase();
    }

    public static void CreateDatabase()
    {
        // Modify code below this line
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                Console.WriteLine("Successfully Connected To The MySQL Server");

                string commandText = "CREATE DATABASE IF NOT EXISTS students";
                var command = new MySqlCommand(commandText, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        // Modify code above this line
    }
}     