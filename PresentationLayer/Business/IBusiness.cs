using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public interface IBusiness
    {
        bool AddOperator(MobileOperator mobileOperator);
        List<MobileOperator> mobileOperators();
        bool AddCustomer(Customer customer);
        void ExportToExcel(List<Customer> customers);
        List<Customer> AllInfo();        
        decimal displaymobileoperators();
        List<MobileOperator> DisplayOperators();

    }
}
