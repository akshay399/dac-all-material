using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace _10DemoFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Simple File Writing
            //string filePath =
            //     ConfigurationManager.AppSettings["logFilePath"];

            //FileStream fs = null;

            //if(File.Exists(filePath))
            // {
            //     fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            // }
            //else
            // {
            //     fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            // }

            // StreamWriter writer = new StreamWriter(fs);

            // writer.WriteLine("Hello Sunbeam");

            // writer.Close();
            // fs.Close();

            // Console.WriteLine("Done writing!");
            // Console.ReadLine();
            #endregion

            #region Simple File Reading
            //string filePath =
            //     ConfigurationManager.AppSettings["logFilePath"];

            //FileStream fs = null;

            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            //    StreamReader reader = new StreamReader(fs);

            //    string dataFromFile = reader.ReadToEnd();

            //    Console.WriteLine(dataFromFile);

            //    reader.Close();
            //    fs.Close();

            //    Console.WriteLine("Done Reading!");
            //}
            //else
            //{
            //    Console.WriteLine("File does not exist!");
            //}

            //Console.ReadLine();
            #endregion

            #region Simple Object Writing / Serialization

            //Emp emp = new Emp();

            //Console.WriteLine("Enter No");
            //emp.No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //emp.Name = Console.ReadLine();

            //Console.WriteLine("Enter Address");
            //emp.Address = Console.ReadLine();

            //string filePath =
            //     ConfigurationManager.AppSettings["logFilePath"];

            //FileStream fs = null;

            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            //}

            //BinaryFormatter specialWriter = new BinaryFormatter();

            //specialWriter.Serialize(fs, emp);

            //specialWriter = null;
            //fs.Close();

            //Console.WriteLine("Done writing!");
            //Console.ReadLine();
            #endregion

            #region Simple Object Reading / De-Serialization

            //string filePath =
            //     ConfigurationManager.AppSettings["logFilePath"];

            //FileStream fs = null;

            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //    BinaryFormatter specialReader = new BinaryFormatter();

            //    object obj =  specialReader.Deserialize(fs);
            //    if (obj is Emp)
            //    {
            //        Emp emp = (Emp)obj;
            //        Console.WriteLine("Details : {0}, {1}, {2}", emp.No, emp.Name,emp.Address);
            //    }

            //    specialReader = null;
            //    fs.Close();

            //    Console.WriteLine("Done Reading!");

            //}
            //else
            //{
            //    Console.WriteLine("File does not exist!");
            //}
            //Console.ReadLine();
            #endregion

            #region Simple Object XML Writing / XML Serialization

            //Emp emp = new Emp();

            //Console.WriteLine("Enter No");
            //emp.No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //emp.Name = Console.ReadLine();

            //Console.WriteLine("Enter Address");
            //emp.Address = Console.ReadLine();

            //string filePath =
            //     ConfigurationManager.AppSettings["xmllogFilePath"];

            //FileStream fs = null;

            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            //}

            //XmlSerializer specialWriter = new XmlSerializer(typeof(Emp));

            //specialWriter.Serialize(fs, emp);

            //specialWriter = null;
            //fs.Close();

            //Console.WriteLine("Done writing!");
            //Console.ReadLine();
            #endregion

            #region Simple Object Reading / De-Serialization

            //string filePath =
            //     ConfigurationManager.AppSettings["xmllogFilePath"];

            //FileStream fs = null;

            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //    XmlSerializer specialReader = new XmlSerializer(typeof(Emp));

            //    object obj = specialReader.Deserialize(fs);
            //    if (obj is Emp)
            //    {
            //        Emp emp = (Emp)obj;
            //        Console.WriteLine("Details : {0}, {1}, {2}", emp.No, emp.Name, emp.Address);
            //    }

            //    specialReader = null;
            //    fs.Close();

            //    Console.WriteLine("Done Reading!");

            //}
            //else
            //{
            //    Console.WriteLine("File does not exist!");
            //}
            //Console.ReadLine();
            #endregion

            
        }
    }

    [Serializable]
    public class Emp
    {
        private int _No;
        private string _Name;
        private string _Address;

       // [NonSerialized]
        private string _Password = "abc@123";
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int No
        {
            get { return _No; }
            set { _No = value; }
        }

    }

    public class Book
    {
        private int _ISBN;
        private string _Title;

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public int ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

    }
}
