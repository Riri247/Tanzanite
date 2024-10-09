<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="ContractView.aspx.cs" Inherits="FRONTEND.ContractView" %>
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

               .EntityBox {
             margin: 20px auto; 
             background-color :white;
	width: 70%;
	height: 200px;
	border: 2px solid black;
	align-items: center;
	justify-content: center;
	display: flex;
    letter-spacing: 5px;
	border-radius: 15px;
    position :relative;
}



        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="scroll-contain"> 
        <object data="img/Default Contract.pdf" type="application/pdf" width="100%" height="100%">
            <p>This browser does not support PDFs. Please download the PDF to view it: <a href="path/to/your/document.pdf">Download PDF</a>.</p>
        </object>
        </div>

     <div class="EntityBox"> <div class="anime__details__btn" >
                                <a href="Invoice.aspx?Current=Yes" class="follow-btn"> Agree to Contract terms</a>      
                               
                            </div></div>

</asp:Content>
