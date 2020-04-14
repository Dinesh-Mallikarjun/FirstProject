using Entities;
using KalingaBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KalingaApplicationMVC.Models
{
    public class ModelManager
    {
        IKalingaBusinessClass _KalingaBusiness = new KalingaBusinessClass();
        public void InsertData(CampusMindModel cmodel)
        {
            CampusMind c = new CampusMind();
           
            c.Name1 = cmodel.Name1;
            c.Doj1 = cmodel.Doj1;                        
            c.ContactNumber1 = cmodel.ContactNumber1;
            c.Address1 = cmodel.Address1;

            _KalingaBusiness.InsertMindsData(c);
        }
        public List<CampusMindModel> MindsData()
        {
            CampusMind j1 = new CampusMind();
            List<CampusMind> minds = _KalingaBusiness.CampusMind();
            List<CampusMindModel> modelmenu = new List<CampusMindModel>();
            foreach (CampusMind mind in minds)
            {
                CampusMindModel c = new CampusMindModel();
                
                c.Name1 = mind.Name1;
                c.Doj1 = mind.Doj1;
                c.ContactNumber1 = mind.ContactNumber1;
                c.Address1 = mind.Address1;
                modelmenu.Add(c);
            }
            return modelmenu;
        }
    }
}