using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04DemoGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Calling Generic method Swap from Generic Class Maths
            //Maths<int> obj = new Maths<int>();

            //int p = 100;
            //int q = 200;
            ////string details = 
            ////    string.Format("Before Swap  p = {0}, q = {1}", p, q);
            ////Console.WriteLine(details);

            //Console.WriteLine("Before Swap  p = {0}, q = {1}", p, q);
            //obj.Swap(ref p, ref q);
            //Console.WriteLine("After Swap  p = {0}, q = {1}", p, q);


            //Maths<short> m = new Maths<short>();
            #endregion

            #region Calling Generic & NonGeneric Method from Normal Class
            //Maths obj = new Maths();
            //obj.SayHi();

            //int p = 100;
            //int q = 200;
            //Console.WriteLine("Before Swap  p = {0}, q = {1}", p, q);
            //obj.Swap<int>(ref p, ref q);
            //Console.WriteLine("After Swap  p = {0}, q = {1}", p, q);
            #endregion

            #region Calling Generic method Swap from Inherited Class object

            //SpecialMaths obj = new SpecialMaths();

            //int p = 100;
            //int q = 200;
            //Console.WriteLine("Before Swap  p = {0}, q = {1}", p, q);
            //obj.Swap(ref p, ref q);
            //Console.WriteLine("After Swap  p = {0}, q = {1}", p, q);

            #endregion

            #region Using Inherited Generic Class 
            //SpecialMaths<string, int, short, bool> obj =
            //    new SpecialMaths<string, int, short, bool>();

            //int p = 100;
            //int q = 200;

            //Console.WriteLine("Before Swap  p = {0}, q = {1}", p, q);
            //obj.Swap(ref p, ref q);
            //Console.WriteLine("After Swap  p = {0}, q = {1}", p, q);

            //string output = obj.SomeNonsenseMethod("abc", 10, 4, true);
            //Console.WriteLine(output);
            #endregion

            //SayHi("abc");
            Console.ReadLine();
        }

        /// <summary>
        /// Say Hi from Sunbeam
        /// </summary>
        /// <param name="name">Put your name and we will say hi!</param>
        public static void SayHi(string name)
        {
            Console.WriteLine("Hi " + name);
        }
    }

   
    #region Normal Class with generic and non generic method
    //public class Maths
    //{
    //    public void SayHi()
    //    {
    //        Console.WriteLine("Hi!");
    //    }
    //    public void Swap<T>(ref T x, ref T y)
    //    {
    //        T z = x;
    //        x = y;
    //        y = z;
    //    }

    //}
    #endregion

    #region Generic Class with Generic Method
    //public class Maths<T>
    //{

    //    public void Swap(ref T x, ref T y)
    //    {
    //        T z = x;
    //        x = y;
    //        y = z;
    //    }

    //}
    #endregion

    #region Inheriting Generic Class into Normal Class with hardcoded <T>
    //public class Maths<T>
    //{
    //    public void Swap(ref T x, ref T y)
    //    {
    //        T z = x;
    //        x = y;
    //        y = z;
    //    }
    //}

    //public class SpecialMaths: Maths<int>
    //{
    //}
    #endregion

    #region Inheriting Generic Class into Normal Class with hardcoded <T>
    //public class Maths<T>
    //{
    //    /// <summary>
    //    /// Swap method by Sunbeam
    //    /// </summary>
    //    /// <param name="x">x is first parameter for swap</param>
    //    /// <param name="y">y is second parameter for swap</param>
    //    public void Swap(ref T x, ref T y)
    //    {
    //        T z = x;
    //        x = y;
    //        y = z;
    //    }
    //}

    //public class SpecialMaths <P,Q,R,S>: Maths<Q>
    //{
    //    public P SomeNonsenseMethod(P p1, Q p2, R p3, S P4)
    //    {
    //        return p1;
    //    }
    //}
    #endregion
}
