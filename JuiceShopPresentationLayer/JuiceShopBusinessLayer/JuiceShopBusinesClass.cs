using JuiceShopDataAccessLayer;
using JuiceShopEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JuiceShopExceptions;

namespace JuiceShopBusinessLayer
{
    public class JuiceShopBusinesClass: IJuiceShopBusiness
    {
        IJuiceShopDataAccessClass _JuiceDataAccess = new JuiceShopDataAccessClass();
        public void InsertJuiceData(JuiceMenu newFlavour)
        {
            _JuiceDataAccess.Insert(newFlavour);
        }
        public  List<JuiceMenu> JuiceFlavour()
        {
            List<JuiceMenu> jList = _JuiceDataAccess.Display();
            return jList;
        }



    }
}
