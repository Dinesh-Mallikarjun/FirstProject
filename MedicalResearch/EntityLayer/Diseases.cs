using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Diseases
    {
        public int Disease_Id { get; set; }
        public string Disease_Name { get; set; }
        public Severity Disease_Severity_Id { get; set; }
        public Cause Disease_Cause_Id { get; set; }
        public string Disease_Description { get; set; }
        public List<Symptom> symptoms { get; set; }

    }
}
