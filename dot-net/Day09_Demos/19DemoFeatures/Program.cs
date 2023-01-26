using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;
using System.Linq.Expressions;

namespace _19DemoFeatures
{
    //public delegate bool MyDelegate(int i);

    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();

            #region Partial Class Concept
            //Maths obj = new Maths();
            #endregion

            #region Nullable Type

            //int? i = null;
            //Nullable<int> i = null;

            //if (i.HasValue)
            //{
            //    Console.WriteLine("i holds a value "+ i.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("i holds NULL");
            //}
            #endregion

            #region Call Method

            //watch.Start();
            //bool result = Check(20);
            //watch.Stop();

            #endregion

            #region Call Method using Delegate

            //MyDelegate pointer = new MyDelegate(Check);
            //bool result = pointer(20);

            #endregion

            #region Call Method Using Anonymous Method Concept
            //MyDelegate pointer = delegate (int i)
            //                        {
            //                            return (i > 10);
            //                        };
            #endregion

            #region Call Method Using Lambda Expression Concept
            //MyDelegate pointer = (i) =>
            //                      {
            //                          return (i > 10);
            //                      };
            #endregion

            #region Call Lambda Expression using Func Delegate


            //Func<int, bool> pointer = (i) =>
            //                              {
            //                                  return (i > 10);
            //                              };
            #endregion

            #region Call Lambda Expression using Func Delegate

            //1: Create a Optimized Expression Tree. Store in a variable
            // Expression<Func<int, bool>> tree = (i) =>  (i > 10);

            //2: Compile the Tree in Binary - Hold it as function 
            // Func<int, bool> pointer = tree.Compile();

            //3: Execute the Tree by passing parameter: pointer(20);
            #endregion

            #region Call / Result of Above Methods
            //watch.Start();
            //bool result = pointer(20);
            //watch.Stop();

            //Console.WriteLine("Result is {0}", result);
            //Console.WriteLine("Time Taken = {0} Ticks", 
            //watch.ElapsedTicks);
            #endregion

            #region Iterator
            //Week week = new Week();

            //foreach (string day in week)
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Implicit Type
            //object obj = 100;
            //obj = new Customer();
            //int o = Convert.ToInt32(obj);

            //var v = 100;
            //v = "abc";

            //var v = new Customer();
            #endregion

            #region Object Initializer
            ////Customer customer = new Customer();
            ////customer.No = 1;
            ////customer.Name = "Mahesh";

            //Customer customer = new Customer() { No = 1, Name = "Mahesh" };
            #endregion

            #region Anonymous  Type Basic Concept
            //var v = new { No = 1, Name = "Duryodhan" };

            //Console.WriteLine(v.GetType());
            //Console.WriteLine("Welcome " + v.Name);
            #endregion

            #region Anonymous Type Basic Concept  - 2
            //var v1 = new { No = 1, Name = "Duryodhan" };
            //Console.WriteLine(v1.GetType());

            //var v2 = new { No = "abcd", Name = 1234};
            //Console.WriteLine(v2.GetType());
            #endregion

            #region Extension Methods
            //string str = "m@a.com";

            //MyString ms = new MyString();
            //bool isValid = ms.CheckForValidEmailAddress(str, 100);


            //bool isValid = MyString.CheckForValidEmailAddress(str, 100);

            //bool isValid = str.CheckForValidEmailAddress(100);

            //Console.WriteLine(isValid);

            //int[] arr = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            //var avg = arr.Average();

            //Console.WriteLine(avg);
            #endregion

            #region List<Emp> Sample Data
            List<Emp> emps = new List<Emp>()
            {
                new Emp{  No = 11, Name = "Mahesh", Address = "Pune"},
                new Emp{  No = 12, Name = "Nilesh", Address = "Mumbai"},
                new Emp{  No = 13, Name = "Suresh", Address = "Puri"},
                new Emp{  No = 14, Name = "Ramesh", Address = "Manglore"},
                new Emp{  No = 15, Name = "Hitesh", Address = "Pune"}
            };
            #endregion

            #region Normal For Each Based Filter
            //List<Emp> filteredResult = new List<Emp>();
            //foreach (Emp emp in emps)
            //{
            //    if (emp.Address.StartsWith("P"))
            //    {
            //        filteredResult.Add(emp);
            //    }
            //}
            #endregion

