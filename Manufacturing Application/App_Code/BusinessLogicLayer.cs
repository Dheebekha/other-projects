using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BusinessLogicLayer
/// </summary>
public class BusinessLogicLayer
{
    private DataAccessLayer obj_Dal;
    public BusinessLogicLayer()
    {
        obj_Dal = new DataAccessLayer();
    }
    public DataTable BLL_LoadProducts()
    {
        DataTable Products = obj_Dal.DLL_LoadProducts();
        return Products;
    }
    public DataTable BLL_LoadCustomers()
    {
        DataTable Customers = obj_Dal.DLL_LoadCustomers();
        return Customers;
    }
    public int BLL_GetNoofProdutsforSpecificCustomer(string strCustomerName)
    {
        return (obj_Dal.DLL_GetNoofProdutsforSpecificCustomer(strCustomerName));
    }
    public int BLL_GetProductDetails(string strProductName, string StartDate, string EndDate)
    {
        return (obj_Dal.DLL_GetProductDetails(strProductName, StartDate, EndDate));
    }
    public string BLL_GetSlowestWorker(string strProductName)
    {
        return (obj_Dal.DLL_GetSlowestWorker(strProductName));
    }
    public string BLL_GetFastestWorker(string strProductName)
    {
        return (obj_Dal.DLL_GetFastestWorker(strProductName));
    }
}