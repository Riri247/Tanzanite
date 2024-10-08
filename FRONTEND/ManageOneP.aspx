﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="ManageOneP.aspx.cs" Inherits="FRONTEND.ManageOneP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .EntityBox {
            margin: 20px;
            left: 0;
            background-color: white;
            width: 350px;
            height: 60px;
            border: 2px solid black;
            align-items: center;
            justify-content: center;
            display: flex;
            border-radius: 15px;
            position: relative;
        }

            .EntityBox h2 {
                text-wrap: none;
                height: 109px;
            }

        .Pinput {
            position: relative;
            width: 500px;
            height: 60px;
            border-radius: 15px;
        }

        .AttributeCont {
            margin: 20px;
            position: relative;
            align-items: center;
            justify-content: center;
            display: flex;
            height: 127px;
            top: 0px;
            left: 0px;
        }

        .response {
            width: 100%;
            text-align: center !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <!-- per attribute this 1-->
        <div class="AttributeCont">
            <div class="EntityBox">
                <h3>Name :</h3>
            </div>

            <input type="text" id="name" runat="server" class="Pinput" placeholder="Enter Value">
        </div>
        <!-- end of that attribute-->

        <!-- per attribute this 1-->
        <div class="AttributeCont">
            <div class="EntityBox">
                <h3>Description :</h3>
            </div>
            <textarea id="description" runat="server" class="Pinput" placeholder="Enter Value" rows="10" cols="50"></textarea>

        </div>
        <!-- end of that attribute-->

        <!-- per attribute this 1-->
        <div class="AttributeCont">
            <div class="EntityBox">
                <h3>Category :</h3>
            </div>

            <input type="text" id="category" runat="server" class="Pinput" placeholder="Enter Value">
        </div>
        <!-- end of that attribute-->


        <!-- per attribute this 1-->
        <div class="AttributeCont">
            <div class="EntityBox">
                <h3>Price :</h3>
            </div>

            <input type="text" id="price" runat="server" class="Pinput" placeholder="Enter Value" >
        </div>
        <!-- end of that attribute-->

        <!-- per attribute this 1-->
        <div class="AttributeCont">
            <div class="EntityBox">
                <h3>Quantity :</h3>
            </div>

            <input type="text" id="quantity" runat="server" class="Pinput" placeholder="Enter Value" step="1" min="0">
        </div>
        <!-- end of that attribute-->

        <!-- per attribute this 1-->
        <div class="AttributeCont">
            <div class="EntityBox">
                <h3>Available :</h3>
            </div>

            <input type="checkbox" id="available" runat="server" class="Pinput" placeholder="Enter Value">
        </div>
        <!-- end of that attribute-->

        <!-- per attribute this 1-->
        <div class="AttributeCont">
            <div class="EntityBox">
                <h4>Rental Aggreement:</h4>
            </div  >

            <textarea id="agreement" runat="server"  class="Pinput"  placeholder="Enter Value" rows="10" cols="50"></textarea>
        </div>
        <!-- end of that attribute-->




        <!-- per attribute this 1-->
        <div class="AttributeCont">
            <div class="EntityBox">
                <h3>Images :</h3>
            </div>

            <asp:Panel ID="image_url_holder" runat="server">
                <asp:TextBox ID="image1" runat="server" CssClass="Pinput" PlaceHolder="Enter Value1" />

            </asp:Panel>


        </div>

        <div class="AttributeCont">
            <div class="anime__details__btn">
                <asp:Button ID="btnAddInput" runat="server" CssClass="follow-btn" Text="Add Image URL" OnClick="addInput_Click"></asp:Button>

            </div>

        </div>

        <asp:Label ID="response" runat="server" CssClass="response"></asp:Label>

        <!-- end of that attribute-->

        <!-- BUTTON-->
        <div class="AttributeCont">
            <div class="anime__details__btn">
                <asp:Button ID="btnSubmit" runat="server" CssClass="follow-btn" Text="Submit to DB" OnClick="Submit_Click"></asp:Button>


            </div>

        </div>
        <!-- end of that-->
    </form>
</asp:Content>
