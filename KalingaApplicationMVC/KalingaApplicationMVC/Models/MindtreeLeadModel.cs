using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KalingaApplicationMVC.Models
{
    public class MindtreeLeadModel
    {
        private int ID;
        private string LeadName;
        private int ContactNo;
        private string Category;

       // List<CampusMindModel> mindsModel = new List<CampusMindModel>();

        public int ID1 { get => ID; set => ID = value; }
        public string LeadName1 { get => LeadName; set => LeadName = value; }
        public int ContactNo1 { get => ContactNo; set => ContactNo = value; }
        public string Category1 { get => Category; set => Category = value; }
        public List<CampusMindModel> MindsModel { get ; set; }
       
    }
}