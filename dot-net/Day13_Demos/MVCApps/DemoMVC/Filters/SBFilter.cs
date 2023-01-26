using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Logger;

namespace DemoMVC.Filters
{
    public class SBFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            SBLogger.CurrentLogger.Log(string.Format("OnActionExecuting: {0} - Logged at {1}", filterContext.ActionDescriptor.ActionName, DateTime.Now.ToString()));
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            SBLogger.CurrentLogger.Log(string.Format("OnActionExecuted: {0} - Logged at {1}", filterContext.ActionDescriptor.ActionName, DateTime.Now.ToString()));
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            SBLogger.CurrentLogger.Log(string.Format("OnResultExecuting: Logged at {0}",  
                    DateTime.Now.ToString()));
            
            if(filterContext.Result is ViewResult)
            { 
                (filterContext.Result as ViewResult).ViewBag.Message = "Welcome " 
                    + (filterContext.Controller as Controller).User.Identity.Name;

                if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                {
                    (filterContext.Result as ViewResult).MasterName = "Master2";
                }
                else
                {
                    (filterContext.Result as ViewResult).MasterName = "Master";
                }
            }
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            SBLogger.CurrentLogger.Log(string.Format("OnResultExecuted: Logged at {0}",
                    DateTime.Now.ToString()));
        }

       
    }
}