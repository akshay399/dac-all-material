using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        PuneDBEntities modelObj = new PuneDBEntities();
        public ActionResult Index()
        {
            List<Emp> allEmps = modelObj.Emps.ToList();
            //return View(allEmps);
            return View("Index1",allEmps);
        }

        public ActionResult Edit(int id)
        {
            Emp emp = modelObj.Emps.Find(id);
            return View(emp);
        }
        
        [HttpPost]
        public ActionResult Edit(Emp updatedEmp)
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