
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using _3_tier;
using JuiceShopDataAccessLayer;
using JuiceShopEntity;
using JuiceShopException;

namespace JuiceShopBusinessLayer
{
    public class BusinessLayer
    {
        DataLayer dal = new DataLayer();
        Dictionary<int, Flavour> list = new Dictionary<int, Flavour>();
        List<Flavour> Menu = null;
        public void validateMenu(Flavour juice)
        {
            // showMenu();

            try
            {
                list.Add(juice.FlavourId, juice);
            }
            catch (ArgumentException e) { throw e; }

        }
        public void pushToDb()
        {
            try
            {
                dal.addMenu(list);
            }
            catch (SqlException e) { throw e; }
        }

        public Orders pushOrder(Orders order)
        {
            if (list.ContainsKey(order.JuiceId))
            {
                order = dal.placeorder(order);
                //order=dal.getOrder(order.OrderId);
                return order;
            }
            else
            {
                throw new JuiceIdNotFoundException("JuiceId Not Found");
            }
        }

        public Dictionary<int, Flavour> showMenu()
        {
            try
            {
                list = dal.getMenu();
                return list;
            }
            catch (SqlException e) { throw e; }
        }

        [Serializable]
        private class JuiceIdNotFoundException : Exception
        {
            public JuiceIdNotFoundException()
            {
            }

            public JuiceIdNotFoundException(string message) : base(message)
            {
            }

            public JuiceIdNotFoundException(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected JuiceIdNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }


}
