using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    //[HandleError(ExceptionType = typeof(SqlException), View = "Error456")]
    public class HomeController : BaseController
    {
        public ActionResult Index(int id)
        {
            int x = 10;
            int result = x / id;

            Customer c = new Customer();
            c.ID = 199;
            c.Name = "ABCD";

            Student s = new Student();
            s.SID = 676;
            s.Name = "Sachin";


            return View("index", c);

        }


        //public ActionResult Index(int id)
        //{
        //    try
        //    {
        //        int x = 10;
        //        int result = x / id;

        //        Customer c = new Customer();
        //        c.ID = 199;
        //        c.Name = "ABCD";

        //        Student s = new Student();
        //        s.SID = 676;
        //        s.Name = "Sachin";

        //        return View("index", c);
        //    }
        //    catch (SqlException ex)
        //    {
        //        return View("Error1", ex);
        //    }
        //    catch (ArithmeticException ex)
        //    {
        //        return View("Error2", ex);
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.SBLogger.CurrentLogger.Log(ex.Message);
        //        return View("Error", ex);
        //    }
        //}

        //public ActionResult AfterIndex(FormCollection entireForm)
        //public ActionResult AfterIndex(Customer updatedCustomer)

        public ActionResult AfterIndex([ModelBinder(typeof(MyModelBinder))]Customer updatedCustomer)
        {
            //entireForm["ID"], entireForm["Name"] 
            // will give us the values

            //Customer updatedCustomer = new Customer();
            //updatedCustomer.ID = Convert.ToInt32(entireForm["ID"]);
            //updatedCustomer.Name = entireForm["Name"];

            return null;
        }
    }


    public class MyModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            //controllerContext.RequestContext.HttpContext.
            //Request.Form represents FormCollection ... 

            //You can create obejct of any kind out of form
            // data like:

            //Customer updatedCustomer = new Customer();
            //updatedCustomer.ID = Convert.ToInt32(entireForm["ID"]);
            //updatedCustomer.Name = entireForm["Name"];

            throw new NotImplementedException();
        }
    }

    //public class Provider: IMarathi, IEnglish, iSPN, iSS, ISports
    //{

    //}
   
    
    #region Understanding View Engine
    //class MyViewFile : IView
    //{
    //    public void Render(ViewContext viewContext, TextWriter writer)
    //    {

    //        throw new NotImplementedException();
    //    }
    //}

    //class MyViewEngine : IViewEngine
    //{
    //    public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
    //    {
    //        //Logic to find a view related file with our own extension
    //        return null;
    //    }

    //    public void ReleaseView(ControllerContext controllerContext, IView view)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    #endregion
}