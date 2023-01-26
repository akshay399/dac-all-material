using DemoMVC.Filters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    [Authorize]
    [SBFilter]
    //[HandleError(ExceptionType = typeof(SqlException), View = "Error1")]
    //[HandleError(ExceptionType = typeof(ArithmeticException), View = "Error2")]
    //[HandleError(ExceptionType = typeof(ArgumentException), View = "Error3")]
    [HandleError(ExceptionType = typeof(Exception), View = "Error")]
    public class BaseController : Controller
    {
          
    }
}