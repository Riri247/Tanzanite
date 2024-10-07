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

        .EntityBox h2{
            text-wrap:none;

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

        .response{
            width:100%;

        }


    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- per attribute this 1-->
    <div class="AttributeCont">
        <div class="EntityBox">
            <h2>Name :</h2>
        </div>

        <input type="text" id="name" runat="server" class="Pinput" placeholder="Enter Value">
    </div>
    <!-- end of that attribute-->

    <!-- per attribute this 1-->
    <div class="AttributeCont">
        <div class="EntityBox">
            <h2>Description :</h2>
        </div>
        <textarea id="description" runat="server" class="Pinput" placeholder="Enter Value" rows="10" cols="50">Enter Value</textarea>

    </div>
    <!-- end of that attribute-->

    <!-- per attribute this 1-->
    <div class="AttributeCont">
        <div class="EntityBox">
            <h2>Category :</h2>
        </div>

        <input type="text" id="category" runat="server" class="Pinput" placeholder="Enter Value">
    </div>
    <!-- end of that attribute-->


    <!-- per attribute this 1-->
    <div class="AttributeCont">
        <div class="EntityBox">
            <h2>Price :</h2>
        </div>

        <input type="number" id="price" runat="server" class="Pinput" placeholder="Enter Value" step="0.01" min="0">
    </div>
    <!-- end of that attribute-->

    <!-- per attribute this 1-->
    <div class="AttributeCont">
        <div class="EntityBox">
            <h2>Quantity :</h2>
        </div>

        <input type="number" id="quantity" runat="server" class="Pinput" placeholder="Enter Value" step="1" min="0">
    </div>
    <!-- end of that attribute-->
    
    <!-- per attribute this 1-->
    <div class="AttributeCont">
        <div class="EntityBox">
            <h2>Available :</h2>
        </div>

        <input type="checkbox" id="available" runat="server" class="Pinput" placeholder="Enter Value">
    </div>
    <!-- end of that attribute-->

    <!-- per attribute this 1-->
    <div class="AttributeCont">
        <div class="EntityBox">
            <h2>Rental Aggreement:</h2>
        </div>

        <textarea id="agreement" runat="server" class="Pinput" placeholder="Enter Value" rows="10" cols="50">Enter Value</textarea>
    </div>
    <!-- end of that attribute-->
    



    <!-- per attribute this 1-->
    <div class="AttributeCont">
        <div class="EntityBox">
            <h2>Images :</h2>
        </div>

        <asp:PlaceHolder ID="image_url_holder" runat="server">
            <asp:TextBox ID="image1" runat="server" CssClass="Pinput" PlaceHolder="Enter Value" />

        </asp:PlaceHolder>

        <div class="AttributeCont">
            <div class="anime__details__btn">
                <asp:Button ID="addInput" runat="server" CssClass="follow-btn" Text="Add Image URL" OnClick="addInput_Click"></asp:Button>

            </div>

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
</asp:Content>
