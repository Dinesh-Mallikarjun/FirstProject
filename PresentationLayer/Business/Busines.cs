using DataAccess;
using EntityLayer;
using ExceptionLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Busines : IBusiness
    {
        DataAcces dataAccess = new DataAcces();
        public bool AddOperator(MobileOperator mobileOperator)
        {
            List<MobileOperator> mobileOperators = dataAccess.mobileOperators();
            foreach (MobileOperator operatorr in mobileOperators)
            {
                if (operatorr.OperatorName.ToLower() == mobileOperator.OperatorName.ToLower())
                {
                    throw new InvalidData("Please enter another operator name");
                }
                if (mobileOperator.OperatorRating > 5 || mobileOperator.OperatorRating < 0)
                {
                    throw new RatingOverLoadedException("Please enter rating between 0 and 5");
                }
            }
            DataAcces dataAccess1 = new DataAcces();
            dataAccess1.AddOperator(mobileOperator);
            return true;
        }
        public List<MobileOperator> mobileOperators()
        {
            List<MobileOperator> mobileOperators = dataAccess.mobileOperators();
            foreach (MobileOperator operatorr in mobileOperators)
            {
                if (mobileOperators.Count==0)
                {
                    throw new NoParametersException("There is no operator");
                }
            }
            return dataAccess.mobileOperators();
        }
        public bool AddCustomer(Customer customer)
        {

            List<MobileOperator> mobileOperators = dataAccess.DisplayOperators();
           
            foreach (MobileOperator operatorr in mobileOperators)
                {
                try
                {
                    if (customer.OperatorId.OperatorId != 0)
                    {
                        DataAcces dataAccess1 = new DataAcces();
                        dataAccess1.AddCustomer(customer);
                    }
                }
                catch (InValidOperatorIdException)
                {
                    throw new InValidOperatorIdException("Enter valid operator id");
                }
            }            
            return true;
        }
        public List<Customer> AllInfo()
        {
            return dataAccess.AllInfo();
        }
        public void ExportToExcel(List<Customer> customers)
        {
            dataAccess.ExportToExcel(customers);
        }
        
        public decimal displaymobileoperators()
        {
            return dataAccess.displaymobileoperators();
        }
        public List<MobileOperator> DisplayOperators()
        {
            return dataAccess.DisplayOperators();
        }

    }
}
