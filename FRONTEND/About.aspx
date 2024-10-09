<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="FRONTEND.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="SomeForm" runat="server">
        <!-- SECTION -->
        <div class="section">
            <!-- container -->
            <div class="container">
                <!-- row -->
                <div class="row">
                    <!-- Product main img -->
                    <div class="col-md-5 col-md-push-2">
                        <div id="product-main-img">
                            <div class="product-preview">
                                <asp:Literal ID="ImageLit" runat="server" />
                            </div>
                        </div>
                    </div>
                    <!-- /Product main img -->
                    <!-- Product thumb imgs -->
                    <div class="col-md-2  col-md-pull-5">
                    </div>
                    <!-- /Product thumb imgs -->
                    <!-- Product details -->

                    <div class="col-md-5">
                        <div class="product-details">
                            <h2 class="product-name">
                                <asp:Literal ID="ProdName" runat="server" />
                            </h2>
                            <div>
                                <h3 style="color: red">
                                    <asp:Literal ID="LitPrice" runat="server" /></h3>
                                <span class="product-available">In Stock</span>
                            </div>

                            <div class="add-to-cart" id="btnCart" runat="server">
                                <a id="cart_adder" runat="server" class="add-to-cart-btn">
                                    <span><i class="fa fa-shopping-cart"></i>Add to cart</span>
                                    <i class="fa fa-angle-right"></i>
                                </a>
                            </div>

                        </div>
                    </div>
                </div>
                <!-- /Product details -->
                <!-- Product tab -->
                <div class="col-md-12">
                    <div id="product-tab">
                        <!-- product tab nav -->
                        <ul class="tab-nav">
                            <li class="active"><a data-toggle="tab" href="#tab1">Description</a></li>
                            <li><a data-toggle="tab" href="#tab3">Reviews</a></li>
                        </ul>
                        <!-- /product tab nav -->

                        <!-- product tab content -->
                        <div class="tab-content">
                            <!-- tab1  -->
                            <div id="tab1" class="tab-pane fade in active">
                                <div class="row">
                                    <div class="col-md-12">
                                        <pre> <asp:Literal ID="LitDescription" runat="server" /></pre>
                                    </div>
                                </div>
                            </div>
                            <!-- /tab1  -->

                            <!-- tab3  -->
                            <div id="tab3" class="tab-pane fade in">
                                <div class="row">

                                    <div class="col-lg-8 col-md-8">
                                        <div class="anime__details__review">
                                            <div class="section-title">
                                                <h5>Reviews</h5>
                                            </div>

                                            <div id="rev_cont" runat="server">
                                                
                                            </div>
                                            
                                           

                                        </div>

                                        <div class="anime__details__form" id="your_rating_container" runat="server">
                                            <div class="section-title">
                                                <h5>Your Comment</h5>
                                            </div>
                                            <form action="#">
                                                <textarea placeholder="Your Comment" runat="server" id="txtReview"></textarea>

                                                <div class="input-rating">
                                                    <span>Your Rating: </span>
                                                    <asp:TextBox CssClass="input" ID="txtRate" placeholder="rate product here" runat="server" TextMode="Number"></asp:TextBox>
                                                </div>

                                                <asp:Button CssClass="primary-btn" ID="btnSubmit" OnClick="BtnSubmit_Click" runat="server" Text="Submit"></asp:Button>

                                            </form>
                                        </div>
                                    </div>




                                </div>
                            </div>
                            <!-- /tab3  -->
                        </div>
                        <!-- /product tab content  -->
                    </div>
                </div>
                <!-- /product tab -->

                <!-- /row -->
            </div>
            <!-- /container -->
        </div>
    </form>
    <!-- /Section -->





    <!-- Anime Section End -->
</asp:Content>
