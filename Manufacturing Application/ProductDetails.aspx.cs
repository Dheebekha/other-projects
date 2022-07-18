using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    private string strProductName;
    private string strCustomerName;
    private BusinessLogicLayer obj_BLlayer;
    public string StrProductName
    {
        get
        {
            return strProductName;
        }

        set
        {
            strProductName = value;
        }
    }

    public string StrCustomerName
    {
        get
        {
            return strCustomerName;
        }

        set
        {
            strCustomerName = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            LoadProducts();
            LoadCustomers();
        }
    }
    /// <summary>
    /// Method to Load all products on Page Load
    /// </summary>
    private void LoadProducts()
    {
        try
        {
            DataTable Products = new DataTable();
            obj_BLlayer = new BusinessLogicLayer();
            Products = obj_BLlayer.BLL_LoadProducts();
            ddlProducts.DataSource = Products;
            ddlProducts.DataTextField = "Product_Name";
            ddlProducts.DataValueField = "Product_Name";
            ddlProducts.DataBind();
        }
        catch (Exception ex)
        {
            this.Session["exceptionMessage"] = ex.Message;
            Response.Redirect("ErrorDisplay.aspx");
        }
    }
    /// <summary>
    /// Method to load all Customers on Page Load
    /// </summary>
    private void LoadCustomers()
    {
        try
        {
            DataTable Customers = new DataTable();
            obj_BLlayer = new BusinessLogicLayer();
            Customers = obj_BLlayer.BLL_LoadCustomers();
            ddlCustomers.DataSource = Customers;
            ddlCustomers.DataTextField = "Customer_Name";
            ddlCustomers.DataValueField = "Customer_Name";
            ddlCustomers.DataBind();
        }
        catch (Exception ex)
        {
            this.Session["exceptionMessage"] = ex.Message;
            Response.Redirect("ErrorDisplay.aspx");
        }
    }
    public void btn_Click(object sender, EventArgs e)
    {
        GetProductDetails();
        GetSlowestWorker();
        GetFastestWorker();
    }
    public void btn_ClickforCustomer(object sender, EventArgs e)
    {
        try
        {
            obj_BLlayer = new BusinessLogicLayer();
            txtNumberforCustomer.Text = obj_BLlayer.BLL_GetNoofProdutsforSpecificCustomer(strCustomerName).ToString();
        }
        catch (Exception ex)
        {
            this.Session["exceptionMessage"] = ex.Message;
            Response.Redirect("ErrorDisplay.aspx");
        }
    }
    /// <summary>
    /// Method to get No of products produced within specified Date
    /// </summary>
    protected void GetProductDetails()
    {
        try
        {
            obj_BLlayer = new BusinessLogicLayer();
            txtNumber.Text = obj_BLlayer.BLL_GetProductDetails(strProductName, txtStartDate.Text, txtEndDate.Text).ToString();
        }
        catch (Exception ex)
        {
            this.Session["exceptionMessage"] = ex.Message;
            Response.Redirect("ErrorDisplay.aspx");
        }
    }
    /// <summary>
    /// Method to get the Slowest Worker of the specified Product
    /// </summary>
    protected void GetSlowestWorker()
    {
        try
        {
            obj_BLlayer = new BusinessLogicLayer();
            txtSlowestWorker.Text = obj_BLlayer.BLL_GetSlowestWorker(strProductName).ToString();
        }
        catch (Exception ex)
        {
            this.Session["exceptionMessage"] = ex.Message;
            Response.Redirect("ErrorDisplay.aspx");
        }
    }
    /// <summary>
    /// Method to get the fastest worker of the specified product
    /// </summary>
    protected void GetFastestWorker()
    {
        try
        {
            obj_BLlayer = new BusinessLogicLayer();
            txtFastestWorker.Text = obj_BLlayer.BLL_GetFastestWorker(strProductName).ToString();
        }
        catch (Exception ex)
        {
            this.Session["exceptionMessage"] = ex.Message;
            Response.Redirect("ErrorDisplay.aspx");
        }
    }
    protected void itemSelected(object sender, EventArgs e)
    {
        strProductName = ddlProducts.SelectedValue.ToString();

    }
    protected void CustomerSelected(object sender, EventArgs e)
    {
        strCustomerName = ddlCustomers.SelectedValue.ToString();

    }
}