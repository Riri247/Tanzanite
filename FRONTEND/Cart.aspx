<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="FRONTEND.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
  

body {
  font-family: "Inter", sans-serif;
  font-weight: 400;
  line-height: 28px;
  color: #6a6a6a;
  font-size: 14px;
  background-color: #eff2f1; }

a {
  text-decoration: none;
  -webkit-transition: .3s all ease;
  -o-transition: .3s all ease;
  transition: .3s all ease;
  color: #2f2f2f;}
  a:hover {
    color: #2f2f2f;
    text-decoration: none; }
  a.more {
    font-weight: 600; }

  

.btn {
  font-weight: 600;
  padding: 12px 20px;
  border-radius: 20px;
  color: #ffffff;
  background: #2f2f2f;
  border-color: #2f2f2f; }
  .btn:hover {
    color: #ffffff;
    background: #222222;
    border-color: #222222; }
  .btn:active, .btn:focus {
    outline: none !important;
    -webkit-box-shadow: none;
    box-shadow: none; }
  .btn.btn-primary {
    background: #3b5d50;
    border-color: #3b5d50; }
    .btn.btn-primary:hover {
      background: #314d43;
      border-color: #314d43; }
  .btn.btn-secondary {
    color: #2f2f2f;
    background: #f9bf29;
    border-color: #f9bf29; }
    .btn.btn-secondary:hover {
      background: #f8b810;
      border-color: #f8b810; }
  .btn.btn-white-outline {
    background: transparent;
    border-width: 1px;
    border-color: rgba(255, 255, 255, 0.3); }
    .btn.btn-white-outline:hover {
      border-color: white;
      color: #ffffff; }
    </style>

    <!-- Start Hero Section -->
			<div class="hero">
				<div class="container">
					<div class="row justify-content-between">
						<div class="col-lg-5">
							<div class="intro-excerpt">
								<h1>Cart</h1>
							</div>
						</div>
						<div class="col-lg-7">
							
						</div>
					</div>
				</div>
			</div>
		<!-- End Hero Section -->

		

		<div class="untree_co-section before-footer-section">
            <div class="container">
              <div class="row mb-5">
                <form class="col-md-12" method="post" runat="server">
                  <div class="site-blocks-table">
                    <table class="table">
                      <thead>
                        <tr>
                          <th class="product-thumbnail">Image</th>
                          <th class="product-name">Product</th>
                          <th class="product-price">Price</th>
                          <th class="product-quantity">Quantity</th>
                          <th class="product-total">Total</th>
                          <th class="product-remove">Remove</th>
                        </tr>
                      </thead>

                        <!-- Wes idk what this shit is LMFAO so ill add how i did it-->
                        <asp:PlaceHolder ID="divCartStuff" runat="server">

                            </asp:PlaceHolder>
                   <%--   <tbody id="DispCart" runat="server">
                           <!-- Product section start-->
                        
        <!-- end of product-->

                      </tbody>--%>
                    </table>
                  </div>
                </form>
              </div>
        
              <div class="row">
                <div class="col-md-6">
                  <div class="row mb-5">
                  <%--  idk what this will be used for <div class="col-md-6 mb-3 mb-md-0">
                      <button class="btn btn-black btn-sm btn-block">Update Cart</button>
                    </div>--%>
                    <div class="col-md-6">
                      <a class="btn btn-outline-black btn-sm btn-block" href="Home.aspx">Continue Shopping</a>
                    </div>
                  </div>
                  
                </div>
                <div class="col-md-6 pl-5">
                  <div class="row justify-content-end">
                    <div class="col-md-7">
                      <div class="row">
                        <div class="col-md-12 text-right border-bottom mb-5">
                          <h3 class="text-black h4 text-uppercase">Cart Totals</h3>
                        </div>
                      </div>

                      <div class="row mb-5">
                        <div class="col-md-6">
                          <span class="text-black">Total</span>
                        </div>
                        <div class="col-md-6 text-right">
                          <asp:Label ID="lbltotal" class="text-black" runat="server"></asp:Label>
                        </div>
                      </div>

                         <div class="row mb-5">
                        <div class="col-md-6">
                          <span class="text-black">Vat</span>
                        </div>
                        <div class="col-md-6 text-right">
                          <strong class="text-black"> 15%</strong>
                        </div>
                      </div>

                         <div class="row mb-5">
                        <div class="col-md-6">
                          <span class="text-black">coupon Apllied</span>
                        </div>
                       

                             <div class="col-md-6 text-right">
                           <asp:Label ID="lblCperc" class="text-black" runat="server"></asp:Label>
                        </div>
                      </div>
        
                         <div class="row mb-5">
                             <div class="col-md-6">
                         <h2> GRAND TOTAL </h2>
                        </div>
                             <div class="col-md-6">
                          <asp:Label ID="lblGTots" class="text-black" runat="server"></asp:Label>
                        </div>
                         </div>

                      <div class="row">
                        <div class="col-md-12" id="checkoutbtn" runat="server">

                          <a class="btn btn-black btn-lg py-3 btn-block" href="ContactView.aspx" >Proceed To Checkout</a>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
		
</asp:Content>
