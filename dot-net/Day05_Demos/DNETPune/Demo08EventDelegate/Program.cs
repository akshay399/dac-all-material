using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08EventDelegate
{
    class Program
    {
    public delegate void Mediator();
        static void Main(string[] args)
        {
            // Button button1 = new Button();
            Student student1 = new Student();
            // button1.Text = "Click Me"
            student1.Name = "Ashraf";
            //EventHandler pointer1 = new EventHandler(SomethingToExecute)
            Mediator pointer1 = new Mediator(OnAccept);
            Mediator pointer2 = new Mediator(OnReject);

           //button1.Click += pointer1;
            student1.Accepted += pointer1;
            student1.Rejected += pointer2;

            Console.WriteLine("Hello! ");
            student1.Propose(Console.ReadLine());//Like u r clicking on button
            Console.ReadLine();
        }
        public static void OnAccept() // public void SomethingToExecute(Object s, EventArgs e)
        {
            Console.WriteLine("Miracle! Miracle!");
           //MessageBox.Show("Test");
        }
        public static void OnReject()
        {
            Console.WriteLine("Seh lenge Thoda!");
        }
    }

//  public delegate void EventHandler(object s, EventArgs e);
    public class Student //public class Button
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }   //public string Text{get;set;}

       // public event EventHandler Click;
        public event Mediator Accepted;
        public event Mediator Rejected;

        public void Propose(string message)
        {
            if(message.Contains("sunbeam")) //its like checking whether user clicked on the button area
            {
                Rejected(); //This is like raising the event
               //Click(this, new EventArgs());
               //This is also like notifying CLR about the event happening
            }
            else
            {
                Accepted();
            }
        }
    }
}
