using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MindtreeLead
    {
        private int ID;
        private string LeadName;
        private int ContactNo;
        private string Category;

        public int ID1 { get => ID; set => ID = value; }
        public string LeadName1 { get => LeadName; set => LeadName = value; }
        public int ContactNo1 { get => ContactNo; set => ContactNo = value; }
        public string Category1 { get => Category; set => Category = value; }

         List<CampusMind> minds = new List<CampusMind>();
    }
}
