using pro_kabbaddi_Presentaton_layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pro_kabbaddi_Presentaton_layer.Controllers
{
    public class MatchController : Controller
    {
        // GET: Match
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddMatches()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMatches(MatchModel matchModel)
        {
            modelmanager modelmanager = new modelmanager();
            
            modelmanager.AddMatches(matchModel);

            return View();
        }
    }
}