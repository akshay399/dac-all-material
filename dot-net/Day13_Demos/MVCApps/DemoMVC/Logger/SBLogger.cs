using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Configuration;
namespace DemoMVC.Logger
{
    public class SBLogger
    {
        private static SBLogger logger = new SBLogger();
        private SBLogger() { }

        public static SBLogger CurrentLogger
        {
            get
            {
                return logger;
            }
        }

        public void Log(string message)
        {
            string filePath =
                ConfigurationManager.AppSettings["logFilePath"].ToString();
            FileStream fs = null;
            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            }

            StreamWriter streamWriter = new StreamWriter(fs);
            streamWriter.WriteLine(message);
            streamWriter.Close();
            fs.Close();
            streamWriter = null;
            fs = null;

        }
    }
}