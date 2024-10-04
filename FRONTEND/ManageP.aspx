<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="ManageP.aspx.cs" Inherits="FRONTEND.ManageP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>

        
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

        .NameBox {
        position:absolute;
        left : 0;
        margin:auto;
        margin-bottom: 15px;
        display: flex;
        }


        .btnbox {
        position : absolute;
        right : 0;

        }
      
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1> Manage Products</h1>

    <div class="EntityBox"> <div class="anime__details__btn" >
                                <a href="#" class="follow-btn"> Add Product</a>      
                               
                            </div></div>


    <div class="EntityBox">
        <div  class ="NameBox">
            <p> P name </p>
        <p> P attribute 1 </p>
        <p> P attribute 2 </p>
            </div>
        

         <div class="btnbox">
<div class="anime__details__btn" >
                                <a href="#" class="follow-btn"> Remove</a>      
                                <a href="#" class="follow-btn"> Edit</a>      
                            </div>
            </div>
    </div>


     <div class="EntityBox">
        <div  class ="NameBox">
            <p> P name </p>
        <p> P attribute 1 </p>
        <p> P attribute 2 </p>
            </div>
        
        <div class="btnbox">
<div class="anime__details__btn" >
                                <a href="#" class="follow-btn"> Remove</a>      
                                <a href="#" class="follow-btn"> Edit</a>      
                            </div>
            </div>
        
    </div>



     <div class="EntityBox">
        <div  class ="NameBox">
            <p> P name </p>
        <p> P attribute 1 </p>
        <p> P attribute 2 </p>
            </div>
        

          <div class="btnbox">
<div class="anime__details__btn" >
                                <a href="#" class="follow-btn"> Remove</a>      
                                <a href="#" class="follow-btn"> Edit</a>      
                            </div>
            </div>
    </div>



</asp:Content>
