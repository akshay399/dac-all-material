using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00DemoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: SQL, 2: Oracle");
            int choice = Convert.ToInt32(Console.ReadLine());

            DBFactory dBFactory = new DBFactory();

            IDatabase obj = new SQLServer();
            // dBFactory.GetMeMyDatabase(choice);

            obj.Insert();
        }
    }

    public class DBFactory
    {
        public IDatabase GetMeMyDatabase(int choice)
        {
            if (choice == 1)
            {
                return new SQLServer();
            }
            else
            {
                return new Oracle();
            }
        }
    }

    public interface IDatabase
    {
        void Insert();
        void Update();
        void Delete();
    }

    public class SQLServer : IDatabase
    {
        public void Nonsense()
        {
        }
        public void Insert()
        {
            Console.WriteLine("SQL Server Insert Called");
        }
        public void Update()
        {
            Console.WriteLine("SQL Server Update Called");
        }
        public void Delete()
        {
            Console.WriteLine("SQL Server Delete Called");
        }
    }

    public class Oracle : IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Oracle Server Insert Called");
        }
        public void Update()
        {
            Console.WriteLine("Oracle Server Update Called");
        }
        public void Delete()
        {
            Console.WriteLine("Oracle Server Delete Called");
        }
    }
}
