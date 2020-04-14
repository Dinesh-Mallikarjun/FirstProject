using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Symptom
    {
        public int Symptom_id { get; set; }

        public Disease Disease_id { get; set; }

        public string Symptom_name { get; set; }

        public string Symptom_Description { get; set; }

    }
}
