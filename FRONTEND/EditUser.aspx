<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="FRONTEND.EditUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style>
         .EntityBox {
              margin: 20px ; 
             left : 0;
             background-color :white;
	width: 350px;
	height: 60px;
	border: 2px solid black;
	align-items: center;
	justify-content: center;
	display: flex;
   
	border-radius: 15px;
    position :relative;
}

      .Pinput{
           position :relative;
      
width: 500px;
	height: 60px;
    border-radius: 15px;
   
        }

        .AttributeCont {
            margin: 20px ; 
        position : relative;
        align-items: center;
	justify-content: center;
        display : flex;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <!-- per attribute this 1-->
     <form id="form1" runat="server">
<div class="AttributeCont"  >
     <div class="EntityBox">
        <h2> Name :</h2>
        </div>

    <input type="text" class="Pinput" placeholder="Enter Value" id="txtName" runat="server">
 
</div>
    <!-- end of that attribute-->


     <!-- per attribute this 1-->
<div class="AttributeCont"  >
     <div class="EntityBox">
        <h2> Surname :</h2>
        </div>

    <input type="text" class="Pinput" placeholder="Enter Value" id="TxtSur" runat="server">
 
</div>
    <!-- end of that attribute-->

     <!-- per attribute this 1-->
<div class="AttributeCont" >
     <div class="EntityBox">
        <h2> Email :</h2>
        </div>

    <input type="text" class="Pinput" placeholder="Enter Value"  id="txtEmail" runat="server">
 
</div>
    <!-- end of that attribute-->

  


       <!-- per attribute this 1-->
<div class="AttributeCont" id="UseType" runat="server" visible="false">
     <div class="EntityBox">
        <h2> Type :</h2>
        </div>

    <input type="text" class="Pinput" placeholder="Enter Value"  id="txtType" runat="server" >
 
</div>
    <!-- end of that attribute-->

   <div id="PassDiv" runat="server">

          <!-- per attribute this 1-->
<div class="AttributeCont" >
     <div class="EntityBox">
        <h2> PassWord :</h2>
        </div>

    <input type="text" class="Pinput" placeholder="Enter Value" id="txtPass" runat="server">
 
</div>
    <!-- end of that attribute-->

<%--         <!-- per attribute this 1-->
<div class="AttributeCont">
     <div class="EntityBox">
        <h2> Confirm Pass :</h2>
        </div>

    <input type="text" class="Pinput" placeholder="Enter Value">
 
</div>
    <!-- end of that attribute-->--%>

    
       </div>

       <!-- BUTTON-->
      
            <div class="AttributeCont">
            <div class="anime__details__btn">
                <asp:Button ID="btnSubmit" runat="server" CssClass="follow-btn" Text="Submit to DB" OnClick="Submit_Click"></asp:Button>


            </div>
           </form>

        </div>
        <!-- end of that-->

</asp:Content>
