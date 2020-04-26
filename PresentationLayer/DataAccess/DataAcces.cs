using EntityLayer;
using ExceptionLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataAcces
    {
        private SqlConnection connection;
        private void sqlconnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["connection123"].ToString();
            connection = new SqlConnection(constr);
        }
        public bool AddOperator(MobileOperator mobileOperator)
        {
            try
            {
                sqlconnection();
                int rows = 0;
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("sp_AddOperator", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("OperatorName", mobileOperator.OperatorName);
                sqlCommand.Parameters.AddWithValue("OperatorRating", mobileOperator.OperatorRating);
                rows = sqlCommand.ExecuteNonQuery();
                connection.Close();
                if (rows > 0)
                {
                    return true;
                }
            }
            catch(InvalidData)
            {
                throw new InvalidData("Operator is already present");
            }
            catch(RatingOverLoadedException)
            {
                throw new RatingOverLoadedException("Enter valid rating");
            }
            return false;
        }
        public List<MobileOperator> DisplayOperators()
        {
            List<MobileOperator> operatorList = new List<MobileOperator>();           
            
                sqlconnection();
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from fn_DisplayOperator() ", connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    MobileOperator mobileOperator = new MobileOperator();
                    mobileOperator.OperatorId = (int)sqlDataReader["OperatorId"];
                    mobileOperator.OperatorName = (string)sqlDataReader["OperatorName"];                   
                    operatorList.Add(mobileOperator);
                }
                connection.Close();
            return operatorList;           

        }


        public List<MobileOperator> mobileOperators()
        {
            List<MobileOperator> operatorList = new List<MobileOperator>();
            try
            {
                sqlconnection();
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from fn_DisplayOperator() ", connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    MobileOperator mobileOperator = new MobileOperator();
                    mobileOperator.OperatorId = (int)sqlDataReader["OperatorId"];
                    mobileOperator.OperatorName = (string)sqlDataReader["OperatorName"];
                    mobileOperator.OperatorRating = (decimal)sqlDataReader["OperatorRating"];
                    operatorList.Add(mobileOperator);
                }
                connection.Close();
                
            }
            catch (NoParametersException)
            {
                throw new NoParametersException("no Operators");
            }
            operatorList.Sort();
            return operatorList;          
        }
        public bool AddCustomer(Customer customer)
        {
            
            DisplayOperators();
            try
            {
                sqlconnection();
                int rows = 0;
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("sp_AddCustomer", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("CustomerName", customer.CustomerName);
                sqlCommand.Parameters.AddWithValue("OperatorId", customer.OperatorId.OperatorId);
                rows = sqlCommand.ExecuteNonQuery();
                connection.Close();
                if (rows > 0)
                {
                    return true;
                }
            }
            catch (InValidOperatorIdException)
            {
                throw new InValidOperatorIdException("Operator id is not  present");
            }
            return false;
        }
        public void ExportToExcel(List<Customer> customers)
        {

            OleDbConnection oleDbConnection;
            OleDbCommand oleDbCommand = new OleDbCommand();
            string result = null;
            foreach (Customer item in customers)
            {
                oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\mobile.xlsx;Extended Properties=Excel 12.0;");
                oleDbConnection.Open();
                oleDbCommand.Connection = oleDbConnection;
                result = "Insert into [Sheet1$]([CustomerId],[CustomerName],[Operatorname],[OperatorRating]) values (" + item.CustomerId + ",'" + item.CustomerName + "','" + item.OperatorId.OperatorName + "'," + item.OperatorId.OperatorRating + ")";
                oleDbCommand.CommandText = result;
                oleDbCommand.ExecuteNonQuery();
                oleDbConnection.Close();
            }
        }
        public List<Customer> AllInfo()
        {
            List<Customer> customers = new List<Customer>();
            sqlconnection();            
            SqlCommand cmd = new SqlCommand("sp_CustomerDetails", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Customer customer = new Customer();
                customer.CustomerId = (int)rd["CustomerId"];
                customer.CustomerName = (string)rd["CustomerName"];
                customer.OperatorId = new MobileOperator();
                customer.OperatorId.OperatorName = (string)rd["OperatorName"];
                customer.OperatorId.OperatorRating = (decimal)rd["OperatorRating"];

                customers.Add(customer);
            }
            connection.Close();
            return customers;
        }
        public decimal displaymobileoperators()
        {
            List<MobileOperator> mobileOperators = new List<MobileOperator>();
            sqlconnection();

            SqlCommand cmd = new SqlCommand("averag", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            decimal average = 0.0m;
            while (rd.Read())
            {
                average = (decimal)rd["OperatorRating"];
            }
            connection.Close();
            return average;
        }

    }
}
