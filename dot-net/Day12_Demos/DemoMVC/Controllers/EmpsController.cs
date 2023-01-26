using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class EmpsController : Controller
    {
        // GET: Emps
        public ActionResult Index()
        {
            return View();
        }

        // GET: Emps/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Emps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emps/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Emps/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Emps/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Emps/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emps/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
