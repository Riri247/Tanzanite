﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="FRONTEND.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        body {
  overflow-x: hidden;
  position: relative; }

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
  color: #2f2f2f;
  text-decoration: underline; }
  a:hover {
    color: #2f2f2f;
    text-decoration: none; }
  a.more {
    font-weight: 600; }

  .hero {
  background: #3b5d50;
  padding: calc(4rem - 30px) 0 0rem 0; }
  @media (min-width: 768px) {
    .hero {
      padding: calc(4rem - 30px) 0 4rem 0; } }
  @media (min-width: 992px) {
    .hero {
      padding: calc(8rem - 30px) 0 8rem 0; } }
  .hero .intro-excerpt {
    position: relative;
    z-index: 4; }
    @media (min-width: 992px) {
      .hero .intro-excerpt {
        max-width: 450px; } }
  .hero h1 {
    font-weight: 700;
    color: #ffffff;
    margin-bottom: 30px; }
    @media (min-width: 1400px) {
      .hero h1 {
        font-size: 54px; } }
  .hero p {
    color: rgba(255, 255, 255, 0.5);
    margin-botom: 30px; }
  .hero .hero-img-wrap {
    position: relative; }
    .hero .hero-img-wrap img {
      position: relative;
      top: 0px;
      right: 0px;
      z-index: 2;
      max-width: 780px;
      left: -20px; }
      @media (min-width: 768px) {
        .hero .hero-img-wrap img {
          right: 0px;
          left: -100px; } }
      @media (min-width: 992px) {
        .hero .hero-img-wrap img {
          left: 0px;
          top: -80px;
          position: absolute;
          right: -50px; } }
      @media (min-width: 1200px) {
        .hero .hero-img-wrap img {
          left: 0px;
          top: -80px;
          right: -100px; } }
    .hero .hero-img-wrap:after {
      content: "";
      position: absolute;
      width: 255px;
      height: 217px;
      background-image: url("../images/dots-light.svg");
      background-size: contain;
      background-repeat: no-repeat;
      right: -100px;
      top: -0px; }
      @media (min-width: 1200px) {
        .hero .hero-img-wrap:after {
          top: -40px; } }

.btn {
  font-weight: 600;
  padding: 12px 30px;
  border-radius: 30px;
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
    border-width: 2px;
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
                <form class="col-md-12" method="post">
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
                      <tbody>
                        <tr>
                          <td class="product-thumbnail">
                            <img src="hero-1.jpg" alt="Image" class="img-fluid"  style="width: 300px; height: 200px;">
                          </td>
                          <td class="product-name">
                            <h2 class="h5 text-black">Product 1</h2>
                          </td>
                          <td>$49.00</td>
                          <td>
                            <div class="input-group mb-3 d-flex align-items-center quantity-container" style="max-width: 120px;">
                              <div class="input-group-prepend">
                                <button class="btn btn-outline-black decrease" type="button">&minus;</button>
                              </div>
                              <input type="text" class="form-control text-center quantity-amount" value="1" placeholder="" aria-label="Example text with button addon" aria-describedby="button-addon1">
                              <div class="input-group-append">
                                <button class="btn btn-outline-black increase" type="button">&plus;</button>
                              </div>
                            </div>
        
                          </td>
                          <td>$49.00</td>
                          <td><a href="#" class="btn btn-black btn-sm">X</a></td>
                        </tr>
        
                        <tr>
                          <td class="product-thumbnail">
                            <img src="hero-1.jpg" alt="Image" class="img-fluid"  style="width: 300px; height: 200px;">
                          </td>
                          <td class="product-name">
                            <h2 class="h5 text-black">Product 2</h2>
                          </td>
                          <td>$49.00</td>
                          <td>
                            <div class="input-group mb-3 d-flex align-items-center quantity-container" style="max-width: 120px;">
                              <div class="input-group-prepend">
                                <button class="btn btn-outline-black decrease" type="button">&minus;</button>
                              </div>
                              <input type="text" class="form-control text-center quantity-amount" value="1" placeholder="" aria-label="Example text with button addon" aria-describedby="button-addon1">
                              <div class="input-group-append">
                                <button class="btn btn-outline-black increase" type="button">&plus;</button>
                              </div>
                            </div>
        
                          </td>
                          <td>$49.00</td>
                          <td><a href="#" class="btn btn-black btn-sm">X</a></td>
                        </tr>
                      </tbody>
                    </table>
                  </div>
                </form>
              </div>
        
              <div class="row">
                <div class="col-md-6">
                  <div class="row mb-5">
                    <div class="col-md-6 mb-3 mb-md-0">
                      <button class="btn btn-black btn-sm btn-block">Update Cart</button>
                    </div>
                    <div class="col-md-6">
                      <button class="btn btn-outline-black btn-sm btn-block">Continue Shopping</button>
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
                      <div class="row mb-3">
                        <div class="col-md-6">
                          <span class="text-black">Subtotal</span>
                        </div>
                        <div class="col-md-6 text-right">
                          <strong class="text-black">$230.00</strong>
                        </div>
                      </div>
                      <div class="row mb-5">
                        <div class="col-md-6">
                          <span class="text-black">Total</span>
                        </div>
                        <div class="col-md-6 text-right">
                          <strong class="text-black">$230.00</strong>
                        </div>
                      </div>
        
                      <div class="row">
                        <div class="col-md-12">
                          <button class="btn btn-black btn-lg py-3 btn-block" onclick="window.location='checkout.html'">Proceed To Checkout</button>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
		
</asp:Content>
