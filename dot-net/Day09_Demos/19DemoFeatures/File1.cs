using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19DemoFeatures
{
    //Author: Mahesh
    public partial class Test
    {
        partial void DoSomeCalculation();
        public void DoSomething()
        {
            //Logic
            DoSomeCalculation(); ///This is method to be written by Nitin
            //Logic
        }
    }


    //Imagine Below code is Auto written / generated
    public partial class Employee
    {
        partial void Validate(string propertyName, object propertyValue);
        private string _Name;
        private int _No;

        public int No
        {
            get { return _No; }
            set 
            {
                Validate("No", value);
                _No = value; 
            }
        }

        public string Name
        {
            get { return _Name; }
            set 
            {
                Validate("Name", value);
                _Name = value; 
            }
        }


    }

    //Imagin below is written by Developer
    public partial class Employee
    {
        partial void Validate(string propertyName, object value)
        {
            if (propertyName == "Name")
            {
                //u r logic for check here
            }
            else if (propertyName == "No")
            {
                //u r logic for check here
            }
        }
    }
}
