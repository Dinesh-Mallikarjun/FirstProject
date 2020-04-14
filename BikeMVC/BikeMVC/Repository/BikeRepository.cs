using BikeMVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BikeMVC.Repository
{
    public class BikeRepository
    {       

            private SqlConnection con;
            //To Handle connection related activities    
            private void connection()
            {
                string constr = ConfigurationManager.ConnectionStrings["myConnection"].ToString();
                con = new SqlConnection(constr);

            }
            //To Add Employee details    
            public bool AddBike(BikeModel obj)
            {

                connection();
                SqlCommand com = new SqlCommand("AddNewBikeDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Name", obj.Name);
                com.Parameters.AddWithValue("@Brand", obj.Brand);
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
    
        public List<BikeModel> GetAllBikes()
        {
            connection();
            List<BikeModel> BikeList = new List<BikeModel>();


            SqlCommand com = new SqlCommand("GetBikes", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
            //Bind EmpModel generic list using dataRow     
            foreach (DataRow dr in dt.Rows)
            {



                BikeList.Add(new BikeModel
                {
                                Name = Convert.ToString(dr["Name"]),
                                Brand = Convert.ToString(dr["Brand"]),
                                Price = Convert.ToInt32(dr["Price"])
                });
            }
            return BikeList;
        }


        public bool UpdateBike(BikeModel obj)
        {

            connection();
            SqlCommand com = new SqlCommand("UpdateBikeDetails", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Name", obj.Name);
            com.Parameters.AddWithValue("@Brand", obj.Brand);
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


        public bool DeleteBike(string Name)
        {

            connection();
            SqlCommand com = new SqlCommand("DeleteBikeByName", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@BikeName", Name);

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
