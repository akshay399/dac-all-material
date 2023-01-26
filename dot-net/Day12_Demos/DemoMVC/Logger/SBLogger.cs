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

        }
    }
}