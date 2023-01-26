using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18DemoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            PuneDBEntities obj = new PuneDBEntities();

            //List<spSelectByCity_Result> resultOfSP =
            //        obj.spSelectByCity("Pune").ToList();

            //foreach (spSelectByCity_Result result in resultOfSP)
            //{
            //    Console.WriteLine(result.No.ToString() + result.Name);
            //}

            //List<Emp> allEmps = obj.Emps.ToList();

            //foreach (Emp emp in allEmps)
            //{
            //    Console.WriteLine(emp.Name);
            //    foreach (EmpDetail detail in emp.EmpDetails.ToList())
            //    {
            //        Console.WriteLine("-- " + detail.PhoneNo);
            //    }
            //}

            //Emp emp = new Emp();
            //emp.No = 88;
            //emp.Name = "Koustubh";
            //emp.Address = "Pune";

            //obj.Emps.Add(emp);
            //obj.SaveChanges();

            //Emp emp = obj.Emps.Find(2);
            //emp.Address = "Kolkata";
            //obj.SaveChanges();

            //Emp emp = obj.Emps.Find(1);
            //obj.Emps.Remove(emp);
            //obj.SaveChanges();

            Console.ReadLine();
        }
    }
}
