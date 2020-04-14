using JuiceShopEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuiceShopExceptions;


namespace JuiceShopDataAccessLayer
{
   public  interface IJuiceShopDataAccessClass
    {
        void Insert(JuiceMenu newFlavour);
        List<JuiceMenu> Display();
    }
}
