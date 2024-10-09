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

                            <div class="add-to-cart">
                               <a href="Cart.aspx?prodID=<%Request.QueryString["ID"].ToString();%>" class="add-to-cart-btn">
    <span><i class="fa fa-shopping-cart"></i> Add to cart</span> 
    <i class="fa fa-angle-right"></i>
</a>
                            </div>

                            <ul class="product-btns">
                                <asp:DropDownList ID="ddlQuantity" runat="server" EnableViewState="true">
                                    <asp:ListItem Value="1">1</asp:ListItem>
                                    <asp:ListItem Value="2">2</asp:ListItem>
                                    <asp:ListItem Value="3">3</asp:ListItem>
                                    <asp:ListItem Value="4">4</asp:ListItem>
                                    <asp:ListItem Value="5">5</asp:ListItem>
                                    <asp:ListItem Value="6">6</asp:ListItem>
                                    <asp:ListItem Value="7">7</asp:ListItem>
                                    <asp:ListItem Value="8">8</asp:ListItem>
                                    <asp:ListItem Value="9">9</asp:ListItem>
                                </asp:DropDownList>
                            </ul>
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

                                    <!-- Reviews -->
                                    <div class="col-md-6">
                                        <div id="reviews">
                                            <ul class="reviews">
                                                <li>
                                                    <div class="review-body">
                                                        <p><Asp:Label ID="lblName" runat="server" /></p>
                                                        <p>Rating:<Asp:Label ID="lblTheRate" runat="server" /></p>
                                                    </div>
                                                 </li>

                                            </ul>
                                        </div>
                                    </div>
                                    <!-- /Reviews -->

                                    <!-- Review Form -->
                                    <div class="col-md-3">
                                        <div id="review-form">
                                            <div class="review-form">
                                                <asp:TextBox class="input" placeholder="Your Review" TextMode="MultiLine" runat="server" ID="txtRev"></asp:TextBox>
                                                <div class="input-rating">
                                                    <span>Your Rating: </span>
                                                    <asp:Textbox CSSclass="input" ID ="txtRate" placeholder="rate product here" runat="server" TextMode="Number"></asp:Textbox>
                                                </div>
                                                <asp:button CSSclass="primary-btn" ID="btnSubmit" OnClick="BtnSubmit_Click" runat="server" Text="Submit"></asp:button>
                                            </div>
                                            
                                        </div>
                                    </div>
                                    <!-- /Review Form -->
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
