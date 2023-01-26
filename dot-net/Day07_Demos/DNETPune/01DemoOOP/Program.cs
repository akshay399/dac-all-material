using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DemoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportFactory reportFactory = new ReportFactory();

            Console.WriteLine("1 : PDF, 2: DOCX , 3: PPTX");
            int choice = Convert.ToInt32(Console.ReadLine());

            Report report = reportFactory.GetReport(choice);

            report.CreateReport();

        }
    }

    public class ReportFactory
    {
        public Report GetReport(int choice)
        {
            if (choice  == 1)
            {
                return new PDF();
            }
            else if (choice == 2)
            {
                return new DOCX();
            }
            else
            {
                return new PPTX();
            }
        }
    }

    public abstract class Report
    {
        protected abstract void Create();
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();
        public virtual void CreateReport()
        {
            Create();
            Parse();
            Validate();
            Save();
        }
    }
    public abstract class SpecialReport: Report
    {
        protected abstract void ReValidate();
        public override void CreateReport()
        {
            Create();
            Parse();
            Validate();
            ReValidate();
            Save();
        }
    }
    public class PDF : Report
    {
        protected override void  Create()
        {
            Console.WriteLine("PDF Created");
        }
        protected override void Parse()
        {
            Console.WriteLine("PDF Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("PDF Validated");
        }
        protected override void Save()
        {
            Console.WriteLine("PDF Saved");
        }
    }
    public class DOCX : Report
    {
        protected override void Create()
        {
            Console.WriteLine("DOCX Created");
        }
        protected override void Parse()
        {
            Console.WriteLine("DOCX Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("DOCX Validated");
        }
        protected override void Save()
        {
            Console.WriteLine("DOCX Saved");
        }
    }

    public class PPTX : SpecialReport
    {
        protected override void Create()
        {
            Console.WriteLine("PPTX Created");
        }
        protected override void Parse()
        {
            Console.WriteLine("PPTX Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("PPTX Validated");
        }
        protected override void ReValidate()
        {
            Console.WriteLine("PPTX ReValidated");
        }
        protected override void Save()
        {
            Console.WriteLine("PPTX Saved");
        }
    }

    public class TXT : SpecialReport
    {
        protected override void Create()
        {
            Console.WriteLine("TXT Created");
        }
        protected override void Parse()
        {
            Console.WriteLine("TXT Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("TXT Validated");
        }
        protected override void ReValidate()
        {
            Console.WriteLine("TXT ReValidated");
        }
        protected override void Save()
        {
            Console.WriteLine("TXT Saved");
        }
    }
}
