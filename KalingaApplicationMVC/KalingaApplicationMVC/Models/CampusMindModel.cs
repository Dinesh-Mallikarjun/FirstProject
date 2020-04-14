using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KalingaApplicationMVC.Models
{
    public class CampusMindModel
    {
        private int ID;
        private string Name;
        private string Doj;
        private int ContactNumber;
        private string Address;
        private int LeadID;

        public int ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Doj1 { get => Doj; set => Doj = value; }
        public int ContactNumber1 { get => ContactNumber; set => ContactNumber = value; }
        public string Address1 { get => Address; set => Address = value; }
        public int LeadID1 { get => LeadID; set => LeadID = value; }

        public MindtreeLeadModel mindtreeLeadModel { get; set; }
    }
}