using System;
using System.Data;

namespace Furniture_house_Application
{
    class BussinessLogicLayer:ICalculate
    {
        //Properties used for calculation
        private double dblPrice = 0;
        private double dblActualPrice = 0;
        private string strCategory;
        private int intRebatePercent = 0;
        private string strCustomerId;
        private string strProductId;
        private int intQuantity;
        private double dblFinalPrice = 0;
        private DataAccessLayer obj_Dal;

        public BussinessLogicLayer(string strCustomerId, string strProductId, int intQuantity)
        {
            this.strCustomerId = strCustomerId;
            this.strProductId = strProductId;
            this.intQuantity = intQuantity;
            obj_Dal = new DataAccessLayer(strCustomerId, strProductId, intQuantity);
        }

        public BussinessLogicLayer()
        {
        }

        public double DblPrice
        {
            get
            {
                return dblPrice;
            }

            set
            {
                dblPrice = value;
            }
        }

        public double DblActualPrice
        {
            get
            {
                return dblActualPrice;
            }

            set
            {
                dblActualPrice = value;
            }
        }

        public string StrCategory
        {
            get
            {
                return strCategory;
            }

            set
            {
                strCategory = value;
            }
        }

        public int IntRebatePercent
        {
            get
            {
                return intRebatePercent;
            }

            set
            {
                intRebatePercent = value;
            }
        }

        public double DblFinalPrice
        {
            get
            {
                return dblFinalPrice;
            }

            set
            {
                dblFinalPrice = value;
            }
        }
        /// <summary>
        /// Method Used for Calculating productprice,Actualprice without discount,Rebate percent and Final amount after discount 
        /// </summary>
        public void CalculateRebate()
        {
            try
            {
                //Get the price of the product selected from the database using dataaccesslayer
                DblPrice = obj_Dal.GetProductPrice();
                //Calculate the actual price from the product price and quantity
                DblActualPrice = DblPrice * intQuantity;
                //pass the actualprice to the database and fetch the rebate percent based on actaulprice
                obj_Dal = new DataAccessLayer(strCustomerId, strProductId, intQuantity, DblActualPrice);
                IntRebatePercent = obj_Dal.GetRebatePercent();
                //Calculate Final price by deducting the discount value
                //DblFinalPrice = DblActualPrice - (DblActualPrice * IntRebatePercent / 100);
                //Calculation done through interface
                DblFinalPrice = CalculateAmount(DblActualPrice, IntRebatePercent);
                //show the results in the display results window
                frm_DisplayResults obj_DisplayResults = new frm_DisplayResults(DblActualPrice, IntRebatePercent, DblFinalPrice);
                obj_DisplayResults.ShowDialog();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Method for getting customer detais from the database
        /// </summary>
        /// <returns></returns>
        public DataSet BLL_GetCustomerDetails()
        {
            try
            {
                obj_Dal = new DataAccessLayer();
                DataSet ds = obj_Dal.DAL_GetCustomerDetails();
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Method to get the product details from the database
        /// </summary>
        /// <returns></returns>
        public DataSet BLL_GetProductDetails()
        {
            try
            {
                obj_Dal = new DataAccessLayer();
                DataSet ds = obj_Dal.DAL_GetProductDetails();
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Method to calculate final price from actualprice and rebatepercent
        /// </summary>
        /// <param name="ActualPrice"></param>
        /// <param name="RebatePercent"></param>
        /// <returns>finalPrice</returns>
        public double CalculateAmount(double ActualPrice, int RebatePercent)
        {
            double finalPrice = ActualPrice - (ActualPrice* RebatePercent/100);
            return finalPrice;
        }
    }
}
