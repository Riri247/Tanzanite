<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FRONTEND.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Banner Section Begin -->
    <section class="banner">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner__pic">
                        <img src="img/banner/banner-1.jpg" alt="">
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Banner Section End -->

    <!-- Products Section Begin -->
    <section class="products spad">
        <div class="container">
            <div class="row" id="productList">
                <!-- Products will be dynamically populated here -->
                <asp:Repeater ID="rptProducts" runat="server">
                    <ItemTemplate>
                        <div class="col-lg-4 col-md-6 col-sm-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg">
                                    <img src='<%# Eval("ImageUrl") %>' alt='<%# Eval("Description") %>' class="product__item__pic__hover"/>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#"> <%# Eval("Description") %> </a></h6>
                                    <h5>$<%# Eval("Price", "{0:F2}") %></h5>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </section>
    <!-- Products Section End -->

</asp:Content>
