using DataAccessLayer;
using ExceptionLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Business
    {
        DataAccess dataAccess = new DataAccess();
        public void AddOperator(Operator mobileOperator)
        {
            List<Operator> mobileOperators = dataAccess.mobileOperators();
            foreach (Operator operatorr in mobileOperators)
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
            
        }
        public List<Operator> mobileOperators()
        {
            List<Operator> mobileOperators = dataAccess.mobileOperators();
            foreach (Operator operatorr in mobileOperators)
            {
                if (mobileOperators.Count == 0)
                {
                    throw new NoParametersException("There is no operator");
                }
            }
            return dataAccess.mobileOperators();
        }
        public void AddCustomer(Customer customer)
        {
            List<Operator> mobileOperators = dataAccess.DisplayOperators();

            foreach (Operator operatorr in mobileOperators)
            {
                try
                {
                    if (customer.Operator.OperatorId != 0)
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
        }
        public List<Operator> Average()
        {
            return dataAccess.Average();
        }
        public List<Customer> Cusomerinfo()
        {
            return dataAccess.Cusomerinfo();
        }
        public void ExportToExcel()
        {
            dataAccess.ExportToExcel();
        }
    }
}
