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

            string commandText = "SELECT id, name, category, price, stock_quantity FROM store WHERE stock_quantity < 100;";
            MySqlCommand command = new MySqlCommand(commandText, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string name = reader.GetString("name");
                    string category = reader.GetString("category");
                    int price = reader.GetInt32("price");
                    int quantity = reader.GetInt32("stock_quantity");

                    Console.WriteLine($"ID: {id}, Item Name: {name}, Category: {category}, Price: {price}, Quantity: {quantity}");
                }
            }
        }
            
    }
}