using EntityLayer;
using Medical_Reaserch_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Reaserch_Business_Layer
{
    public class Business
    {
        DataAccess dataAccess = new DataAccess();
        public void AddDisease(Disease disease)
        {
            dataAccess.AddDisease(disease);
        }
    }
}
