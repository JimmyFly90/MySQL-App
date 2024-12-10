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

            string commandText = "DELETE FROM store WHERE category = 'vegetables'";
            MySqlCommand command = new MySqlCommand(commandText, connection);

            command.ExecuteNonQuery();

            Console.WriteLine("Products deleted.");
        }
    }
}
            
    
