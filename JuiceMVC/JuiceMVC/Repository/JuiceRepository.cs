using JuiceMVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JuiceMVC.Repository
{
    public class JuiceRepository
    {

        private SqlConnection con;
        //To Handle connection related activities    
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
            con = new SqlConnection(constr);

        }
          
        public bool AddJuice(JuiceModel obj)
        {

            connection();
            SqlCommand com = new SqlCommand("AddNewJuiceDetails", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@JuiceId", obj.JuiceId);
            com.Parameters.AddWithValue("@Flavour", obj.Flavour);
            com.Parameters.AddWithValue("@Price", obj.Price);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public List<JuiceModel> GetAllJuices()
        {
            connection();
            List<JuiceModel> JuiceList = new List<JuiceModel>();


            SqlCommand com = new SqlCommand("GetJuices", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
             
            foreach (DataRow dr in dt.Rows)
            {

                JuiceList.Add(

                    new JuiceModel
                    {

                        JuiceId = Convert.ToInt32(dr["JuiceId"]),
                        Flavour = Convert.ToString(dr["Flavour"]),
                        Price = Convert.ToInt32(dr["Price"])                      

                    }
                    );
            }
            return JuiceList;
        }


        public bool UpdateJuice(JuiceModel obj)
        {

            connection();
            SqlCommand com = new SqlCommand("UpdateJuiceDetails", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@JuiceId", obj.JuiceId);
            com.Parameters.AddWithValue("@Flavour", obj.Flavour);
            com.Parameters.AddWithValue("@Price", obj.Price);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteJuice(int Id)
        {

            connection();
            SqlCommand com = new SqlCommand("DeleteJuiceById", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@JuiceId", Id);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }


        }
    }





}
    