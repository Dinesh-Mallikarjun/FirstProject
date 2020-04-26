using ExceptionLayer;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class OperatorController : Controller
    {
        // GET: Operator
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddOperator()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Success()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddOperator(MobileOperatorModel mobileOperatorModel)
        {
            try
            {
                ModelManager modelManager = new ModelManager();
                modelManager.AddOperator(mobileOperatorModel);
                return Redirect("Success");
            }
            catch (InvalidData e)
            {
                TempData["status"] = e.Message;
                return RedirectToAction("AddOperator");
            }
            catch (RatingOverLoadedException e)
            {
                TempData["status1"] = e.Message;
                return RedirectToAction("AddOperator");
            }
        }
        [HttpGet]
        public ActionResult mobileOperators()
        {
            try
            {
                ModelManager modelManager = new ModelManager();
                List<MobileOperatorModel> mobileOperatorModels = new List<MobileOperatorModel>();
                mobileOperatorModels = modelManager.mobileOperators();
                return View(mobileOperatorModels);
            }
            catch (NoParametersException e)
            {
                TempData["status2"] = e.Message;
                return RedirectToAction("AddOperator");
            }
        }
        [HttpGet]
        public ActionResult displaymobileoperatorss()
        {
            ModelManager modelManager = new ModelManager();
            List<MobileOperatorModel> mobileOperatorModels = new List<MobileOperatorModel>();
            mobileOperatorModels = modelManager.displaymobileoperatorss();
            return View(mobileOperatorModels);
        }
    }
}