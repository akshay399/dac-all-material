using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {

        protected override void OnAuthentication(AuthenticationContext filterContext)
        {
           
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
          
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}