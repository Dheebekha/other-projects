using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataAccessLayer
/// </summary>
public class DataAccessLayer
{
    private string connectionString;
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
    public DataAccessLayer()
    {
        GetConnectionString();
    }
    public DataTable DLL_LoadProducts()
    {
        DataTable Products = new DataTable();
        using (SqlConnection con = new SqlConnection(ConnectionString))
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Product_Name FROM ProductionDetails.dbo.Products", con);
                adapter.Fill(Products);

                return Products;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
    public DataTable DLL_LoadCustomers()
    {
        DataTable Customers = new DataTable();
        using (SqlConnection con = new SqlConnection(ConnectionString))
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Customer_Name FROM ProductionDetails.dbo.Products", con);
                adapter.Fill(Customers);

                return Customers;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
    public int DLL_GetNoofProdutsforSpecificCustomer(string strCustomerName)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("uspGetNoofProductsforSpecificCustomer", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Customer_Name", SqlDbType.NVarChar).Value = strCustomerName;
            sqlConnection.Open();
            int noofProducts = Convert.ToInt32(command.ExecuteScalar());
            sqlConnection.Close();
            return noofProducts;
        }
        catch (SqlException ex)
        {
            throw ex;
        }
    }
    public int DLL_GetProductDetails(string strProductName, string StartDate, string EndDate)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("uspGetProductDetails1", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Product_Name", SqlDbType.NVarChar).Value = strProductName;
            command.Parameters.Add("@Product_StartDate", SqlDbType.Date).Value = StartDate;
            command.Parameters.Add("@Product_EndDate", SqlDbType.Date).Value = EndDate;
            sqlConnection.Open();
            int noofProducts = Convert.ToInt32(command.ExecuteScalar());
            sqlConnection.Close();
            return noofProducts;
        }
        catch (SqlException ex)
        {
            throw ex;
        }
    }
    public string DLL_GetSlowestWorker(string strProductName)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("uspGetSlowestWorker", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Product_Name", SqlDbType.NVarChar).Value = strProductName;
            sqlConnection.Open();
            string slowestWorker = command.ExecuteScalar().ToString();
            sqlConnection.Close();
            return slowestWorker;
        }
        catch (SqlException ex)
        {
            throw ex;
        }
    }
    public string DLL_GetFastestWorker(string strProductName)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("uspGetFastestWorker", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Product_Name", SqlDbType.NVarChar).Value = strProductName;
            sqlConnection.Open();
            string fastestWorker = command.ExecuteScalar().ToString();
            sqlConnection.Close();
            return fastestWorker;
        }
        catch (SqlException ex)
        {
            throw ex;
        }
    }
    public void GetConnectionString()
    {
        connectionString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
    }
}