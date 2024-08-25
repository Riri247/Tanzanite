<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FRONTEND.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        /*---------------------
  Hero
-----------------------*/
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

/*---------------------
  Product
-----------------------*/

.product {
	padding-bottom: 60px;
	padding-top: 80px;
}

.product-page {
	padding-top: 60px;
}

.btn__all {
	text-align: right;
	margin-bottom: 30px;
}

.trending__product {
	margin-bottom: 50px;
}

.popular__product {
	margin-bottom: 50px;
}

.recent__product {
	margin-bottom: 50px;
}

.product__item {
	margin-bottom: 30px;
  
}

.product__item__pic {
	height: 325px;
	position: relative;
	border-radius: 5px;
     background-repeat: no-repeat;
}

.product__item__pic .ep {
	font-size: 13px;
	color: #ffffff;
	background: #e53637;
	display: inline-block;
	padding: 2px 12px;
	border-radius: 4px;
	position: absolute;
	left: 10px;
	top: 10px;
}

.product__item__pic .comment {
	font-size: 13px;
	color: #ffffff;
	background: #3d3d3d;
	display: inline-block;
	padding: 2px 10px;
	border-radius: 4px;
	position: absolute;
	left: 10px;
	bottom: 10px;
}

.product__item__pic .view {
	font-size: 13px;
	color: #ffffff;
	background: #3d3d3d;
	display: inline-block;
	padding: 2px 10px;
	border-radius: 4px;
	position: absolute;
	right: 10px;
	bottom: 10px;
}

.product__item__text {
	padding-top: 20px;
}

.product__item__text ul {
	margin-bottom: 10px;
}

.product__item__text ul li {
	list-style: none;
	font-size: 10px;
	color: #ffffff;
	font-weight: 700;
	padding: 1px 10px;
	background: rgba(255, 255, 255, 0.2);
	border-radius: 50px;
	display: inline-block;
}

.product__item__text h5 a {
	color: #ffffff;
	font-weight: 700;
	line-height: 26px;
}

.product__sidebar .section-title h5 {
	color: #ffffff;
	font-weight: 600;
	font-family: "Oswald", sans-serif;
	line-height: 21px;
	text-transform: uppercase;
	padding-left: 20px;
	position: relative;
}

.product__sidebar .section-title h5:after {
	position: absolute;
	left: 0;
	top: -6px;
	height: 32px;
	width: 4px;
	background: #e53637;
	content: "";
}

.product__sidebar__view {
	position: relative;
	margin-bottom: 80px;
}

.product__sidebar__view .filter__controls {
	position: absolute;
	right: 0;
	top: -5px;
}

.product__sidebar__view .filter__controls li {
	list-style: none;
	font-size: 13px;
	color: #b7b7b7;
	display: inline-block;
	margin-right: 7px;
	cursor: pointer;
}

.product__sidebar__view .filter__controls li.active {
	color: #ffffff;
}

.product__sidebar__view .filter__controls li:last-child {
	margin-right: 0;
}

.product__sidebar__view__item {
	height: 190px;
	position: relative;
	border-radius: 5px;
	margin-bottom: 20px;
}

.product__sidebar__view__item .ep {
	font-size: 13px;
	color: #ffffff;
	background: #e53637;
	display: inline-block;
	padding: 2px 12px;
	border-radius: 4px;
	position: absolute;
	left: 10px;
	top: 10px;
}

.product__sidebar__view__item .view {
	font-size: 13px;
	color: #ffffff;
	background: #3d3d3d;
	display: inline-block;
	padding: 2px 10px;
	border-radius: 4px;
	position: absolute;
	right: 10px;
	top: 10px;
}

.product__sidebar__view__item h5 {
	position: absolute;
	left: 0;
	bottom: 25px;
	width: 100%;
	padding: 0 30px 0 20px;
}

.product__sidebar__view__item h5 a {
	color: #ffffff;
	font-weight: 700;
	line-height: 26px;
}

.product__sidebar__comment {
	margin-bottom: 35px;
}

.product__sidebar__comment__item {
	margin-bottom: 20px;
	overflow: hidden;
}

.product__sidebar__comment__item__pic {
	float: left;
	margin-right: 15px;
}

.product__sidebar__comment__item__text {
	overflow: hidden;
}

.product__sidebar__comment__item__text ul {
	margin-bottom: 10px;
}

.product__sidebar__comment__item__text ul li {
	list-style: none;
	font-size: 10px;
	color: #ffffff;
	font-weight: 700;
	padding: 1px 10px;
	background: rgba(255, 255, 255, 0.2);
	border-radius: 50px;
	display: inline-block;
}

