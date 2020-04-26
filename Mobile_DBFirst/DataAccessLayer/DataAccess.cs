using ExceptionLayer;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccess
    {
        mobileDatabaseEntities mobileEntities = new mobileDatabaseEntities();
        public void AddOperator(Operator operatorr)
        {
            try
            {
                mobileEntities.Operators.Add(operatorr);
                mobileEntities.SaveChanges();
            }
            catch (InvalidData)
            {
                throw new InvalidData("Operator is already present");

            }
            catch (RatingOverLoadedException)
            {
                throw new RatingOverLoadedException("Enter valid rating");

            }
        }
        public List<Operator> mobileOperators()
        {
            try
            {

                return mobileEntities.Operators.ToList();
            }
            catch (NoParametersException)
            {
                throw new NoParametersException("no Operators");

            }
        }
        public List<Operator> DisplayOperators()
        {
            return mobileEntities.Operators.ToList();
        }
        public void AddCustomer(Customer customer)
        {
            try
            {
                var result = mobileEntities.Operators.SingleOrDefault(b => b.OperatorId == customer.Operator.OperatorId);
                customer.OperatorId = customer.Operator.OperatorId;
                customer.Operator = null;
                Customer customerr = mobileEntities.Customers.Add(customer);
                mobileEntities.SaveChanges();
            }
            catch (InValidOperatorIdException)
            {
                throw new InValidOperatorIdException("Operator id is not  present");
            }
        }
        public List<Operator> Average()
        {

            List<Operator> operators = mobileEntities.Operators.Where(a => a.OperatorRating > mobileEntities.Operators.Average(p => p.OperatorRating)).ToList();
            return operators;
        }
        public List<Customer> Cusomerinfo()
        {
            var result = mobileEntities.Customers.ToList();
            List<Customer> customers = new List<Customer>();
            foreach (var item in result)
            {
                Customer customer = new Customer();
                customer.CustomerId = item.CustomerId;
                customer.CustomerName = item.CustomerName;
                var mobileInfo = mobileEntities.Operators.Where(o => o.OperatorId == item.Operator.OperatorId);
                foreach (var mobile in mobileInfo)
                {
                    customer.Operator = new Operator();
                    customer.Operator.OperatorName = mobile.OperatorName;
                    customer.Operator.OperatorRating = mobile.OperatorRating;
                    customers.Add(customer);
                }
            }
            return customers;
        }
        public void ExportToExcel()
        {
            OleDbConnection oleDbConnection;
            OleDbCommand oleDbCommand = new OleDbCommand();
            string result = null;
            foreach (Customer item in Cusomerinfo())
            {
                oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\DBfirstMobile.xlsx;Extended Properties=Excel 12.0;");
                oleDbConnection.Open();
                oleDbCommand.Connection = oleDbConnection;
                result = "Insert into [Sheet1$]([CustomerId],[CustomerName],[Operatorname],[OperatorRating]) values (" + item.CustomerId + ",'" + item.CustomerName + "','" + item.Operator.OperatorName + "'," + item.Operator.OperatorRating + ")";
                oleDbCommand.CommandText = result;
                oleDbCommand.ExecuteNonQuery();
                oleDbConnection.Close();
            }
        }
    }
}
    
        

