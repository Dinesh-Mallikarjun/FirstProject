using Mobile_EntityLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_DataAccessLayer
{
    public class DataAccess
    {
        static SqlConnection sqlConnection = new SqlConnection("data source=.;database='Mobile';integrated security=SSPI");
        public bool AddOperator(MobileOperator mobileOperator)
        {
            int rows = 0;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_AddOperator", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("OperatorName", mobileOperator.OperatorName);
            sqlCommand.Parameters.AddWithValue("OperatorRating", mobileOperator.OperatorRating);
            sqlCommand.ExecuteNonQuery();
            if(rows>0)
            {
                return true;
            }
            return false;
        }
    }
}
