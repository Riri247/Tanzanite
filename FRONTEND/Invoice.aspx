<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="Invoice.aspx.cs" Inherits="FRONTEND.Invoice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        body {
    font-family: Arial, sans-serif;
    margin: 20px;
}

 .scroll-contain {
            background-color :  #596e79;
         margin: 20px auto; 
            
             border: 2px solid black;
        	width: 70%;
            border-radius: 15px;
	height: 60% ;
        }

        object {
            border-radius: 15px;

        }



        </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="scroll-contain">

        <object data="img/INDIVIDUAL ASSIGNMENT 2 HE ASHIMWE 222127212.pdf" type="application/pdf" width="100%" height="100%">
            <p>This browser does not support PDFs. Please download the PDF to view it: <a href="path/to/your/document.pdf">Download PDF</a>.</p>
        </object>
        </div>


    
    

</asp:Content>
