using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _09DemoCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Simple Int Array
            //int[] arr = new int[3];
            //arr[0] = 100;
            //arr[1] = 200;
            //arr[2] = 300;


            //int[] arr = new int[] { 10,20,30,40,50};

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Employee Objects with Data for Usage
            Emp e1 = new Emp();
            e1.No = 1;
            e1.Name = "mahesh";
            e1.Address = "pune";

            Emp e2 = new Emp();
            e2.No = 2;
            e2.Name = "nilesh";
            e2.Address = "mumbai";

            Emp e3 = new Emp();
            e3.No = 3;
            e3.Name = "suresh";
            e3.Address = "chennai";
            #endregion

            #region Emp Array
            //Emp[] allEmps = new Emp[3];
            //allEmps[0] = e1;
            //allEmps[1] = e2;
            //allEmps[2] = e3;

            //foreach (Emp emp in allEmps)
            //{
            //    Console.WriteLine(emp.Name);
            //}
            #endregion

            #region Boxing , UnBoxing
            //int i = 100;        //Stack
            //object obj = i;     //Heap ... Boxing
            //int j = Convert.ToInt32(obj); //Back to Stack..Unboxing
            #endregion

            #region Object Array
            //object[] arr = new object[3];

            //arr[0] = 199;
            //arr[1] = "abcd";
            //arr[2] = e1;

            //foreach (object obj in arr)
            //{
            //    if (obj is int)
            //    {
            //        int j = Convert.ToInt32(obj);
            //        Console.WriteLine(j);
            //    }
            //    else if (obj is string)
            //    {
            //        string data = Convert.ToString(obj);
            //        Console.WriteLine(data);
            //    }
            //    else if (obj is Emp)
            //    {
            //        //Emp emp = (Emp)obj;
            //        Emp emp = obj as Emp;
            //        Console.WriteLine("Welcome " + emp.Name) ;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Unknown type of data...");
            //    }
            //}
            #endregion

            #region ArrayList:Array of Object with unlimited size
            //ArrayList arr = new ArrayList();
            //arr.Add(99);
            //arr.Add("abcd");
            //arr.Add(e1);
            //arr.Add(e2);
            //arr.Add("xyz");

            //foreach (object obj in arr)
            //{
            //    if (obj is int)
            //    {
            //        int j = Convert.ToInt32(obj);
            //        Console.WriteLine(j);
            //    }
            //    else if (obj is string)
            //    {
            //        string data = Convert.ToString(obj);
            //        Console.WriteLine(data);
            //    }
            //    else if (obj is Emp)
            //    {
            //        //Emp emp = (Emp)obj;
            //        Emp emp = obj as Emp;
            //        Console.WriteLine("Welcome " + emp.Name);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Unknown type of data...");
            //    }
            //}
            #endregion

            #region List<T>
            //List<Emp> arr = new List<Emp>();
            //arr.Add(e1);
            //arr.Add(e2);
            //arr.Add(e3);

            //foreach (Emp emp in arr)
            //{
            //    Console.WriteLine("Welcome " + emp.Name);
            //}
            #endregion

            #region Stack<T>
            //Stack<Emp> arr = new Stack<Emp>();
            //arr.Push(e1);
            //arr.Push(e2);
            //arr.Push(e3);


            //foreach (Emp emp in arr)
            //{
            //    Console.WriteLine("Welcome " + emp.Name);
            //}
            #endregion

            #region Queue<T>
            //Queue<Emp> arr = new Queue<Emp>();
            //arr.Enqueue(e1);
            //arr.Enqueue(e2);
            //arr.Enqueue(e3);


            //foreach (Emp emp in arr)
            //{
            //    Console.WriteLine("Welcome " + emp.Name);
            //}
            #endregion

            #region Search from a ArrayList
            //ArrayList arr = new ArrayList();

            //while (true)
            //{
            //    Emp emp = new Emp();

            //    Console.WriteLine("Enter No");
            //    emp.No = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter Name");
            //    emp.Name = Console.ReadLine();

            //    Console.WriteLine("Enter Address");
            //    emp.Address = Console.ReadLine();

            //    arr.Add(emp);

            //    Console.WriteLine("Do you want to continue? y / n");

            //    string choice = Console.ReadLine();
            //    if (choice!="y")
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine("Enter No of the Emp to Search:");
            //int No = Convert.ToInt32(Console.ReadLine());

            //foreach (Emp emp in arr)
            //{
            //    if (emp.No == No)
            //    {
            //        Console.WriteLine("Welcome {0} from {1} with No = {2}", emp.Name, emp.Address, emp.No);
            //        break;
            //    }
            //}
            #endregion

            #region Simple Hashtable
            //Hashtable arr = new Hashtable();
            //arr.Add(1, "mahesh");
            //arr.Add(2, "Nilesh");
            //arr.Add(3, "abcd");

            //object value = arr[3];
            //Console.WriteLine(value);

            //foreach (object key in arr.Keys)
            //{
            //    object value = arr[key];
            //    Console.WriteLine(value);
            //}
            #endregion

            #region Search from a Hashtable
            //Hashtable arr = new Hashtable();

            //while (true)
            //{
            //    Emp emp = new Emp();

            //    Console.WriteLine("Enter No");
            //    emp.No = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter Name");
            //    emp.Name = Console.ReadLine();

            //    Console.WriteLine("Enter Address");
            //    emp.Address = Console.ReadLine();

            //    arr.Add(emp.No, emp);

            //    Console.WriteLine("Do you want to continue? y / n");

            //    string choice = Console.ReadLine();
            //    if (choice != "y")
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine("Enter No of the Emp to Search:");
            //int key = Convert.ToInt32(Console.ReadLine());

            //object searchedEmp = arr[key];

            //if (searchedEmp!=null)
            //{
            //    Emp empFound = (Emp)searchedEmp;
            //    Console.WriteLine(
            //     "Welcome {0} from {1} with No = {2}",
            //      empFound.Name, empFound.Address, empFound.No);
            //}
            //else
            //{
            //    Console.WriteLine("Record not found");
            //}

            #endregion

            #region Search from Dictionary

            //Dictionary<int, Emp> arr = new Dictionary<int, Emp>();

            //while (true)
            //{
            //    Emp emp = new Emp();

            //    Console.WriteLine("Enter No");
            //    emp.No = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter Name");
            //    emp.Name = Console.ReadLine();

            //    Console.WriteLine("Enter Address");
            //    emp.Address = Console.ReadLine();

            //    arr.Add(emp.No, emp);

            //    Console.WriteLine("Do you want to continue? y / n");

            //    string choice = Console.ReadLine();
            //    if (choice != "y")
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine("Enter No of the Emp to Search:");
            //int key = Convert.ToInt32(Console.ReadLine());

            //Emp empFound = arr[key];

            //if (empFound != null)
            //{
            //    Console.WriteLine(
            //     "Welcome {0} from {1} with No = {2}",
            //      empFound.Name, empFound.Address, empFound.No);
            //}
            //else
            //{
            //    Console.WriteLine("Record not found");
            //}

            #endregion

            Console.ReadLine();
        }
    }

    public class Emp
    {
        private int _No;
        private string _Name;
        private string _Address;

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
}
