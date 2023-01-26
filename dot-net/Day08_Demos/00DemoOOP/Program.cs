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
            while (true)
            {
                Console.WriteLine("1: SQL, 2: Oracle");
                int choice = Convert.ToInt32(Console.ReadLine());

                DBFactory dBFactory = new DBFactory();

                Database obj = dBFactory.GetMeMyDatabase(choice);

                Console.WriteLine("Make a choice for Operation");
                Console.WriteLine("1: Insert, 2: Update, 3: Delete");

                int opChoice = Convert.ToInt32(Console.ReadLine());

                switch (opChoice)
                {
                    case 1:
                        obj.Insert();
                        break;
                    case 2:
                        obj.Update();
                        break;
                    case 3:
                        obj.Delete();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

                Console.WriteLine("Do you want to continue? y /n");
                string continueornot = Console.ReadLine();
                if (continueornot!="y")
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }

    public class DBFactory
    {
        public Database GetMeMyDatabase(int choice)
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

    public abstract class Database
    {
       protected abstract void DoInsert();
       protected abstract void DoUpdate();
       protected abstract void DoDelete();
       protected abstract string GetDBName();

        public void Insert()
        {
            DoInsert();
            Logger.CurrentLogger.Log("Insert done into " + GetDBName());
        }
        public void Update()
        {
            DoUpdate();
            Logger.CurrentLogger.Log("Update done into " + GetDBName());
        }
        public void Delete()
        {
            DoDelete();
            Logger.CurrentLogger.Log("Delete done from " + GetDBName());
        }
    }

    public class SQLServer :Database
    {
        protected override void DoInsert()
        {
            Console.WriteLine("SQL Server Insert Called");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("SQL Server Update Called");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("SQL Server Delete Called");
        }
        protected override string GetDBName()
        {
            return "SQL Server";
        }
    }

    public class Logger
    {
        private static Logger _logger = new Logger();
        private Logger()
        {
            Console.WriteLine("Logger Constructor Called..");
        }

        public static Logger CurrentLogger
        {
            get { return _logger; }
        }

        //public Logger GetLogger()
        //{
        //    return logger;
        //}
        public void Log(string message)
        {
            //Ideally this is log via file handling 
            Console.WriteLine("Logged at " + 
                                DateTime.Now.ToString() + 
                                " : " + message);
        }
    }

    public class Oracle : Database
    {

        protected override void DoInsert()
        {
            Console.WriteLine("Oracle Server Insert Called");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Oracle Server Update Called");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Oracle Server Delete Called");
        }
        protected override string GetDBName()
        {
            return "Oracle Server";
        }
    }
}
