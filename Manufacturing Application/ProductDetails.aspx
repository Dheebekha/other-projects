<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDetails.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DK Manufacturing</title>
</head>
<body>
<h1>Welcome to DK Manfucturing</h1>
    <form id="form1" runat="server">
<div style="float:left; width:20%;">
    <table style="margin:0 auto">
<caption><h3>Product Details</h3></caption>
       <tr style="align-content:center">
        <th>Product Name</th>
        <th><asp:DropDownList ID="ddlProducts" runat="server" AppendDataBoundItems="true" AutoPostBack="False" 
        onselectedindexchanged="itemSelected" ValidationGroup="g1">
  <asp:ListItem Text="<Select Product>" Value="0" />
</asp:DropDownList></th>
        </tr>
        <tr style="align-content:center">
        <th>Start Date</th>
        <th><asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox></th>
        </tr>
         <tr style="align-content:center">
        <th>End Date</th>
        <th><asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox></th>
        </tr>
        <tr style="align-content:center">
        <th>No.of Items Produced</th>
        <th><asp:TextBox ID="txtNumber" runat="server" text="0" ReadOnly="true"></asp:TextBox></th>
        </tr>
        <tr>
 </tr>
<tr style="align-content:center">
        <th>Slowest Worker</th>
        <th><asp:TextBox ID="txtSlowestWorker" runat="server" ReadOnly="true"></asp:TextBox></th>
        </tr>
<tr style="align-content:center">
        <th>Fastest Worker</th>
        <th><asp:TextBox ID="txtFastestWorker" runat="server" ReadOnly="true"></asp:TextBox></th>
        </tr>
<th style="float:right;"><asp:Button ID ="btnGetDetails" runat="server" OnClick="btn_Click" Text="Get Details" /></th>
            
       
    </table>
</div>
<div style="float:right; width:80%; ">
<table style="margin:0 auto">
<caption><h3>Customer Details</h3></caption>
<tr>
<th>Customer Name</th>
<th><asp:DropDownList ID="ddlCustomers" runat="server" AppendDataBoundItems="true" AutoPostBack="False" onselectedindexchanged="CustomerSelected">
  <asp:ListItem Text="<Select Customer>" Value="0" />
</asp:DropDownList></th>
</tr>
<tr style="align-content:center">
        <th>No.of Items Produced</th>
        <th><asp:TextBox ID="txtNumberforCustomer" runat="server" text="0" ReadOnly="true"></asp:TextBox></th>
        </tr>
        <tr>
<th style="float:right;"><asp:Button ID ="btnGetDetailsforCustomer" runat="server" OnClick="btn_ClickforCustomer" Text="Get Customer Details" /></th>
            
        </tr>
</table>
</div>
    </form>
</body>
</html>

