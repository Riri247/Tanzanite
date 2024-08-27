<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FRONTEND.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
/*--------------------
  Hero
----------------------*/
  .hero {
	padding-top: 50px;
	position: relative;
    width: 100%;
    overflow: hidden;
}

.hero__items {
	padding: 250px 0 42px 50px;
	border-radius: 5px;
	min-width: 100%;
    box-sizing: border-box;
}

.hero__items {
    background-image: url('hero-1.jpg'); /* Path to your background image */
    background-size: cover; /* Cover the entire div */
    background-position: center; /* Center the background image */
    background-repeat: no-repeat; /* Do not repeat the image */
    width: 100%; /* Full width of the container */
    height: 500px; /* Set a height or adjust as needed */
    position: relative; /* To position child elements correctly */
}

.hero__text {
	position: relative;
	z-index: 9;
}

.hero__text .label {
	font-size: 13px;
	color: #e53637;
	background: #ffffff;
	padding: 5px 14px 3px;
	display: inline-block;
	position: relative;
	top: -100px;

	-webkit-transition: all, 0.2s;
	-o-transition: all, 0.2s;
	transition: all, 0.2s;
}

.hero__text h2 {
	color: #ffffff;
	font-size: 42px;
	font-family: "Oswald", sans-serif;
	font-weight: 700;
	line-height: 52px;
	margin-top: 35px;
	margin-bottom: 8px;
	position: relative;
	top: -100px;
	-webkit-transition: all, 0.4s;
	-o-transition: all, 0.4s;
	transition: all, 0.4s;
}

.hero__text p {
	color: #ffffff;
	font-size: 16px;
	margin-bottom: 40px;
	position: relative;
	top: -100px;
	-webkit-transition: all, 0.6s;
	-o-transition: all, 0.6s;
	transition: all, 0.6s;
}

.hero__text a {
	position: relative;
	top: -100px;
	-webkit-transition: all, 0.8s;
	-o-transition: all, 0.8s;
	transition: all, 0.8s;
}

.hero__text a span {
	font-size: 13px;
	color: #ffffff;
	background: #e53637;
	display: inline-block;
	font-weight: 700;
	letter-spacing: 2px;
	text-transform: uppercase;
	padding: 14px 20px;
	border-radius: 4px 0 0 4px;
	margin-right: 1px;
}

.hero__text a i {
	font-size: 20px;
	display: inline-block;
	background: #e53637;
	padding: 11px 5px 16px 8px;
	color: #ffffff;
	border-radius: 0 4px 4px 0;
}

    	.hero__slider {
			 display: flex;
    transition: transform 0.5s ease;
    	}

        #slide1:checked ~ .hero__slider {
    transform: translateX(0%);
}

#slide2:checked ~ .hero__slider {
    transform: translateX(-100%);
}

#slide3:checked ~ .hero__slider {
    transform: translateX(-200%);
}

input[type="radio"] {
    display: none;
}

.controls {
    position: absolute;
    bottom: 10px;
    width: 100%;
    text-align: center;
}

.control {
    display: inline-block;
    width: 10px;
    height: 10px;
    margin: 0 5px;
    background-color: white;
    border-radius: 50%;
    cursor: pointer;
    transition: background-color 0.3s;
}

input[type="radio"]:checked + .control {
    background-color: gray;
}




