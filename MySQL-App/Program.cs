using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace MySQL_App
{
    public class Program
    {
        public static string connectionString = "server=localhost;user=root;password=Cadhla24!;database=db1;";

        public static void Main(string[] args)

        {
            using(MySqlConnection connection  = new MySqlConnection(connectionString))
            {
                connection.Open();

                string commandText = "CREATE TABLE books (id INT PRIMARY KEY AUTO_INCREMENT, book_name VARCHAR(64), author_name VARCHAR(32), pages INT, available BOOL);";
                MySqlCommand command = new MySqlCommand(commandText, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Table has been created.");


                for(int i=0; i < 100; i++)
                {
                    int pages = new Random().Next(100, 400);
                    int available = new Random().Next(0, 2);
                    commandText = $"INSERT INTO books (book_name, author_name, pages, available) VALUES ('Book {i * 2}', 'Author Name', {pages}, {available});";
                    command = new MySqlCommand(commandText, connection);
                    command.ExecuteNonQuery();
                    Console.WriteLine($"Row {i +1} inserted");
                }
            }
        }
    }
}