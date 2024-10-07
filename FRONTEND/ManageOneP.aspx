<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="ManageOneP.aspx.cs" Inherits="FRONTEND.ManageOneP" %>

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
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- per attribute this 1-->
    <div class="AttributeCont">
        <div class="EntityBox">
            <h2>Name :</h2>
        </div>

        <input type="text" class="Pinput" placeholder="Enter Value">
    </div>
    <!-- end of that attribute-->

    <!-- per attribute this 1-->
    <div class="AttributeCont">
        <div class="EntityBox">
            <h2>Description :</h2>
        </div>

        <input type="text" class="Pinput" placeholder="Enter Value">
    </div>
    <!-- end of that attribute-->

    <!-- per attribute this 1-->
    <div class="AttributeCont">
        <div class="EntityBox">
            <h2>Price :</h2>
        </div>

        <input type="text" class="Pinput" placeholder="Enter Value">
    </div>
    <!-- end of that attribute-->

    <!-- per attribute this 1-->
    <div class="AttributeCont">
        <div class="EntityBox">
            <h2>Attribute N :</h2>
        </div>

        <input type="text" class="Pinput" placeholder="Enter Value">
    </div>
    <!-- end of that attribute-->

    <!-- BUTTON-->
    <div class="AttributeCont">
        <div class="anime__details__btn">
            <a href="#" class="follow-btn">Submit to DB</a>

        </div>

    </div>
    <!-- end of that-->
</asp:Content>
