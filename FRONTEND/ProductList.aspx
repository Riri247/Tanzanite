<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="FRONTEND.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
		table 
		{
            width: 100%;
            border-collapse: collapse;
        }
		td
		{
            border: 1px;
            padding: 8px;
            text-align: center;
        }
		
		th{
            border: 1px;
            padding: 8px;
            text-align: center;
        }
        th 
		{
            background-color: #596e79;
        }
        img 
		{
            width: 100px;
            height: auto;
        }
		body
		{
            height: 100%; 
          
		}
	</style>

    <h1>Product List</h1>
	<table>
	    <tr>
            <th>Product Name</th>
            <th>Image</th>
            <th>Price</th>
        </tr>

		<div id="ContainerforRows" runat="server">

		<!-- Code goes here-->
		<!-- product end-->
		
		</div>
	</table>
</asp:Content>
