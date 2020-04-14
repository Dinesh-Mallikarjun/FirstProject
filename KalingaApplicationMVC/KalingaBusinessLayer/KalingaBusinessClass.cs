using Entities;
using KalingaDatabaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalingaBusinessLayer
{
    public class KalingaBusinessClass: IKalingaBusinessClass
    {
        IKalingaDataAccessClass _MindDataAccess = new KalingaDataAccessClass();
        public void InsertMindsData(CampusMind newMind)
        {
            _MindDataAccess.Insert(newMind);
        }
        public List<CampusMind> CampusMind()
        {
            List<CampusMind> CList = _MindDataAccess.Display();
            return CList;
        }


    }
}
