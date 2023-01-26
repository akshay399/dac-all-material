using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMYSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new MySqlConnection("Server=127.0.0.1:3306;User ID=root;Password=manager;Database=karaddb");

            connection.Open();

           var command = new MySqlCommand("SELECT * FROM emp", connection);
           var reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine(reader.GetString(0));


            Console.ReadLine();
        }
    }
}
