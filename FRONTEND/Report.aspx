<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="FRONTEND.Report" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        body {
            position: relative;
            align-items: center;
            justify-content: center;
        }


        .topBox {
            right: 0;
            margin: 20px auto;
            background-color: white;
            width: 10%;
            height: 10%;
            border: 2px solid black;
            flex-direction: column; /* Stack children vertically */
            align-items: center;
            justify-content: center;
            display: inline-block;
            letter-spacing: 5px;
            border-radius: 5px;
            position: relative;
        }

        .EntityBox {
            margin: 20px auto;
            background-color: white;
            width: 70%;
            height: 300px;
            border: 2px solid black;
            flex-direction: column; /* Stack children vertically */
            align-items: center;
            justify-content: center;
            display: flex;
            letter-spacing: 5px;
            border-radius: 15px;
            position: relative;
        }

        .ReprtBlock {
            display: flex;
            position: relative;
            width: 60%;
            height: 30%;
        }

        #btnCOnt, #btnCOnt1, #btnCOnt2, #btnCOnt3, #btnCOnt4 {
            position: absolute;
            right: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="scroll-contain">



        <iframe title="TanzaiteD Report" width="1140" height="541.25" src="https://app.powerbi.com/reportEmbed?reportId=eaa65ea1-1e08-4e9c-b315-38825af2e59c&autoAuth=true&ctid=d8bf7c18-5725-4b9e-b118-13388f52e44e" frameborder="0" allowfullscreen="true"></iframe>


    </div>

</asp:Content>
