using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06DemoDelegate
{
    public delegate string MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            C obj9 = new C();

            MyDelegate pointer = new MyDelegate(obj9.M3);

            A obj1 = new A();
            obj1.M1(pointer);
        }
    }

    public class A
    {
        public void M1(MyDelegate pointerToSomeMethod)
        {
            string someOutput = pointerToSomeMethod();
            Console.WriteLine(someOutput);
        }
    }

    public class B
    {
        public string M2()
        {
            return "M2's Output from B Object";
        }
    }

    public class C
    {
        public string M3()
        {
            return "M3's Output from C Object";
        }
    }
}
