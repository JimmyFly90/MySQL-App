using System;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;

public class Program
{
    public static string connectionString = "server=localhost;user=root;password=Cadhla24!;database=db1;";

    public static object[,] groceryItemsData = new object[,]
    {
        { "Bananas", "Fruits", 0.99f, 150 },
        { "Apples", "Fruits", 1.49f, 100 },
        { "Carrots", "Vegetables", 0.79f, 200 },
        { "Potatoes", "Vegetables", 1.29f, 180 },
        { "Milk", "Dairy", 2.49f, 80 },
        { "Eggs", "Dairy", 1.99f, 120 },
        { "Bread", "Bakery", 1.99f, 90 },
        { "Chicken", "Meat", 4.99f, 50 },
        { "Rice", "Grains", 3.99f, 120 },
        { "Pasta", "Grains", 1.49f, 150 }
    };

    static void Main(string[] args)
    {

        using(MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            string cmdText = "CREATE TABLE store (id INT PRIMARY KEY AUTO_INCREMENT, name VARCHAR(100), category VARCHAR(100), price FLOAT, stock_quantity INT);";
            MySqlCommand cmd = new MySqlCommand(cmdText, connection);
            cmd.ExecuteNonQuery();

            for (int i = 0; i < 10; ++i)
            {
                string name = (string)groceryItemsData[i, 0];
                string category = (string)groceryItemsData[i, 1];
                float price = (float)groceryItemsData[i, 2];
                int stock_quantity = (int)groceryItemsData[i, 3];

                cmdText = $"INSERT INTO store (name, category, price, stock_quantity) VALUES ('{name},', '{category}', '{price}', '{stock_quantity}');";
                cmd = new MySqlCommand(cmdText, connection);
                cmd.ExecuteNonQuery();
            }
            
        }
    }
}