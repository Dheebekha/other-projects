using System;
using System.Data;
using System.Windows.Forms;

namespace Furniture_house_Application
{
    public partial class frm_FurnitureHouse : Form
    {
        private string strProductId;
        private string strCustomerId;
        private int intQuantity = 0;
        private BussinessLogicLayer obj_BLlayer;

        public string StrProductId
        {
            get
            {
                return strProductId;
            }

            set
            {
                strProductId = value;
            }
        }
        public string StrCustomerId
        {
            get
            {
                return strCustomerId;
            }

            set
            {
                strCustomerId = value;
            }
        }

        public int IntQuantity
        {
            get
            {
                return intQuantity;
            }

            set
            {
                intQuantity = value;
            }
        }
        public frm_FurnitureHouse()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Calculate method called on click of calculate button after validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData() == 0)
                    return;
                //Get the quatity from the textbox data
                IntQuantity = Convert.ToInt32(txt_Quantity.Text);
                //Call the calculate method of Business logic layer
                obj_BLlayer = new BussinessLogicLayer(StrCustomerId, StrProductId, IntQuantity);
                obj_BLlayer.CalculateRebate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,ex.Message, "Error Message");
                return;
            }
        }
        /// <summary>
        /// Method for validating all the input data entered by the customer
        /// Returns 1 if validation suceeds, 0 in case of failure
        /// </summary>
        /// <returns></returns>
        private int ValidateData()
        {
            int intValidationResult = 1;
            //Validate Customer
            if (StrCustomerId == null || StrCustomerId == "")
            {
                MessageBox.Show(this, "Please Select a valid Customer", "Validation Message");
                intValidationResult = 0;
                return (intValidationResult);
            }
            //validate product
            if (StrProductId == null || StrProductId == "")
            {
                MessageBox.Show(this,"Please Select a valid Product", "Validation Message");
                intValidationResult = 0;
                return (intValidationResult);
            }
            //validate quantity(It can be further extended for checking with the availability of the product)
            if (txt_Quantity.Text == null || txt_Quantity.Text == "")
            {
                MessageBox.Show(this,"Please Enter the Quantity", "Validation Message");
                intValidationResult = 0;
                return (intValidationResult);
            }
            return (intValidationResult);
        }
        private void cmb_ProductName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            StrProductId = cmb_ProductName.SelectedValue.ToString();
        }
        private void cmb_CustomerName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            StrCustomerId = cmb_CustomerName.SelectedValue.ToString();
        }

        private void frm_FurnitureHouse_Load_1(object sender, EventArgs e)
        {
            try
            {
                obj_BLlayer = new BussinessLogicLayer();
                //Get the Customer Details and bind it to the Customer dropdown
                DataSet ds_CustomerDetails = obj_BLlayer.BLL_GetCustomerDetails();
                DataTable dt_CustomerDetails = ds_CustomerDetails.Tables[0];
                // Create a new row
                DataRow dr = dt_CustomerDetails.NewRow();
                dr["Customer_Id"] = null;
                dr["Customer_Name"] = "Select";
                // Insert it into the 0th index
                dt_CustomerDetails.Rows.InsertAt(dr, 0);
                cmb_CustomerName.DataSource = dt_CustomerDetails;
                cmb_CustomerName.DisplayMember = "Customer_Name";
                cmb_CustomerName.ValueMember = "Customer_Id";
                //Get the product details and bind it to the product dropdown
                DataSet ds_ProductDetails = obj_BLlayer.BLL_GetProductDetails();
                DataTable dt_ProductDetails = ds_ProductDetails.Tables[0];
                // Create a new row
                DataRow drp = dt_ProductDetails.NewRow();
                drp["Product_Id"] = null;
                drp["Product_Name"] = "Select";
                // Insert it into the 0th index
                dt_ProductDetails.Rows.InsertAt(drp, 0);
                cmb_ProductName.DataSource = dt_ProductDetails;
                cmb_ProductName.DisplayMember = "Product_Name";
                cmb_ProductName.ValueMember = "Product_Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message,"Error Message");
                return;
            }
        }
    }
}
