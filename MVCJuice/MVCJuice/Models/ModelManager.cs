using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using JuiceShopBusinessLayer;
using JuiceShopEntities;

namespace MVCJuice.Models
{
    public class ModelManager
    {
         
        IJuiceShopBusiness _juiceShopBusiness = new JuiceShopBusinesClass();
        public void InsertData(JuiceMenuModel jmodel)
        {
            JuiceMenu j = new JuiceMenu();
            j.JuiceId = jmodel.JuiceId;
            j.Flavour = jmodel.Flavour;
            j.Price = jmodel.Price;
            _juiceShopBusiness.InsertJuiceData(j);
        }
        public List<JuiceMenuModel> FlavourData()
        {
            JuiceMenu j1 = new JuiceMenu();
            List<JuiceMenu> menus= _juiceShopBusiness.JuiceFlavour();
            List<JuiceMenuModel> modelmenu = new List<JuiceMenuModel>();
            foreach(JuiceMenu juice in menus)
            {
                JuiceMenuModel j = new JuiceMenuModel(); 
                j.Flavour = juice.Flavour;
                j.JuiceId = juice.JuiceId;
                j.Price = juice.Price;
                modelmenu.Add(j);
            }
            return modelmenu;
        }

        public void UpdateData(JuiceMenuModel jmodel)
        {
            JuiceMenu j = new JuiceMenu();
            j.JuiceId = jmodel.JuiceId;
            j.Flavour = jmodel.Flavour;
            j.Price = jmodel.Price;
            _juiceShopBusiness.InsertJuiceData(j);
        }

        public List<JuiceMenuModel> UpdatedData()
        {
            JuiceMenu j1 = new JuiceMenu();
            List<JuiceMenu> menus = _juiceShopBusiness.JuiceFlavour();
            List<JuiceMenuModel> modelmenu = new List<JuiceMenuModel>();
            foreach (JuiceMenu juice in menus)
            {
                JuiceMenuModel j = new JuiceMenuModel();
                j.Flavour = juice.Flavour;
                j.JuiceId = juice.JuiceId;
                j.Price = juice.Price;
                modelmenu.Add(j);
            }
            return modelmenu;
        }

        public void DeleteData(JuiceMenuModel jmodel)
        {
            JuiceMenu j = new JuiceMenu();
            j.JuiceId = jmodel.JuiceId;
            j.Flavour = jmodel.Flavour;
            j.Price = jmodel.Price;
            _juiceShopBusiness.InsertJuiceData(j);
        }

        public List<JuiceMenuModel> DeletedData()
        {
            JuiceMenu j1 = new JuiceMenu();
            List<JuiceMenu> menus = _juiceShopBusiness.JuiceFlavour();
            List<JuiceMenuModel> modelmenu = new List<JuiceMenuModel>();
            foreach (JuiceMenu juice in menus)
            {
                JuiceMenuModel j = new JuiceMenuModel();
                j.Flavour = juice.Flavour;
                j.JuiceId = juice.JuiceId;
                j.Price = juice.Price;
                modelmenu.Add(j);
            }
            return modelmenu;
        }

    }
}




    
