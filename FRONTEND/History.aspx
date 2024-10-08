<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="FRONTEND.History" %>
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
        .scroll-contain {
            background-color :  #596e79;
         margin: 20px auto; 
            
             border: 2px solid black;
        	width: 70%;
            border-radius: 15px;
	height: 30% ;
    overflow-y: auto;
        }


        .Scrollable {
   
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

        /* Transparent scrollbar for WebKit browsers (Chrome, Safari, Edge) */
.scroll-contain::-webkit-scrollbar {
    width: 8px; /* Width of the scrollbar */
}

.scroll-contain::-webkit-scrollbar-thumb {
    background: rgba(0, 0, 0, 0.3); /* Color of the scrollbar thumb */
    border-radius: 10px; /* Rounded edges for the thumb */
}

.scroll-contain::-webkit-scrollbar-track {
    background: transparent; /* Background of the scrollbar track */
}

/* Transparent scrollbar for Firefox */
.scroll-contain {
    scrollbar-3dlight-color: rgba(0, 0, 0, 0.3) transparent; /* Use thin scrollbar */
    scrollbar-base-color : rgba(0, 0, 0, 0.3) transparent;
     scrollbar-face-color : rgba(0, 0, 0, 0.3) transparent;
     scrollbar-darkshadow-color : rgba(0, 0, 0, 0.3) transparent;

   /* Thumb color and track color */
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

    
        <!-- Start Hero Section -->
			<div class="hero">
				<div class="container">
					<div class="row justify-content-between">
						<div class="col-lg-5">
							<div class="intro-excerpt">
								<h2> HISTORY</h2>
							</div>
						</div>
						<div class="col-lg-7">
							
						</div>
					</div>
				</div>
			</div>
		<!-- End Hero Section -->

    <div class="scroll-contain" id="divScrool">
         <div class="Scrollable">
        <div  class ="NameBox">
            <p> INvoice NUm </p>
        <p> INvoice Date </p>
   
            </div>
        

         <div class="btnbox">
<div class="anime__details__btn" >
                                <a href="#" class="follow-btn"> View</a>      
                                 
                            </div>
            </div>
    </div>


    
        </div>

   
</asp:Content>
