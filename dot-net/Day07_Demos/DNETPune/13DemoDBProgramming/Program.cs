using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace _13DemoDBProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionDetails =
            ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();

            #region Select Query
            //SqlConnection connection = new SqlConnection(connectionDetails);

            //connection.Open();

            //SqlCommand command = new SqlCommand("select * from Emp", connection);

            //SqlDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    Console.WriteLine(  reader[0].ToString() + 
            //                        reader["Name"].ToString() + 
            //                        reader["Address"].ToString()  );

            //}

            //reader.Close();
            //connection.Close();
            #endregion

            #region Insert Query
            //SqlConnection connection = new SqlConnection(connectionDetails);

            //connection.Open();

            //Console.WriteLine("Enter No");
            //int No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //string Name = Console.ReadLine();

            //Console.WriteLine("Enter Address");
            //string Address = Console.ReadLine();

            //string queryFormat = "insert into Emp values({0}, '{1}', '{2}')";
            //string query = string.Format(queryFormat, No, Name, Address);

            //SqlCommand command = new SqlCommand(query, connection);

            //int countOfRowsAffected = command.ExecuteNonQuery();

            //Console.WriteLine("Rows Affected = {0}", countOfRowsAffected);

            //connection.Close();
            #endregion

            #region Update Query
            //SqlConnection connection = new SqlConnection(connectionDetails);

            //connection.Open();

            //Console.WriteLine("Enter No");
            //int No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //string Name = Console.ReadLine();

            //Console.WriteLine("Enter Address");
            //string Address = Console.ReadLine();

            //string queryFormat = "update Emp set Name='{1}', Address='{2}' where No = {0}";
            //string query = string.Format(queryFormat, No, Name, Address);

            //SqlCommand command = new SqlCommand(query, connection);

            //int countOfRowsAffected = command.ExecuteNonQuery();

            //Console.WriteLine("Rows Affected = {0}", countOfRowsAffected);

            //connection.Close();
            #endregion

            #region Delete Query
            //SqlConnection connection = new SqlConnection(connectionDetails);

            //connection.Open();

            //Console.WriteLine("Enter No");
            //int No = Convert.ToInt32(Console.ReadLine());

            //string queryFormat = "delete from Emp where No = {0}";
            //string query = string.Format(queryFormat, No);

            //SqlCommand command = new SqlCommand(query, connection);

            //int countOfRowsAffected = command.ExecuteNonQuery();

            //Console.WriteLine("Rows Affected = {0}", countOfRowsAffected);

            //connection.Close();
            #endregion
        }
    }
}
