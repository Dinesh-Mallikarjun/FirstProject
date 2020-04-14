using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuiceShopEntities;
using JuiceShopDataAccessLayer;
using JuiceShopExceptions;

namespace JuiceShopBusinessLayer
{
    public interface IJuiceShopBusiness
    {
        void InsertJuiceData(JuiceMenu newFlavour);

        List<JuiceMenu> JuiceFlavour();
    
    }
}
