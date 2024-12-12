using System;
using System.Data;
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

            string queryTxt = "SELECT * FROM store;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(queryTxt, connection);
            DataSet store_dataset = new DataSet();
            adapter.Fill(store_dataset);

            DataTable table = store_dataset.Tables[0];

            foreach(DataRow row in table.Rows)
            {
                int id = (int)row["id"];
                string name = (string)row["name"];
                float price = (float)row["price"];

                Console.WriteLine($"{id} : {name} : {price}");
            }
        }
    }
}
            
    
