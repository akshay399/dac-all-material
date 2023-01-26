using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeCycle
{
    public interface MyLife
    {
        void DefineMyLife();
    }
    public abstract class Entity
    {
        protected abstract void Birth();
        protected abstract void KuchBhi(MyLife myLife);
        protected abstract void Death();
        public void LiveLife(MyLife myLife)
        {
            Birth();
            KuchBhi(myLife);
            Death();
        }
    }
  
    public class Human : Entity
    {
        protected override void Birth()
        {
            Console.WriteLine("Born");
        }

        protected override void Death()
        {
            Console.WriteLine("Dead");
        }

        protected override void KuchBhi(MyLife myLife)
        {
            myLife.DefineMyLife();
        }
    }
}
