using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Furniture_house_Application
{
    //DataAccessLayer for establishing connection with the database and fetch data
    class DataAccessLayer
    {
        private string connectionString;
        private int intQuantity;
        private double dblActualPrice;
        private string strCustomerId;
        private string strProductId;

        public string ConnectionString
        {
            get
            {
                return connectionString;
            }

            set
            {
                connectionString = value;
            }
        }

        public DataAccessLayer(string strCustomerId, string strProductId, int intQuantity)
        {
            this.strCustomerId = strCustomerId;
            this.strProductId = strProductId;
            this.intQuantity = intQuantity;
        }

        public DataAccessLayer(string strCustomerId, string strProductId, int intQuantity, double dblActualPrice) : this(strCustomerId, strProductId, intQuantity)
        {
            this.dblActualPrice = dblActualPrice;
        }

        public DataAccessLayer()
        {
        }
        /// <summary>
        /// Method to reteieve connectionstring from app.config
        /// </summary>
        public void GetConnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Furniture_house_Application.ReportServer_MSSQLSERVER1ConnectionString"].ConnectionString;
        }
        /// <summary>
        /// Method to fetch the price of the product selected form the database
        /// </summary>
        /// <returns></returns>
        public double GetProductPrice()
        {
            double DblPrice = 0;
            string queryString =
            "SELECT Product_price "
            + "FROM Products "
            + "WHERE Product_Id = " + "'" + strProductId + "'" + " ;";
            GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create the Command
                SqlCommand command = new SqlCommand(queryString, connection);
                // Open the connection in a try/catch block. 
                try
                {
                    connection.Open();
                    DblPrice = Convert.ToDouble(command.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return DblPrice;
        }
        /// <summary>
        /// Method to fecth the Rebate percent for the selected customer from the database
        /// </summary>
        /// <returns></returns>
        public int GetRebatePercent()
        {
            int intRebatePercent = 0;
            var connectionString = ConfigurationManager.ConnectionStrings["Furniture_house_Application.ReportServer_MSSQLSERVER1ConnectionString"].ConnectionString;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("uspGetRebatePercent", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@CustomerId", SqlDbType.NVarChar).Value = strCustomerId;
                command.Parameters.Add("@ActualPrice", SqlDbType.Money).Value = dblActualPrice;
                sqlConnection.Open();
                intRebatePercent = Convert.ToInt32(command.ExecuteScalar());

                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return intRebatePercent;
        }
        /// <summary>
        /// Mathod to Fecth the Customer Details from the database
        /// </summary>
        /// <returns>Dataset with table containing customer details</returns>
        public DataSet DAL_GetCustomerDetails()
        {
            try {
                var connectionString = ConfigurationManager.ConnectionStrings["Furniture_house_Application.ReportServer_MSSQLSERVER1ConnectionString"].ConnectionString;
                string Sql = "SELECT Customer_Id,Customer_Name FROM Customers";
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(Sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Method to Fetch the product details from the database
        /// </summary>
        /// <returns>DataSet With Table containing the product details</returns>
        public DataSet DAL_GetProductDetails()
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["Furniture_house_Application.ReportServer_MSSQLSERVER1ConnectionString"].ConnectionString;
                string Sql = "SELECT Product_Id,Product_Name FROM Products";
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(Sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
