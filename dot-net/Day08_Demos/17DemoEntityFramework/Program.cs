using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17DemoEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            punedbEntities dalObj = new punedbEntities();

            //foreach (Emp emp in dalObj.Emps.ToList())
            //{
            //    Console.WriteLine(emp.Name);
            //}

            //Emp emp = new Emp();
            //emp.No = 99;
            //emp.Name = "Sudhakar";
            //emp.Address = "Chennai";

            //dalObj.Emps.Add(emp);
            //dalObj.SaveChanges();

            //Emp empToBeChanged = dalObj.Emps.Find(99);
            //empToBeChanged.Address = "Hydrabad";
            //dalObj.SaveChanges();

            //Emp empToBeDeleted = dalObj.Emps.Find(99);
            //dalObj.Emps.Remove(empToBeDeleted);
            //dalObj.SaveChanges();
        }
    }

}
