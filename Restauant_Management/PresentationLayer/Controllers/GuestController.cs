using ExceptionLayer;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class GuestController : Controller
    {        
        public ActionResult Index()
        {
            return View();
        }
        ModelManager modelManager = new ModelManager();
        [HttpGet]
        public ActionResult ReserveTable()
        {
            
            ViewModel viewModel = new ViewModel();
            viewModel.reservationModels = modelManager.DisplayReservation();            
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult ReserveTable(GuestModel guestModel)
        {
            try
            {
                ModelManager modelmanager = new ModelManager();
                modelmanager.ReserveTable(guestModel);
                return Redirect("Success");
            }
            catch (Exception e)
            {
                TempData["status"] = e.Message;
                return RedirectToAction("ReserveTable");
            }
        }
        [HttpGet]
        public ActionResult Success()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UpdateBill()
        {   
            ViewModel viewModel = new ViewModel();
            viewModel.guestModels = modelManager.DisplayReservedTables();
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult UpdateBill(GuestModel guestModel)
        {
            try
            {
                ModelManager modelmanager = new ModelManager();
                modelmanager.UpdateBill(guestModel);
                return Redirect("BillSuccess");
            }
            catch(Exception e)
            {
                TempData["status"] = e.Message;
                return RedirectToAction("UpdateBill");
            }

        }
        public ActionResult BillSuccess()
        {
            return View();
        }
    }
}