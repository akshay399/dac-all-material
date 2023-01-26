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

            Button button1 = new Button();
            button1.Text = "Click Me";
            EventHandler pointer = new EventHandler(SomeThingToExecute);

            button1.Click += pointer;

            this.Controls.Add(button1);
        }

        public void SomeThingToExecute(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
