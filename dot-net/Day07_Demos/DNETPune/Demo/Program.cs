using System;
using Arithmatic;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
          
            #region Basic Code
            //Console.WriteLine("Hello");

            //int i = 10;
            //int j = 20;
            //int result = i + j;
            //Console.WriteLine(result);
            #endregion

            #region Basic For Loop
            //for (int k = 0; k < 10; k++)
            //{
            //    Console.WriteLine(k);
            //}
            #endregion

            #region Call Library
            //Console.WriteLine("Enter X value");
            //string xVal = Console.ReadLine();
            //int x = Convert.ToInt32(xVal);

            //Console.WriteLine("Enter Y value");
            //string yVal = Console.ReadLine();
            //int y = Convert.ToInt32(yVal);

            //Maths obj = new Maths();

            //int result = obj.Add(x, y);
            //Console.WriteLine(result);
            #endregion

            #region Using Normal Way of Property / getter/setter
            //Person person = new Person();
            //person.Set_No(10);
            //Console.WriteLine(person.Get_No());
            #endregion

            //Person person = new Person();
            //person.No = 19;
            // Console.WriteLine(person.No) ;

            //Person person = new Person(10,"Sachin", "Mumbai");
            //string details = person.GetDetails();

            //Employee employee = new Employee();
            //employee.No = 10;
            //employee.Name = "Sachin";
            //employee.Address = "Mumbai";
            //employee.DeptName = "IT";

            //string details = employee.GetDetails();

            //Console.WriteLine(details);
            //Console.ReadLine();

            M obj = new M();
            
        }
    }

    public class Person  
    {
        #region Routine Way of Writing Getter / Setter
        //private int _No;

        //public int Get_No()
        //{
        //    return _No;
        //}

        //public void Set_No(int value)
        //{
        //    _No = value;
        //}
        #endregion

        private int _No;
        private string _Name;
        private string _Address;

        public Person()
        {
            No = 0;
            Name = "SomeName";
            Address = "Pune";
        }

        public Person(int no, string name, string address)
        {
            No = no;
            Name = name;
            Address = address;
        }

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

        //public virtual string GetDetails()
        //{
        //    return No.ToString() + Name + Address;
        //}

        public string GetDetails()
        {
            return No.ToString() + Name + Address;
        }
    }

    public class Employee:Person
    {
        private string _DeptName;

        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }

        //public override string GetDetails()
        //{
        //    return No.ToString() + Name + Address + DeptName;
        //}

        //public new string GetDetails()
        //{
        //    return No.ToString() + Name + Address + DeptName;
        //}

    }

    public class Customer : Person
    {

    }

}
