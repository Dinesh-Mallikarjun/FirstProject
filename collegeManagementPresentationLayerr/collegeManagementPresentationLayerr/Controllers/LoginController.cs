using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace collegeManagementPresentationLayerr.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Login(string UserId,string password)
        {
            if(UserId.Equals("Admin")&&password.Equals("Admin"))
            {
                return RedirectToAction("AdminLogin", "LoginAdmin");
            }
            else if (UserId.Equals("Student") && password.Equals("Student"))
            {
                return RedirectToAction("studentLogin", "StudentLogin");
            }
            else
            {
                return View();
            }
        }

    }
}