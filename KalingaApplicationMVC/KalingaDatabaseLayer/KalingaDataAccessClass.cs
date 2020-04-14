using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Entities;
 

namespace KalingaDatabaseLayer
{
    public class KalingaDataAccessClass :IKalingaDataAccessClass
    {
        private SqlConnection connection;
    
        private void sqlconnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["connection123"].ToString();
            connection = new SqlConnection(constr);
        }
        public void Insert(CampusMind obj)
        {
            
            string query = "insert into CampusMind values(" + obj.ID1+ ",'" + obj.Name1 + "','" + obj.Doj1 + "'," + obj.ContactNumber1 + ",'" + obj.Address1 + "')";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                int rowsAffected = cmd.ExecuteNonQuery();
            }
            finally
            {   
                connection.Close();
            }

        }
        public List<CampusMind> Display()
        {
            sqlconnection();
            List<CampusMind> listofminds = new List<CampusMind>();
            string query = "select * from CampusMind";
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader datareader = cmd.ExecuteReader();
                if (!datareader.HasRows)
                {
                    connection.Close();
                }
                else
                {
                    while (datareader.Read())
                    {
                        CampusMind MindData = new CampusMind();
                        MindData.ID1 = (int)datareader["ID"];
                        MindData.Name1 = (string)datareader["Name"];
                        MindData.Doj1 = (string)datareader["Doj"];
                        MindData.ContactNumber1 = (int)datareader["ContactNumber"];
                        MindData.Address1 = (string)datareader["Address"];
                        listofminds.Add(MindData);
                    }
                    connection.Close();
                }
                return listofminds;
            }
        }


    }
}
