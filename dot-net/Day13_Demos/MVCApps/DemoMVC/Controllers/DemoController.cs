using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Filters;

namespace DemoMVC.Controllers
{
   
    public class DemoController : BaseController
    {
        PuneDBEntities modelObj = new PuneDBEntities();
       
        [AllowAnonymous]

        public ActionResult AboutUs()
        {
            return View();
        }

        [SBFilter]
        public ActionResult Index()
        {
            List<Emp> allEmps = modelObj.Emps.ToList();
            //return View(allEmps);
           
            //ViewBag.Message = "Welcome " + User.Identity.Name;

            return View("Index",allEmps);
        }

        public ActionResult Edit(int no, string name)
        {
            Emp emp = modelObj.Emps.Find(no);
            ViewData["company"] = "Sunbeam";
            //ViewBag.Message = "Welcome " + User.Identity.Name;
            return View(emp);
        }
        
        [HttpPost]
        //public ActionResult Edit(Person person)
       public ActionResult Edit(Emp updatedEmp)
        // public ActionResult Edit(FormCollection frm)
        {
            Emp empToBeEdited = modelObj.Emps.Find(updatedEmp.No);
            empToBeEdited.Name = updatedEmp.Name;
            empToBeEdited.Address = updatedEmp.Address;
            modelObj.SaveChanges();

            return Redirect("/Demo/Index");
        }

        //public ActionResult AfterEdit(Emp updatedEmp)
        //{
        //    Emp empToBeEdited = modelObj.Emps.Find(updatedEmp.No);
        //    empToBeEdited.Name = updatedEmp.Name;
        //    empToBeEdited.Address = updatedEmp.Address;
        //    modelObj.SaveChanges();

        //    return Redirect("/Demo/Index");
        //}
        public ActionResult Delete(int id)
        {
            Emp empToBeRemoved = modelObj.Emps.Find(id);
            modelObj.Emps.Remove(empToBeRemoved);
            modelObj.SaveChanges();
            return Redirect("/Demo/Index");
        }
        public ActionResult Create()
        {
            //ViewBag.Message = "Welcome " + User.Identity.Name;
            return View();
        }
        public ActionResult AfterCreate(Emp empToBeAdded)
        {
            modelObj.Emps.Add(empToBeAdded);
            modelObj.SaveChanges();

            return Redirect("/Demo/Index");
        }
    }
}