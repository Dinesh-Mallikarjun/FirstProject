
using BusinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.Models
{
    public class ModelManager
    {
        static Business business = new Business();
        public void AddOperator(MobileOperatorModel mobileOperatorModel)
        {
            Operator mobileOperator = new Operator();
            mobileOperator.OperatorName = mobileOperatorModel.OperatorName;
            mobileOperator.OperatorRating = mobileOperatorModel.OperatorRating;
            Business busines = new Business();
            busines.AddOperator(mobileOperator);

        }
        public List<MobileOperatorModel> DisplayOperators()
        {
            List<MobileOperatorModel> mobileOperatorModels = new List<MobileOperatorModel>();
            List<Operator> mobileOperators = business.mobileOperators();
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
            List<Operator> mobileOperators = business.mobileOperators();
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
        public void AddCustomer(CustomerModel customerModel)
        {
            Customer customer = new Customer();
            customer.CustomerName = customerModel.CustomerName;
            customer.Operator = new Operator();
            customer.Operator.OperatorId = customerModel.OperatorId.OperatorId;
            Business busines = new Business();
            busines.AddCustomer(customer);
        }

        public List<MobileOperatorModel> displaymobileoperatorss()
        {
            List<Operator> avg = business.Average();
            List<MobileOperatorModel> mobileOperatorModels = new List<MobileOperatorModel>();
            List<Operator> mobiles = business.mobileOperators();
            List<Operator> mobileAbvAvg = new List<Operator>();
            foreach (var mobileOperator in mobiles)
            {
                foreach (var item in avg)
                {
                    if (mobileOperator.OperatorRating > item.OperatorRating)
                    {
                        mobileAbvAvg.Add(mobileOperator);
                    }
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
            customers = business.Cusomerinfo();
            business.ExportToExcel();
        }
    }
    }
