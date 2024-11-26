using System;
using MySql.Data.MySqlClient;

public class MySql_Practice_1
{
    public static string connectionString = "server=localhost;user=root;password=Cadhla24!;database=school;";

    public static void Main(string[] args)
    {
        PopulateDatabase();
    }


    public static void PopulateDatabase()
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Successfully Connected To The MySQL Server");

                // Delete table if already created previously, so remove if creating for first time in program
                new MySqlCommand("DROP TABLE teachers", connection).ExecuteNonQuery();

                string tableCmdText = "CREATE TABLE teachers (id INT AUTO_INCREMENT PRIMARY KEY, name VARCHAR(30), age INT, experience FLOAT);";
                new MySqlCommand(tableCmdText, connection).ExecuteNonQuery();
                Console.WriteLine("Create table 'teachers'.");
                
                new MySqlCommand("INSERT INTO teachers (name, age, experience) VALUES ('John Smith', 35, 5.5)", connection).ExecuteNonQuery();
                new MySqlCommand("INSERT INTO teachers (name, age, experience) VALUES ('Anna Johnson', 40, 8.2)", connection).ExecuteNonQuery();
                new MySqlCommand("INSERT INTO teachers (name, age, experience) VALUES ('Robert Davis', 32, 3.1)", connection).ExecuteNonQuery();    

                Console.WriteLine("Three rows have been added to the table.");
        
                var queryCmd = new MySqlCommand("SELECT * FROM teachers;", connection);
                
                using (MySqlDataReader reader = queryCmd.ExecuteReader())

                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string name = reader.GetString("name");
                    int age = reader.GetInt32("age");
                    float exp = reader.GetFloat("experience");

                Console.WriteLine($">> ID: {id}, NAME: {name}, AGE: {age}, EXPERIENCE: {exp}");
                }

            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}     