.product__sidebar__comment__item__text h5 {
	margin-bottom: 10px;
}

.product__sidebar__comment__item__text h5 a {
	color: #ffffff;
	font-weight: 700;
	line-height: 26px;
}

.product__sidebar__comment__item__text span {
	display: block;
	font-size: 13px;
	color: #b7b7b7;
}

.product__page__title {
	border-bottom: 2px solid rgba(255, 255, 255, 0.2);
	padding-bottom: 10px;
	margin-bottom: 30px;
}

.product__page__title .section-title {
	margin-bottom: 0;
}

.product__page__title .product__page__filter {
	text-align: right;
}

.product__page__title .product__page__filter p {
	color: #ffffff;
	display: inline-block;
	margin-bottom: 0;
	margin-right: 16px;
}

.product__page__title .product__page__filter .nice-select {
	float: none;
	display: inline-block;
	font-size: 15px;
	color: #3d3d3d;
	font-weight: 700;
	border-radius: 0;
	padding-left: 15px;
	padding-right: 40px;
	height: 32px;
	line-height: 32px;
}

.product__page__title .product__page__filter .nice-select:after {
	border-bottom: 2px solid #111;
	border-right: 2px solid #111;
	height: 8px;
	top: 47%;
	width: 8px;
	right: 15px;
}

.product__page__title .product__page__filter .nice-select .list {
	margin-top: 0;
	border-radius: 0;
}

.product__pagination {
	padding-top: 15px;
}

.product__pagination a {
	display: inline-block;
	font-size: 15px;
	color: #b7b7b7;
	font-weight: 600;
	height: 50px;
	width: 50px;
	border: 1px solid transparent;
	border-radius: 50%;
	line-height: 48px;
	text-align: center;
	-webkit-transition: all, 0.3s;
	-o-transition: all, 0.3s;
	transition: all, 0.3s;
}

.product__pagination a:hover {
	color: #ffffff;
}

.product__pagination a.current-page {
	border: 1px solid #ffffff;
}

.product__pagination a i {
	color: #b7b7b7;
	font-size: 15px;
}


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
                                <div class="label">Adventure</div>
                                <h2>Fate / Stay Night: Unlimited Blade Works</h2>
                                <p>T1</p>
                                <a href="#"><span>Watch Now</span> <i class="fa fa-angle-right"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="hero__items" style="background-image:url(hero-1.jpg)">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="hero__text">
                                <div class="label">Adventure</div>
                                <h2>Fate / Stay Night: Unlimited Blade Works</h2>
                               <p>T2</p>
                                <a href="#"><span>Watch Now</span> <i class="fa fa-angle-right"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="hero__items" style="background-image:url(hero-1.jpg)">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="hero__text">
                                <div class="label">Adventure</div>
                                <h2>Fate / Stay Night: Unlimited Blade Works</h2>
                              <p>T3</p>
                                <a href="#"><span>Watch Now</span> <i class="fa fa-angle-right"></i></a>
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

    <!-- table start-->
    <table>
        <tr>
            <td>
