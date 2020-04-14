using BookApplicationPresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookApplicationPresentationLayer.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        ModelManager mg = new ModelManager();
        BookMenuModel jm = new BookMenuModel();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult InsertData()
         {
            return View();
        }

        [HttpPost]
        public ActionResult InsertData(BookMenuModel bmodel)
        {
            mg.InsertData(bmodel);
            return RedirectToAction("showBooks");
        }
        public ActionResult showBooks()
        {
            ModelManager bookrepo = new ModelManager();
            List<BookMenuModel> data = bookrepo.BookData();
            return View(data);
        }
        [HttpGet]
        public ActionResult DeleteData()
        {
            return View();
        }

        public ActionResult DeleteData(BookMenuModel bmodel)
        {
            mg.DeleteData(bmodel);
            return RedirectToAction("showBooks");
        }

        public ActionResult showFlavour1()
        {
            ModelManager bookrepo = new ModelManager();
            List<BookMenuModel> data = bookrepo.DeletedData();
            return View(data);
        }
    }
}