using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuiceShopEntities;
using System.Data.SqlClient;
using System.Data;
using JuiceShopExceptions;
using System.Configuration;

namespace JuiceShopDataAccessLayer
{
    public class JuiceShopDataAccessClass : IJuiceShopDataAccessClass

    {

        private SqlConnection connection;
        private void sqlconnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["connection"].ToString();
            connection = new SqlConnection(constr);
        }
        public void Insert(JuiceMenu obj)
        {
            sqlconnection();
            string query = "insert into JuiceFlavour values(" + obj.JuiceId + ",'" + obj.Flavour + "'," + obj.Price + ")";
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
        public List<JuiceMenu> Display()
        {
            sqlconnection();
            List<JuiceMenu> menuOfJuice = new List<JuiceMenu>();
            string query = "select * from JuiceFlavour";
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
                        JuiceMenu juiceData = new JuiceMenu();
                        juiceData.JuiceId = (int)datareader["JuiceId"];
                        juiceData.Flavour = (string)datareader["Flavour"];
                        juiceData.Price = (int)datareader["Price"];
                        menuOfJuice.Add(juiceData);
                    }
                    connection.Close();
                }
                return menuOfJuice;
            }
        }
        //public List<int> ReturnJuiceId()
        // {
        //    sqlconnection();
        //    List<int> juiceId = new List<int>();
        //    string query = "select JuicId from JuiceFlavour ";
        //    try
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        SqlDataReader datareader = cmd.ExecuteReader();
        //        if (!datareader.HasRows)
        //        {
        //            connection.Close();
        //        }
        //        else
        //        {
        //            while (datareader.Read())
        //            {
        //                juiceId.Add((int)datareader["JuiceId"]);
        //            }
        //            datareader.Close();
        //        }
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return juiceId;
        //  }
        //public int MaxOrder()
        //{
        //    sqlconnection();
        //    string query = "select max(OrderId) from JuiceOrders";


        //    try
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        int maxID = (int)cmd.ExecuteScalar();
        //        return maxID;

        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}
        //public void InsertNewOrder(JuiceOrder order)
        //{
        //    sqlconnection();
        //    string query = "insert into JuiceOrders values(" + order.OrderId + "," + order.JuiceId + "," + order.Quantity + "," + order.TotalPrice + ")";
        //    try
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        cmd.ExecuteNonQuery();
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}
        //public JuiceOrder UpdateOrder(JuiceOrder order)
        //{
        //    sqlconnection();
        //    try
        //    {
        //        connection.Open();
        //        string query2 = "select Qantity,TotalPrice,JuiceId from JuiceOrders where OrderId=" + order.OrderId;
        //        SqlCommand cmd = new SqlCommand(query2, connection);
        //        SqlDataReader datareader = cmd.ExecuteReader();
        //        int Price = 0;
        //        while (datareader.Read())
        //        {
        //            Price = (int)datareader["TotalPrice"] / (int)datareader["Quantity"];
        //            order.JuiceId = (int)datareader["juiceId"];
        //        }
        //        datareader.Close();
        //        order.TotalPrice = order.Quantity * Price;
        //        string query = "Update JuiceOrders set Quantity=" + order.Quantity + "TotalPrice=" + order.TotalPrice + "where OrderId=" + order.OrderId;
        //        SqlCommand cmd1 = new SqlCommand(query, connection);
        //        cmd1.ExecuteNonQuery();
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return order;

        public void DeleteData(JuiceMenu obj)
        {
            sqlconnection();
            string query = "Delete from JuiceFlavour values(" + obj.JuiceId + ",'" + obj.Flavour + "'," + obj.Price + ")";
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

    }
}

