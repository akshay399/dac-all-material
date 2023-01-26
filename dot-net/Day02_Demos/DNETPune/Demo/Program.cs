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

            Console.WriteLine("Enter X value");
            string xVal = Console.ReadLine();
            int x = Convert.ToInt32(xVal);

            Console.WriteLine("Enter Y value");
            string yVal = Console.ReadLine();
            int y = Convert.ToInt32(yVal);

            Maths obj = new Maths();

            int result = obj.Add(x, y);
            Console.WriteLine(result);
            
            Console.ReadLine();
        }

      
    }

    public class Person  
    {

    }

    public class Employee:Person
    {

    }

    public class Customer : Person
    {

    }

}
