using Doctor_Entity;
using DP_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_BusinessLayer
{
    public class Businesslayer
    {
        public void AddDoctor(Doctor doctor)
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            dataAccessLayer.AddDoctor(doctor);         

        }
    }
}
