using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08DemoEventBasedLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate pointer = new MyDelegate(CodeToExecuteAfterInsert);

            //Mahesh
            SqlServer db = new SqlServer();
            db.AfterInsert += pointer;

            db.Insert();
            Console.ReadLine();
        }

        public static void CodeToExecuteAfterInsert()
        {
            Console.WriteLine("My Log related code .. may be file/db/email log");
        }
    }

    //Nilesh
    public delegate void MyDelegate();
    public class SqlServer
    {
        public event MyDelegate AfterInsert;
        public void Insert()
        {
            Console.WriteLine("Insert done in SQL Server");
            AfterInsert();
        }
    }
}