            #region Lazy Execution Of LINQ
            ////var filteredResult = (from emp in emps
            ////                      where emp.Address.StartsWith("P")
            ////                      select emp);

            //var filteredResult = (from emp in emps
            //                      where emp.Address.StartsWith("P")
            //                      select emp).ToList();

            //emps.Add(new Emp { No = 55, 
            //                   Name = "Shakal", 
            //                   Address = "Pune" });

            //foreach (Emp emp in filteredResult)
            //{
            //    Console.WriteLine("{0},{1},{2}", emp.No, emp.Name,emp.Address);
            //}
            #endregion

            #region Proof of Concept that Where , Select are methods
            //Func<Emp, bool> pointer = (emp) => 
            //                    {
            //                        return emp.Address.StartsWith("P");
            //                    };

            ////var filteredResult =
            //         //emps.Where(pointer);//Where(emps,pointer)



            //var filteredResult = emps.Where((emp) =>
            //                    {
            //                        return emp.Address.StartsWith("P");
            //                    });

            #endregion

            #region Iterate The FilteredResult
            //foreach (Emp emp in filteredResult)
            //{
            //    Console.WriteLine("{0},{1},{2}", emp.No, emp.Name, emp.Address);
            //}
            #endregion

            #region LINQ TO return List<Emp>
            //var filteredFResult = (from emp in emps
            //                       where emp.Address.StartsWith("P")
            //                       select emp);

            //foreach (var item in filteredFResult)
            //{
            //    Console.WriteLine(item.No + item.Name + item.Address);
            //}

            #endregion

            #region LINQ To return List<Name>
            //var filteredFResult = (from emp in emps
            //                       where emp.Address.StartsWith("P")
            //                       select emp.Name);

            //foreach (var name in filteredFResult)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region LINQ To return List<ResultHolder>
            //var filteredFResult = (from emp in emps
            //                       where emp.Address.StartsWith("P")
            //                       select new ResultHolder 
            //                       {
            //                           ENo = emp.No, 
            //                           EName = emp.Name 
            //                       });

            //foreach (var item in filteredFResult)
            //{
            //    Console.WriteLine(item.ENo + item.EName);
            //}
            #endregion

            #region LINQ To Return List<Anonymous Type Collection
            //var filteredFResult = (from emp in emps
            //                       where emp.Address.StartsWith("P")
            //                       select new 
            //                       {
            //                           ENo = emp.No,
            //                           EName = emp.Name
            //                       }).ToList();

            //foreach (var item in filteredFResult)
            //{
            //    Console.WriteLine(item.ENo + item.EName);
            //}
            #endregion

            #region Partial Method
            //Test test = new Test();
            //test.DoSomething();

            #endregion

            Console.ReadLine();
        }


        #region Method To Be Called Via - Delegate
        //public static bool Check(int i)
        //{
        //    return (i > 10);
        //}
        #endregion
    }

    public static class MyString
    {   
        public static bool CheckForValidEmailAddress<T>(this T word,int someMorePara)
        {
            // return word.Contains("@");
            return true;
        }
    }


    public class ResultHolder
    {
        public int ENo { get; set; }
        public string EName { get; set; }
    }

    public class Emp
    {
        public int No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class Maths<T,Q>
    {

    }
    public class Week: IEnumerable
    {//Week week = new Week();

        //foreach (string day in week)
        //{
        //    Console.WriteLine(day);
        //}
        private string[] days = new string[]
                                {
                                    "Mon", "Tue", "Wed","Thu","Fri"
                                };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
               yield return days[i];
            }
        }
    }

    #region Customer Class with Auto Property
    //public class Customer
    // {
    //     #region Auto Property
    //     public int No { get; set; }
    //     public string Name { get; set; }

    //     #endregion

    //     #region Routine Property 
    //     //private int _No;
    //     //private string _Name;

    //     //public string Name
    //     //{
    //     //    get { return _Name; }
    //     //    set { _Name = value; }
    //     //}

    //     //public int No
    //     //{
    //     //    get { return _No; }
    //     //    set { _No = value; }
    //     //}
    //     #endregion

    // }
    #endregion
}
