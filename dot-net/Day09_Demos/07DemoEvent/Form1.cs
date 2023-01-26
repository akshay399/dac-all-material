using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07DemoEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Button button1 = new Button();
            //button1.Text = "Click Me";
            //EventHandler pointer = new EventHandler(SomeThingToExecute);

            //button1.Click += pointer;

            //this.Controls.Add(button1);

            //this.button1.Click += new EventHandler(button1_Click);

            ////Anomnymous Method C# 2.0 yr 2005
            //this.button1.Click += delegate (object sender, EventArgs e)
            //                       {
            //                           MessageBox.Show("Test");
            //                       };

            ////Lambda Expression C# 3.0 yr 2008
            //this.button1.Click += (sender, e)=>
            //                        {
            //                            MessageBox.Show("Test");
            //                        };
        }




        //private void test_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Test");
        //}

        //public void SomeThingToExecute(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Test");
        //}
    }
}
