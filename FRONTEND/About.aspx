<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="FRONTEND.About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    
    <!-- Start Hero Section -->
			<div class="hero">
				<div class="container">
					<div class="row justify-content-between">
						<div class="col-lg-5">
							<div class="intro-excerpt">
								<h2> DESCRIPTION</h2>
							</div>
						</div>
						<div class="col-lg-7">
							
						</div>
					</div>
				</div>
			</div>
		<!-- End Hero Section -->
       <!-- Anime Section Begin -->
    <section class="anime-details spad">
        <div class="container">

                  <!-- Hero Section Begin -->
    <section class="hero">
        <div class="container">
            <div class="hero__slider owl-carousel" id="Descriptiondiv" runat="server">

                <!-- Different image same words-->
                <!-- Commented out incase we may need it again-->
                <!-- Code to repeat back end start--->
               <div class="hero__items set-bg" data-setbg="img/hero/electronics.png"> <!-- Change image directory per loop-->
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="hero__text">
                                <div class="label">Rental</div> <!-- product type-->
                                <h2>Electronics</h2> <!-- Product name-->
                                <p>Description goes here</p> <!--- Description-->
                                <a href="ProductList.aspx?Category=Electronics"><span> Review</span> <i class="fa fa-angle-right"></i></a> <!-- Review button must only be seen  when the user has bought it before-->
                            </div>
                        </div>
                    </div>
                </div>
                 <!-- Code to repeat back end END--->
             
                <div style="background-image : url">

            </div>
        </div>
    </section>

            <div class="row" id="Descpdiv" runat="server">

                </div>
    <!-- Hero Section End -->

        

            <div class="row">
                     <div class="col-lg-8 col-md-8">
                                 <div class="section-title"> <!-- always start with this-->
                                <h5>Reviews</h5>
                            </div> <!-- Copy the whole thing-->
                        <div class="anime__details__review" id="divReviews" runat="server">
                    
                         <p> NO CREVIEWS </p>
                          
                        </div>

                         <%--add your own--%>
                        <div class="anime__details__form" id="divLeavReview" visible="false" runat="server">
                            <div class="section-title">
                                <h5>Your Comment</h5>
                            </div>
                            <form action="#">
                                <textarea placeholder="Your Comment"></textarea>
                                <button type="submit"><i class="fa fa-location-arrow"></i> Review</button>
                            </form>
                        </div>
                    </div>
                </div>
                    </div>


              
        </section>

        <!-- Anime Section End -->
</asp:Content>
