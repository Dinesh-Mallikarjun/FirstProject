using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace helloworld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
    
        public ActionResult GotoHome()
        {
            return View("GotoHome");
        }

    }
}