.product-section {
  padding: 7rem 0; }
  .product-section .product-item {
    text-align: center;
    text-decoration: none;
    display: block;
    position: relative;
    padding-bottom: 50px;
    cursor: pointer; }
    .product-section .product-item .product-thumbnail {
      margin-bottom: 30px;
      position: relative;
      top: 0;
      -webkit-transition: .3s all ease;
      -o-transition: .3s all ease;
      transition: .3s all ease; }
    .product-section .product-item h3 {
      font-weight: 600;
      font-size: 16px; }
    .product-section .product-item strong {
      font-weight: 800 !important;
      font-size: 18px !important; }
    .product-section .product-item h3, .product-section .product-item strong {
      color: #2f2f2f;
      text-decoration: none; }
    .product-section .product-item .icon-cross {
      position: absolute;
      width: 35px;
      height: 35px;
      display: inline-block;
      background: #2f2f2f;
      bottom: 15px;
      left: 50%;
      -webkit-transform: translateX(-50%);
      -ms-transform: translateX(-50%);
      transform: translateX(-50%);
      margin-bottom: -17.5px;
      border-radius: 50%;
      opacity: 0;
      visibility: hidden;
      -webkit-transition: .3s all ease;
      -o-transition: .3s all ease;
      transition: .3s all ease; }
      .product-section .product-item .icon-cross img {
        position: absolute;
        left: 50%;
        top: 50%;
        -webkit-transform: translate(-50%, -50%);
        -ms-transform: translate(-50%, -50%);
        transform: translate(-50%, -50%); }
    .product-section .product-item:before {
      bottom: 0;
      left: 0;
      right: 0;
      position: absolute;
      content: "";
      background: #dce5e4;
      height: 0%;
      z-index: -1;
      border-radius: 10px;
      -webkit-transition: .3s all ease;
      -o-transition: .3s all ease;
      transition: .3s all ease; }
    .product-section .product-item:hover .product-thumbnail {
      top: -25px; }
    .product-section .product-item:hover .icon-cross {
      bottom: 0;
      opacity: 1;
      visibility: visible; }
    .product-section .product-item:hover:before {
      height: 70%; }
    </style>


    <!-- Hero Section Begin -->
    <div class="hero">

		<input type="radio" name="hero" id="slide1" checked>
        <input type="radio" name="hero" id="slide2">
        <input type="radio" name="hero" id="slide3">
     
        
            <div class="hero__slider">
                <div class="hero__items" style="background-image:url(hero-1.jpg)">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="hero__text">
                                <div class="label">Rentals</div>
                                <h2>Acomodations</h2>
                                <p>T1</p>
                                <a href="#"><span>Explore</span> <i class="fa fa-angle-right"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="hero__items" style="background-image:url(hero-1.jpg)">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="hero__text">
                                <div class="label">Rentals</div>
                                <h2>Electronics</h2>
                               <p>T2</p>
                                <a href="#"><span>Explore</span> <i class="fa fa-angle-right"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="hero__items" style="background-image:url(hero-1.jpg)">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="hero__text">
                                <div class="label">Rentals</div>
                                <h2>Furniture</h2>
                              <p>T3</p>
                                <a href="#"><span>Explore</span> <i class="fa fa-angle-right"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="controls">
            <label for="slide1" class="control"></label>
            <label for="slide2" class="control"></label>
            <label for="slide3" class="control"></label>
        </div>
     
        
        </div>
    
    <!-- Hero Section End -->
    <br>

   
    
<!-- Start Product Section -->
		<div class="product-section">
			<div class="container">
				<div class="row">

					<!-- Start Column 1 -->
					<div class="col-md-12 col-lg-3 mb-5 mb-lg-0">
						<h2 >Crafted with excellent material.</h2>
						<p >Donec vitae odio quis nisl dapibus malesuada. Nullam ac aliquet velit. Aliquam vulputate velit imperdiet dolor tempor tristique. </p>
						<p><a href="shop.html" class="btn">Explore</a></p>
					</div> 
					<!-- End Column 1 -->

					<!-- Start Column 2 -->
					<div class="col-12 col-md-4 col-lg-3 mb-5 mb-md-0">
						<a class="product-item" href="cart.html">
							<img src="hero-1.jpg" class="img-fluid product-thumbnail" style="width: 300px; height: 200px;">
							<h3 class="product-title">Nordic Chair</h3>
							<strong class="product-price">$50.00</strong>

							<span class="icon-cross">
								<img src="images/cross.svg" class="img-fluid">
							</span>
						</a>
					</div> 
					<!-- End Column 2 -->

					<!-- Start Column 3 -->
					<div class="col-12 col-md-4 col-lg-3 mb-5 mb-md-0">
						<a class="product-item" href="cart.html">
							<img src="hero-1.jpg" class="img-fluid product-thumbnail" style="width: 300px; height: 200px;">
							<h3 class="product-title">Kruzo Aero Chair</h3>
							<strong class="product-price">$78.00</strong>

							<span class="icon-cross">
								<img src="images/cross.svg" class="img-fluid">
							</span>
						</a>
					</div>
					<!-- End Column 3 -->

					<!-- Start Column 4 -->
					<div class="col-12 col-md-4 col-lg-3 mb-5 mb-md-0">
						<a class="product-item" href="cart.html">
							<img src="hero-1.jpg" class="img-fluid product-thumbnail" style="width: 300px; height: 200px;">
							<h3 class="product-title">Ergonomic Chair</h3>
							<strong class="product-price">$43.00</strong>

							<span class="icon-cross">
								<img src="images/cross.svg" class="img-fluid">
							</span>
						</a>
					</div>
					<!-- End Column 4 -->

				</div>
			</div>
		</div>
		<!-- End Product Section -->
</asp:Content>