<!--start of product item-->
                 <div class="col-lg-4 col-md-6 col-sm-6">
                                <div class="product__item">
                                    <div class="product__item__pic" style="background-image:url(hero-1.jpg); ">
                                        <div class="ep">18 / 18</div>
                                        <div class="comment"><i class="fa fa-comments"></i> 11</div>
                                        <div class="view"><i class="fa fa-eye"></i> 9141</div>
                                    </div>
                                    <div class="product__item__text">
                                        <ul>
                                            <li>Active</li>
                                            <li>Movie</li>
                                        </ul>
                                        <h5><a href="#">The Seven Deadly Sins: Wrath of the Gods</a></h5>
                                    </div>
                                </div>
                     </div>
                           
                            <!-- end of product item-->
            </td>

            <td>
                <div class="col-lg-4 col-md-6 col-sm-6">
                                <div class="product__item">
                                    <div class="product__item__pic" style="background-image:url(hero-1.jpg)">
                                        <div class="ep">18 / 18</div>
                                        <div class="comment"><i class="fa fa-comments"></i> 11</div>
                                        <div class="view"><i class="fa fa-eye"></i> 9141</div>
                                    </div>
                                    <div class="product__item__text">
                                        <ul>
                                            <li>Active</li>
                                            <li>Movie</li>
                                        </ul>
                                        <h5><a href="#">Code Geass: Hangyaku no Lelouch R2</a></h5>
                                    </div>
                                </div>
                            </div>
            </td>
        </tr>
    </table>
    <!-- end of table>


    <!-- Product Section Begin -->
    <section class="product spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-8">
                    <div class="trending__product">
                        <div class="row">
                            <div class="col-lg-8 col-md-8 col-sm-8">
                                <div class="section-title">
                                    <!--start of trending-->
                                    <h4>Trending Now</h4>
                                </div>
                            </div>
                            <div class="col-lg-4 col-md-4 col-sm-4">
                                <div class="btn__all">
                                    <a href="#" class="primary-btn">View All <span class="arrow_right"></span></a>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                           
                                
                           
                           
                            
                        </div>
                    </div>
                    <!-- END OF TRENDING -->

                     <!-- START OF PUPULAR-->
                    <div class="popular__product">
                        <div class="row">
                            <div class="col-lg-8 col-md-8 col-sm-8">
                                <div class="section-title">
                                    <h4>Popular Shows</h4>
                                </div>
                            </div>
                            <div class="col-lg-4 col-md-4 col-sm-4">
                                <div class="btn__all">
                                    <a href="#" class="primary-btn">View All <span class="arrow_right"></span></a>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                           
                            <!-- start of pop Prod-->
                            <div class="col-lg-4 col-md-6 col-sm-6">
                                <div class="product__item">
                                    <div class="product__item__pic set-bg" style="background-image:url(hero-1.jpg)">
                                        <div class="ep">18 / 18</div>
                                        <div class="comment"><i class="fa fa-comments"></i> 11</div>
                                        <div class="view"><i class="fa fa-eye"></i> 9141</div>
                                    </div>
                                    <div class="product__item__text">
                                        <ul>
                                            <li>Active</li>
                                            <li>Movie</li>
                                        </ul>
                                        <h5><a href="#">Sen to Chihiro no Kamikakushi</a></h5>
                                    </div>
                                </div>
                            </div>
                            <!-- end of pop product-->
                            <div class="col-lg-4 col-md-6 col-sm-6">
                                <div class="product__item">
                                    <div class="product__item__pic set-bg" style="background-image:url(hero-1.jpg)">
                                        <div class="ep">18 / 18</div>
                                        <div class="comment"><i class="fa fa-comments"></i> 11</div>
                                        <div class="view"><i class="fa fa-eye"></i> 9141</div>
                                    </div>
                                    <div class="product__item__text">
                                        <ul>
                                            <li>Active</li>
                                            <li>Movie</li>
                                        </ul>
                                        <h5><a href="#">Kizumonogatari III: Reiket su-hen</a></h5>
                                    </div>
                                </div>
                            </div>
                           
                        </div>
                    </div>
                    <!-- END POPULAR>
                    <!--START RECENT-->
                    <div class="recent__product">
                        <div class="row">
                            <div class="col-lg-8 col-md-8 col-sm-8">
                                <div class="section-title">
                                    <h4>Recently Added Shows</h4>
                                </div>
                            </div>
                            <div class="col-lg-4 col-md-4 col-sm-4">
                                <div class="btn__all">
                                    <a href="#" class="primary-btn">View All <span class="arrow_right"></span></a>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <!-- start of Recent product-->
                            <div class="col-lg-4 col-md-6 col-sm-6">
                                <div class="product__item">
                                    <div class="product__item__pic set-bg" style="background-image:url(hero-1.jpg)">
                                        <div class="ep">18 / 18</div>
                                        <div class="comment"><i class="fa fa-comments"></i> 11</div>
                                        <div class="view"><i class="fa fa-eye"></i> 9141</div>
                                    </div>
                                    <div class="product__item__text">
                                        <ul>
                                            <li>Active</li>
                                            <li>Movie</li>
                                        </ul>
                                        <h5><a href="#">Great Teacher Onizuka</a></h5>
                                    </div>
                                </div>
                            </div>
                            <!-- end of recent product-->
                            <div class="col-lg-4 col-md-6 col-sm-6">
                                <div class="product__item">
                                    <div class="product__item__pic set-bg" style="background-image:url(hero-1.jpg)">
                                        <div class="ep">18 / 18</div>
                                        <div class="comment"><i class="fa fa-comments"></i> 11</div>
                                        <div class="view"><i class="fa fa-eye"></i> 9141</div>
                                    </div>
                                    <div class="product__item__text">
                                        <ul>
                                            <li>Active</li>
                                            <li>Movie</li>
                                        </ul>
                                        <h5><a href="#">Fate/stay night Movie: Heaven's Feel - II. Lost</a></h5>
                                    </div>
                                </div>
                            </div>
                           
                        </div>
                    </div>
                    
                </div>
                <div class="col-lg-4 col-md-6 col-sm-8">
                    
                  
    </div>
    
</div>
</div>
</section>
<!-- Product Section End -->
</asp:Content>
