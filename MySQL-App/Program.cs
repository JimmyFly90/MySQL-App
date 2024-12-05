using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "server=localhost;user=root;password=Cadhla24!;database=db1;";

        using(MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            string cmdText = "CREATE TABLE products (id INT, name VARCHAR(100), category VARCHAR(100), price FLOAT, stock_quantity INT);";
            MySqlCommand cmd = new MySqlCommand(cmdText, connection);
            cmd.ExecuteNonQuery();
        }
    }
}