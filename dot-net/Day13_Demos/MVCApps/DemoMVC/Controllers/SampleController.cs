using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class SampleController : Controller
    {
        PuneDBEntities db = new PuneDBEntities();
        public ActionResult GetData()
        {

            //return new ContentResult()
            //{
            //    Content = "hi",
            //    ContentType = "text/plain"
            //};

            //return new JavaScriptResult()
            //{
            //    Script = "alert('hi')"
            //};

            //return new JsonResult()
            //{
            //    Data = db.Emps.ToList(),
            //    JsonRequestBehavior = JsonRequestBehavior.AllowGet
            //};
        }
    }
}