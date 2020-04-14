//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using Entities;
//using JuiceShopBusinessLayer;

//namespace JuiceShop.Models
//{
//    public class JuiceManager
//    {
//        public Juice GetJuice(JuiceModel juiceModel)
//        {
//            Juice juice = new Juice();
//            juice.JuiceFlavour = juiceModel.JuiceFlavour;
//            juice.JuicePrice = juiceModel.JuicePrice;
//            return juice;
//        }
//        public List<JuiceModel> FetchJuiceTable()
//        {
//            BusinessLayerClass businessLayerClass = new BusinessLayerClass();
//            List<Juice> juices = businessLayerClass.DisplayJuiceTable();
//            List<JuiceModel> juiceModels = new List<JuiceModel>();
//            for(int i=0;i<juices.Count;i++)
//            {
//                JuiceModel juiceModel = new JuiceModel();
//                juiceModel.JuiceId = juices[i].JuiceId;
//                juiceModel.JuiceFlavour = juices[i].JuiceFlavour;
//                juiceModel.JuicePrice = juices[i].JuicePrice;
//            }
//            return juiceModels;
//        }
//    }
//}