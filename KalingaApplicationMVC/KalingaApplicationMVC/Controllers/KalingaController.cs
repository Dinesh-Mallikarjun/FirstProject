using KalingaApplicationMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KalingaApplicationMVC.Controllers
{
    public class KalingaController : Controller
    {
        // GET: Kalinga
        //public ActionResult Index()
        //{
        //    return View();
        //}
        ModelManager modM = new ModelManager();
        CampusMindModel mMinds= new CampusMindModel();

        [HttpGet]
        public ActionResult InsertData()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertMindData(CampusMindModel mModel)
        {
            modM.InsertData(mModel);
            return RedirectToAction("ShowDetails");
        }
        [HttpGet]
        public ActionResult ShowDetails()
        {
            ModelManager mindsrepo = new ModelManager();
            List<CampusMindModel> data = mindsrepo.MindsData();
            return View(data);
        }
    }
}