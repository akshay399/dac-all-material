using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using _14DemoLayeredApp.DAL;
using _14DemoLayeredApp.Model;

namespace _14DemoLayeredApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpDataAccess dalObject = new EmpDataAccess();
            //List<Emp> employees = dalObject.GetEmployees();
            //foreach (Emp emp in employees)
            //{
            //    Console.WriteLine(emp.Name);
            //}

            //Emp emp = new Emp();
            //Console.WriteLine("Enter No");
            //emp.No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //emp.Name = Console.ReadLine();

            //Console.WriteLine("Enter Address");
            //emp.Address = Console.ReadLine();
            //int rowsAffected =  dalObject.AddEmployee(emp);
            //Console.WriteLine(rowsAffected);
        }
    }
}
