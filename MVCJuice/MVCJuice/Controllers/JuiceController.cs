using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JuiceShopEntities;
using MVCJuice.Models;


namespace MVCJuice.Controllers
{
    public class JuiceController : Controller
    {
        // GET: Juice

        ModelManager mg = new ModelManager();
        JuiceMenuModel jm = new JuiceMenuModel();
        [HttpGet]
        public ActionResult InsertData()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertData(JuiceMenuModel jmodel)
        {
            mg.InsertData(jmodel);
            return RedirectToAction("showFlavour");
        }

        [HttpGet]
        public ActionResult showFlavour()
        {
            ModelManager juicerepo = new ModelManager();
            List<JuiceMenuModel> data = juicerepo.FlavourData();
            return View(data);
        }
        public ActionResult UpdateData()
        {
            return View();
        }
        public ActionResult UpdateData(JuiceMenuModel jmodel)
        {
            mg.UpdateData(jmodel);
            return RedirectToAction("showFlavour");
        }

        public ActionResult DeleteData()
        {
            return View();
        }

        public ActionResult DeleteData(JuiceMenuModel jmodel)
        {
            mg.DeleteData(jmodel);
            return RedirectToAction("showFlavour");
        }

        public ActionResult showFlavour1()
        {
            ModelManager juicerepo = new ModelManager();
            List<JuiceMenuModel> data1 = juicerepo.DeletedData();
            return View(data1);
        }

        //public ActionResult Order()
        //{
        //    return View();
        //}
    } }
        //[HttpPost]
        //public ActionResult InsertFlavour(int juiceId,string juiceFlavour,int Price)
        //{
        //    try
        //    {
        //        JuiceMenuModel newFlavour = new JuiceMenuModel();
        //        newFlavour.JuiceId = juiceId;
        //        newFlavour.Flavour = juiceFlavour;
        //        newFlavour.Price = Price;
        //        ModelManager juicerepo = new ModelManager();
        //        List<int> juiceData = juicerepo.ReturnJuiceId();
        //        if(!juiceData.Contains(newFlavour.JuiceId))
        //        {
        //            juicerepo.InsertData();
        //        }
        //        return RedirectToAction("showFlavour");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        //[HttpPost]
        //public ActionResult orderDetails(int juiceId,int juiceQuantity)
        //{
        //    try
        //    {
        //        JuiceOrder order = new JuiceOrder();
        //        order.JuiceId = juiceId;
        //        order.Quantity = juiceQuantity;
        //        ModelManager juicerepo = new ModelManager();
        //        int id = juicerepo.MaxOrder();
        //        order.OrderId = id + 1;
        //        List<JuiceMenuModel> data = juicerepo.FlavourData();
        //        foreach(JuiceMenuModel obj in data)
        //        {
        //            if(obj.JuiceId==order.JuiceId)
        //            {
        //                order.TotalPrice = order.Quantity * obj.Price;
        //                break;
        //            }
        //        }
        //        juicerepo.InsertNewOrder(order);
        //        return View(order);
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        //public ActionResult Edit()
        //{
        //    return View();
        //}
        //public ActionResult EditDetails(int orderId,int quantity)
        //{
        //    JuiceOrder order = new JuiceOrder();
        //    order.OrderId = orderId;
        //    order.Quantity = quantity;
        //    ModelManager juicerepo = new ModelManager();
        //    order = juicerepo.UpdateOrder(order);
        //    return View(order);
        //}
   