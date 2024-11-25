using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        using MySqlConnection connection = new("server=localhost;user=root;password=Cadhla24!;");
        try
        {
            connection.Open();
            Console.WriteLine("Successfully Connected To The MySQL Server");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

    }
}