//using Entities;
//using JuiceShopBusinessLayer;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace JuiceShop.Models
//{
//    public class OrderManager
//    {
//        public bool GetOrder(OrderModel orderModel)
//        {
//            Order order = new Order
//            {
//                JuiceId = orderModel.JuiceId,
//                Quantity = orderModel.Quantity,
//                TotalPrice = orderModel.TotalPrice
//            };
//            BusinessLayerClass businessLayer = new BusinessLayerClass();
//            bool res = businessLayer.PassOrderData(order);
//            return res;
//        }
//    }
//}