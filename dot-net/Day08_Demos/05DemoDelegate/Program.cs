using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DemoDelegate
{
    delegate bool MyDelegate(int x);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate pointer1 = new MyDelegate(Check);

            //bool result = Check(20);

            bool result = pointer1(20);

            Console.WriteLine("Result is " + result);
        }

        public static bool Check(int i)
        {
            return (i > 10);
        }
    }


}
