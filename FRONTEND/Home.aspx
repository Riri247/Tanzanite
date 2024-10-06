﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FRONTEND.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- Hero Section Begin -->
    <section class="hero">
        <div class="container">
            <div class="hero__slider owl-carousel">
                <div class="hero__items set-bg" data-setbg="img/hero/electronics.png">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="hero__text">
                                <div class="label">Rental</div>
                                <h2>Electronics</h2>
                                <p>Description goes here</p>
                                <a href="ProductList.aspx?Category=Electronics"><span> Load products</span> <i class="fa fa-angle-right"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="hero__items set-bg" data-setbg="img/hero/furniture.jpg">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="hero__text">
                                <div class="label">Rentals</div>
                                <h2>Furniture</h2>
                                <p>Descriptionn</p>
                                <a href="ProductList.aspx?Category=Furniture"><span>Load products</span> <i class="fa fa-angle-right"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="hero__items set-bg" data-setbg="img/hero/acomodations.png">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="hero__text">
                                <div class="label">Rentals</div>
                                <h2>Accomodations</h2>
                                <p>Description</p>
                                <a href="ProductList.aspx?Category=Accomodations"><span>View</span> <i class="fa fa-angle-right"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Hero Section End -->

    <br>

     <!-- Product Section Begin -->
    <section class="product spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-8">
                    <div class="trending__product">
                        <div class="row">
                            <div class="col-lg-8 col-md-8 col-sm-8">
                                <div class="section-title">
                                    <h4>Trending Now</h4>
                                </div>
                            </div>
                            <div class="col-lg-4 col-md-4 col-sm-4">
                                <div class="btn__all">
                                    <a href="#" class="primary-btn">View All <span class="arrow_right"></span></a>
                                </div>
                            </div>
                        </div>
                        <div class="row" id="ProductList" runat="server">
                        <!-- dynamically allocated here-->

                           
                           
                            
                           
                        </div>
                    </div>
                
                  
                
                </div>
                <div class="col-lg-4 col-md-6 col-sm-8">
                    <div class="product__sidebar">
                    
                        <div class="product__sidebar__comment" id="Sidebarcontent" runat="server"> <!-- take code form here-->
       
                            
                            <div class="section-title">
            <h5>New Comment</h5>
        </div>
                            <!-- side bar procust start end-->
        <div class="product__sidebar__comment__item">
            <div class="product__sidebar__comment__item__pic">
                <img src="img/sidebar/comment-1.jpg" alt="">
            </div>
            <div class="product__sidebar__comment__item__text">
                <ul>
                    <li>Active</li>
                    <li>Movie</li>
                </ul>
                <h5><a href="#">The Seven Deadly Sins: Wrath of the Gods</a></h5>
                <span><i class="fa fa-eye"></i> 19.141 Viewes</span>
            </div>
        </div>
                            <!-- side bar procust end-->
      
   
                            </div>
                        <!-- see end-->
</div>
</div>
</div>
</div>
</section>
<!-- Product Section End -->


</asp:Content>
