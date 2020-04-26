using Business;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.Models
{
    public class ModelManager
    {
        static Busines business = new Busines();
        public void AddOperator(MobileOperatorModel mobileOperatorModel)
        {
            MobileOperator mobileOperator = new MobileOperator();
            mobileOperator.OperatorName = mobileOperatorModel.OperatorName;
            mobileOperator.OperatorRating = mobileOperatorModel.OperatorRating;
            Busines busines = new Busines();
            busines.AddOperator(mobileOperator);         

        }
        public List<MobileOperatorModel> DisplayOperators()
        {
            List<MobileOperatorModel> mobileOperatorModels = new List<MobileOperatorModel>();
            List<MobileOperator> mobileOperators = business.mobileOperators();
            foreach (var mobileOperator in mobileOperators)
            {
                MobileOperatorModel mobileOperatorModel = new MobileOperatorModel();
                mobileOperatorModel.OperatorId = mobileOperator.OperatorId;
                mobileOperatorModel.OperatorName = mobileOperator.OperatorName;
                mobileOperatorModel.OperatorRating = mobileOperator.OperatorRating;
                mobileOperatorModels.Add(mobileOperatorModel);
            }
            return mobileOperatorModels;
        }
        public List<MobileOperatorModel> mobileOperators()
        {
            List<MobileOperatorModel> mobileOperatorModels = new List<MobileOperatorModel>();
            List<MobileOperator> mobileOperators = business.mobileOperators();
            foreach(var mobileOperator in mobileOperators)
            {
                MobileOperatorModel mobileOperatorModel = new MobileOperatorModel();
                mobileOperatorModel.OperatorId = mobileOperator.OperatorId;
                mobileOperatorModel.OperatorName = mobileOperator.OperatorName;
                mobileOperatorModel.OperatorRating = mobileOperator.OperatorRating;
                mobileOperatorModels.Add(mobileOperatorModel);
            }
            return mobileOperatorModels;
        }
        public void AddCustomer(CustomerModel customerModel)
        {
            Customer customer = new Customer();
            customer.CustomerName = customerModel.CustomerName;
            customer.OperatorId = new MobileOperator();
            customer.OperatorId.OperatorId = customerModel.OperatorId.OperatorId;
            Busines busines = new Busines();
            busines.AddCustomer(customer);
        }

        public  List<MobileOperatorModel> displaymobileoperatorss()
        {
            decimal avg = business.displaymobileoperators();
            List<MobileOperatorModel> mobileOperatorModels = new List<MobileOperatorModel>();
            List<MobileOperator> mobiles = business.mobileOperators();
            List<MobileOperator> mobileAbvAvg = new List<MobileOperator>();
            foreach(var mobileOperator in mobiles)
            {
                if(mobileOperator.OperatorRating > avg)
                {
                    mobileAbvAvg.Add(mobileOperator);
                }
            }
            foreach (var ms in mobileAbvAvg)
            {
                MobileOperatorModel mobileOperatorModel = new MobileOperatorModel();
                mobileOperatorModel.OperatorId = ms.OperatorId;
                mobileOperatorModel.OperatorName = ms.OperatorName;
                mobileOperatorModel.OperatorRating = ms.OperatorRating;
                mobileOperatorModels.Add(mobileOperatorModel);
            }
            return mobileOperatorModels;
        }
        public void exportToExcel()
        {
            List<Customer> customers = new List<Customer>();
            customers = business.AllInfo();
            business.ExportToExcel(customers);           
        }
    }
}