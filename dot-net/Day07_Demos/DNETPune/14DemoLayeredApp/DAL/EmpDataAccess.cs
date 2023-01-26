using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _14DemoLayeredApp.Model;
using System.Data.SqlClient;
using System.Configuration;
namespace _14DemoLayeredApp.DAL
{
  public class EmpDataAccess
    {
        public List<Emp> GetEmployees()
        {
            #region Select Query

            List<Emp> employees = new List<Emp>();

            string connectionDetails =
         ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();


            SqlConnection connection = new SqlConnection(connectionDetails);

            connection.Open();

            SqlCommand command = new SqlCommand("select * from Emp", connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Emp emp = new Emp();
                emp.No = Convert.ToInt32(reader[0]);
                emp.Name = reader["Name"].ToString();
                emp.Address =reader["Address"].ToString();
                employees.Add(emp);
            }

            reader.Close();
            connection.Close();
            #endregion

            return employees;
        }

        public int AddEmployee(Emp emp)
        {
            string connectionDetails =
         ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
            #region Insert Query

            SqlConnection connection = new SqlConnection(connectionDetails);

            connection.Open();

            string queryFormat = "insert into Emp values({0}, '{1}', '{2}')";
            string query = string.Format(queryFormat, emp.No, emp.Name, emp.Address);

            SqlCommand command = new SqlCommand(query, connection);

            int countOfRowsAffected = command.ExecuteNonQuery();

            connection.Close();
            #endregion

            return countOfRowsAffected;
        }

        public int UpdateEmployee(Emp emp)
        {
            string connectionDetails =
         ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
            #region Update Query

            SqlConnection connection = new SqlConnection(connectionDetails);

            connection.Open();

            string queryFormat = "update Emp set Name='{1}', Address='{2}' where No = {0}";
            string query = string.Format(queryFormat, emp.No, emp.Name, emp.Address);

            SqlCommand command = new SqlCommand(query, connection);

            int countOfRowsAffected = command.ExecuteNonQuery();

            connection.Close();
            #endregion

            return countOfRowsAffected;
        }

        public int RemoveEmployee(int No)
        {
            #region Delete Query
            string connectionDetails =
           ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();

            SqlConnection connection = new SqlConnection(connectionDetails);

            connection.Open();

            string queryFormat = "delete from Emp where No = {0}";
            string query = string.Format(queryFormat, No);

            SqlCommand command = new SqlCommand(query, connection);

            int countOfRowsAffected = command.ExecuteNonQuery();

            connection.Close();
            #endregion

            return countOfRowsAffected;
        }
    }
}
