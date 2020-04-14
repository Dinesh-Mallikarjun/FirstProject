using JuiceMVC.Models;
using JuiceMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JuiceMVC.Controllers
{
    public class JuiceController : Controller
    {
        // GET: Employee/GetAllEmpDetails    
        public ActionResult GetAllJuiceDetails()
        {

            JuiceRepository JuiceRepo = new JuiceRepository();
            ModelState.Clear();
            return View(JuiceRepo.GetAllJuices());
        }
        // GET: Employee/AddEmployee    
        public ActionResult AddJuice()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddJuice(JuiceModel Jui)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    JuiceRepository JuiceRepo = new JuiceRepository();

                    if (JuiceRepo.AddJuice(Jui))
                    {
                        ViewBag.Message = "Juice details added successfully";
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult EditJuiceDetails(int JuiceId)
        {
            JuiceRepository JuiceRepo = new JuiceRepository();

            return View(JuiceRepo.GetAllJuices().Find(obj =>obj.JuiceId == JuiceId));

        }

        [HttpPost]

        public ActionResult EditJuiceDetails(int JuiceId, JuiceRepository obj)
        {
            try
            {
                JuiceModel JuiceRepo = new JuiceModel();

                JuiceRepo.UpdateJuice(obj);

                return RedirectToAction("GetAllJuiceDetails");
            }
            catch
            {
                return View();
            }
        }




        public ActionResult DeleteJuice(int JuiceId)
        {
            try
            {
                JuiceRepository JuiceRepo = new JuiceRepository();
                if (JuiceRepo.DeleteJuice(JuiceId))
                {
                    ViewBag.AlertMsg = "Juice details deleted successfully";

                }
                return RedirectToAction("GetAllJuiceDetails");

            }
            catch
            {
                return View();
            }
        }


    }

}