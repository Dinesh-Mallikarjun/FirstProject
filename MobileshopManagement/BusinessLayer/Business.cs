using DataAccessLayer;
using EntityLayer;
using ExceptionLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Business : IBusiness
    {
        DataAccess dataAccess = new DataAccess();
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
            DataAccess dataAccess1 = new DataAccess();
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

            List<MobileOperator> mobileOperators = dataAccess.mobileOperators();
           
            foreach (MobileOperator operatorr in mobileOperators)
                {
                try
                {
                    if (operatorr.OperatorId == customer.OperatorId.OperatorId)
                    {
                        DataAccess dataAccess1 = new DataAccess();
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

    }
}
