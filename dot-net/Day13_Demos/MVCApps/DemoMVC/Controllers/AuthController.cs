using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;
using System.Web.Security;

namespace DemoMVC.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AfterSignIn(SBUser userSigningIN,
                                                string ReturnUrl)
        {
            if(ValidateUserFromDB(userSigningIN))
            {
                FormsAuthentication.SetAuthCookie(userSigningIN.UserName, false);
                if(ReturnUrl!=null)
                {
                    return Redirect(ReturnUrl);
                }
                { 
                    return Redirect("/Demo/Index");
                }
            }
            else
            {
                ViewBag.Message = "User name / password is wrong!";
                return View("SignIn");
            }
           
        }

        public ActionResult Signout()
        {
            FormsAuthentication.SignOut();
            return Redirect("/Demo/Index");
        }
        private bool ValidateUserFromDB(SBUser userSigningIN)
        {
            //Sunbeam DAC students will write code for checking user 
            //name and password against DB
            return (userSigningIN.UserName.ToLower() == "mahesh" && userSigningIN.Password == "mahesh@123");
        }
    }
}