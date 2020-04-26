using Mobile_DataAccessLayer;
using Mobile_EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_BusinessLayer
{
    public class Business : IBusiness
    {
        DataAccess dataAccess = new DataAccess();
        public bool AddOperator(MobileOperator mobileOperator)
        {
            return dataAccess.AddOperator(mobileOperator);
        }
    }
}
