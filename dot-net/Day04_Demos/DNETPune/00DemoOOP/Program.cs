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

            IDatabase obj =  dBFactory.GetMeMyDatabase(choice);

            obj.Insert();


            Console.WriteLine("1: SQL, 2: Oracle");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            IDatabase obj1 = dBFactory.GetMeMyDatabase(choice1);

            obj1.Update();
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
        Logger logger = Logger.CurrentLogger;
       
        public void Insert()
        {
            Console.WriteLine("SQL Server Insert Called");
            logger.Log("SQL Insert");
        }
        public void Update()
        {
            Console.WriteLine("SQL Server Update Called");
            logger.Log("SQL Update");
        }
        public void Delete()
        {
            Console.WriteLine("SQL Server Delete Called");
            logger.Log("SQL Delete");
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

    public class Oracle : IDatabase
    {
        
        public void Insert()
        {
            Console.WriteLine("Oracle Server Insert Called");
            Logger.CurrentLogger.Log("Oracle Insert");
        }
        public void Update()
        {
            Console.WriteLine("Oracle Server Update Called");
            Logger.CurrentLogger.Log("Oracle Update");
        }
        public void Delete()
        {
            Console.WriteLine("Oracle Server Delete Called");
            Logger.CurrentLogger.Log("Oracle Delete");
        }
    }
}
