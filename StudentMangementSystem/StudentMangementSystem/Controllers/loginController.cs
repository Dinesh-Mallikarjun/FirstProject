//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace StudentMangementSystem.Controllers
//{
//    public class loginController : Controller
//    {
//        // GET: login
//        public ActionResult Index()
//        {
//            return View();
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentMangementSystem.Controllers
{
    public class loginController : Controller
    {
        // GET: login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(string username, string password)
        {
            if (username.Equals("admin") && password.Equals("admin"))
            {
                return RedirectToAction("Index", "College");
            }
            else if (username.Equals("Student") && password.Equals("Student"))
            {
                return RedirectToAction("Index", "Student");
            }
            else
            {
                return View();
            }
        }

    }
}
