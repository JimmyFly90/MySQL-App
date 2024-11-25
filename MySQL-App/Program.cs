using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        using MySqlConnection connection = new("server=localhost;user=root;password=Cadhla24!;database=school");
        try
        {
            connection.Open();
            Console.WriteLine("Successfully Connected To The MySQL Server");

           // 1. Created database with - string cmdText = "CREATE DATABASE school;";
           // 2. Used this object to execute an MySQLCommand - MySqlCommand cmd = new MySqlCommand(cmdText, connection);
           // 3. Executed command, and server sends back response that there is 1 database - Console.WriteLine(cmd.ExecuteNonQuery());

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

    }
}