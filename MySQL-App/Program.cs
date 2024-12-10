using System;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;

public class Program
{
    public static string connectionString = "server=localhost;user=root;password=Cadhla24!;database=db1;";

    static void Main(string[] args)
    {

        using(MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            string commandText = "UPDATE store SET stock_quantity = 200 WHERE stock_quantity < 100;";
            MySqlCommand command = new MySqlCommand(commandText, connection);

            command.ExecuteNonQuery();

            Console.WriteLine("Executed.");
        }
    }
}
            
    
