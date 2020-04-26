using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IBusiness
    {
        bool AddOperator(Operator mobileOperator);
        List<Operator> mobileOperators();
        List<Operator> DisplayOperators();
        void AddCustomer(Customer customer);
        List<Operator> Average();
        List<Customer> Cusomerinfo();
        void ExportToExcel();

    }
}
