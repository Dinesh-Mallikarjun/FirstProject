using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class HotelController : Controller
    {
        // GET: Hotel
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DisplayGuests()
        {
            ModelManager modelManager = new ModelManager();
            List<GuestModel> guestModels = modelManager.DisplayGuests();
            return View(guestModels);
        }

        public ActionResult DisplayPresentGuests()
        {
            ModelManager modelManager = new ModelManager();
            List<GuestModel> guestModels = modelManager.DisplayPresentGuests();
            return View(guestModels);
        }
        public ActionResult DisplayTop5BillGuests()
        {
            ModelManager modelManager = new ModelManager();
            List<GuestModel> guestModels = modelManager.DisplayTop5BillGuests();
            return View(guestModels);
        }
        public ActionResult Displayleast5BillGuests()
        {
            ModelManager modelManager = new ModelManager();
            List<GuestModel> guestModels = modelManager.Displayleast5BillGuests();
            return View(guestModels);
        }
        [HttpGet]
        public ActionResult PartialView()
        {
            ModelManager modelManager = new ModelManager();
            return View(modelManager.DispllayAll());
        }
        

    }
}