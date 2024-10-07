<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="FRONTEND.Report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        body {

        position :relative;
        align-items: center;
	justify-content: center;
        }


        .topBox {
            right : 0;
           margin: 20px auto; 
             background-color :white;
	width: 10%;
	height: 10%;
	border: 2px solid black;
    flex-direction: column; /* Stack children vertically */
	align-items: center;
	justify-content: center;
	display: inline-block;
    letter-spacing: 5px;
	border-radius: 5px;
    position :relative;
        
        }

        .EntityBox {
             margin: 20px auto; 
             background-color :white;
	width: 70%;
	height: 300px;
	border: 2px solid black;
    flex-direction: column; /* Stack children vertically */
	align-items: center;
	justify-content: center;
	display: flex;
    letter-spacing: 5px;
	border-radius: 15px;
    position :relative;
}

        .ReprtBlock {
           display : flex;
           position : relative;
        width:60%;
        height : 30%;
        
        }

        #btnCOnt,#btnCOnt1,#btnCOnt2,#btnCOnt3,#btnCOnt4 {
        position : absolute;
        right : 0;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


   
   <!-- <div class="topBox">  

        <div class="ReprtBlock"  style="border-bottom-style: solid;"> FIlter  </div>
     <div class="ReprtBlock"  style="border-bottom-style: solid;"> OPtion 1 </div>
     <div class="ReprtBlock"  style="border-bottom-style: solid;"> OPtion 1 </div>
    </div>
   -->
      <div class="EntityBox"> 
    <h1> REPORTS      </h1>    
          <div id="btnCOnt4">
           <nav class="header__menu mobile-menu" >
                            <ul>

                               
									<!-- Commented out code for the blank current page changge to be default
										 <li class="active">
										 </li>
									<a href="#"> <asp:label ID="Currentlabel" runat="server"/></a>
									-->
                               

								<!-- default nav -->
								<div class="default__nav" style="float:left;">
									 <li class="active"><a href="#">Filter <span class="arrow_carrot-down"></span></a>
                                    <ul class="dropdown">
                                        <!--default ones pages-->
                                           <li><a href="Signup.aspx" runat="server" id="SignID" >Sign Up</a></li>
                                        <li><a href="Login.aspx" runat="server" id="LoginID" >Login</a></li>
                                        <!--Remeber to add about us page-->
                                        <li><a href="#" runat="server" id="ABoutOne" >About us</a></li>

                                        <!--login ones=-->
                                        <!-- Account management page-->
                                            <li><a href="#" runat="server" id="AccountOne"  visible="false">Account</a></li>
                                            <li><a href="Cart.aspx" runat="server" id="CartOne" visible="false" >Check Cart</a></li>

                                        <!--Renter one-->
                                         <li><a href="Cart.aspx" runat="server" id="ProductOne" visible="false" >Check Products</a></li>

                                        <!-- Admin-->
                                        <!-- SUers page-->
                                        <li><a href="Cart.aspx" runat="server" id="UserOne" visible="false" >Track User</a></li>

                                        
                                       
                                        
                                    </ul>

                                         <!-- Default nav>
                                         
                                             <li class= "Register__block" ><a href="Signup.aspx"><asp:label ID="Label4" runat="server" Text="Register" visible="false" /></a></li>
                                             <li class= "Login__block" ><a href="Login.aspx"><asp:label ID="Login" runat="server" Text="Login"/></a></li>               
                                        
	                                     <-->
                                         
										<!-- place search icon here -->
								</div>
	
                               <!-- Commented out for about us>
								<li><a href="#">About us</a></li>
								<-->
                            </ul>
							
                        </nav>
        </div>
    </div>
    
    <div class="EntityBox"> 
        <div class="ReprtBlock"  style="border-bottom-style: solid;"> Value 1  <div class="anime__details__btn"  id="btnCOnt">
                                <a href="#" class="follow-btn"> Inpect</a>      
                                   
                            </div></div>
         <div class="ReprtBlock" style="border-bottom-style: solid;"> Value 1  
               <div class="anime__details__btn"  id="btnCOnt1">
                                <a href="#" class="follow-btn"> Inpect</a>      
                                   
                            </div>
         </div>
         <div class="ReprtBlock" style="border-bottom-style: solid;"> Value 1 
            <div class="anime__details__btn"  id="btnCOnt2">
                                <a href="#" class="follow-btn"> Inpect</a>      
                                   
                            </div>
         </div>
         <div class="ReprtBlock"> Value 1   <div class="anime__details__btn"  id="btnCOnt3">
                                <a href="#" class="follow-btn"> Inpect</a>      
                                   
                            </div> </div>
    </div>

</asp:Content>
