using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalingaBusinessLayer
{
   public  interface IKalingaBusinessClass
    {
        void InsertMindsData(CampusMind newMind);

        List<CampusMind> CampusMind();
    }
}
