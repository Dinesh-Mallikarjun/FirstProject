


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using JuiceShopBusinessLayer;

namespace _3_tier
{
    class DataLayer
    {

static int oid = 0;
        static string connection = System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        static SqlConnection con = null;
        static void createConnection()
        {
            //con= new SqlConnection("data source=.;database=JuiceShop;integrated security=SSPI");
            con = new SqlConnection(connection);
            //Console.WriteLine("Connection Established");
            con.Open();
        }
        public void addMenu(Dictionary<int, Flavour> menu)
        {
            try
            {
                foreach (Flavour f in menu.Values)
                {
                    createConnection();
                    SqlCommand cm = new SqlCommand("setElements", con);
                    cm.CommandType = System.Data.CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@id", f.FlavourId);
                    cm.Parameters.AddWithValue("@name", f.FlavourName);
                    cm.Parameters.AddWithValue("@cost", f.Cost);
                    cm.ExecuteNonQuery();
                    con.Close();

                }
                Console.WriteLine("Data Inserted........");
            }
            catch (SqlException e) { throw e; }

        }

        internal Orders placeorder(Orders order)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, Flavour> getMenu()
        {
            Dictionary<int, Flavour> menu = new Dictionary<int, Flavour>();
            try
            {

                createConnection();
                SqlCommand cm = new SqlCommand("select * from Flavour;", con);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet data = new DataSet();
                adapter.SelectCommand = cm;
                adapter.Fill(data);
                for (int i = 0; i <= data.Tables[0].Rows.Count - 1; i++)
                {
                    Flavour f = new Flavour();
                    f.FlavourId = Convert.ToInt32(data.Tables[0].Rows[i].ItemArray[0]);
                    f.FlavourName = (string)data.Tables[0].Rows[i].ItemArray[1];
                    f.Cost = Convert.ToDouble(data.Tables[0].Rows[i].ItemArray[2]);
                    menu.Add(f.FlavourId, f);
                }
            }
            catch (SqlException e) { throw e; }
            con.Close();
            return menu;
        }

        public double getCost(int fid)
        {
            double cost = 0;
            try
            {
                createConnection();
                SqlCommand cm = new SqlCommand("select Cost from Flavour where Flavourid=" + fid + ";", con);
                SqlDataReader reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    cost = Convert.ToDouble(reader[0]);
                }
            }
            catch (SqlException e) { throw e; }
            return cost;
        }
        public Orders Placeorder(Orders order)
        {

            if (oid == 0)
            {
                truncateTable();
            }
            oid++;
            try
            {

                createConnection();
                SqlCommand cm = new SqlCommand("setOrderElements", con);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@oid", oid);
                cm.Parameters.AddWithValue("@fid", order.JuiceId);
                cm.Parameters.AddWithValue("@quant", order.Quantity);
                double d = getCost(order.JuiceId) * order.Quantity;
                cm.Parameters.AddWithValue("@cost", d);
                cm.ExecuteNonQuery();
                con.Close();


                // Console.WriteLine("Order Placed");
                order = this.getOrder(oid);
                return order;
            }
            catch (SqlException e) { throw e; }
        }

        public Orders getOrder(int id)
        {
            // Dictionary<int, Orders> menu = new Dictionary<int, Orders>();
            Orders f = new Orders();
            try
            {

                createConnection();
                SqlCommand cm = new SqlCommand("select * from Orders Where oid=" + id + ";", con);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet data = new DataSet();
                adapter.SelectCommand = cm;
                adapter.Fill(data);

                for (int i = 0; i <= data.Tables[0].Rows.Count - 1; i++)
                {

                    f.OrderId = Convert.ToInt32(data.Tables[0].Rows[i].ItemArray[0]);
                    f.JuiceId = Convert.ToInt32(data.Tables[0].Rows[i].ItemArray[1]);
                    f.Quantity = Convert.ToInt32(data.Tables[0].Rows[i].ItemArray[2]);
                    f.tPrice = Convert.ToDouble(data.Tables[0].Rows[i].ItemArray[3]);
                    // menu.Add(f.OrderId, f);
                }
            }
            catch (SqlException e) { throw e; }
            con.Close();
            return f;
        }

        void truncateTable()
        {
            createConnection();
            SqlCommand cm = new SqlCommand("truncate table Orders;", con);
            con.Close();
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }





    }
}
