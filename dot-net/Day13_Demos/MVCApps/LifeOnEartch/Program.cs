using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeCycle;
namespace LifeOnEartch
{
    class Program
    {
        static void Main(string[] args)
        {
            Human akshay = new Human();
            akshay.LiveLife(new AkshayLife());
            

            Human saumya = new Human();
            saumya.LiveLife(new SaumyaLife());

            Console.ReadLine();
        }
    }

    public class AkshayLife : MyLife
    {
        public void DefineMyLife()
        {
            Console.WriteLine("Akshay's Life");
        }
    }

    public class SaumyaLife : MyLife
    {
        public void DefineMyLife()
        {
            Console.WriteLine("Saumya's Life");
        }
    }
}
