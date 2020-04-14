using pro_kabbaddi_Presentaton_layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pro_kabbaddi_Presentaton_layer.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DisplayTeams()
        {
            modelmanager modelmanager = new modelmanager();
            List<TeamModel> teamModels = new List<TeamModel>();
            teamModels = modelmanager.DisplayTeams();
            return View(teamModels);
        }
        [HttpGet]
        public ActionResult exportDataToTextFile()
        {
            return View();
        }
    }
}