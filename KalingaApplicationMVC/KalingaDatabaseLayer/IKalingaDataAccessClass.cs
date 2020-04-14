using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalingaDatabaseLayer
{
    public interface IKalingaDataAccessClass
    {
        void Insert(CampusMind newMind);
        List<CampusMind> Display();
    }
}
