<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FRONTEND.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

   
    <meta charset="UTF-8">
    <meta name="description" content="Anime Template">
    <meta name="keywords" content="Anime, unica, creative, html">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Anime | Template</title>


     <!-- Google Font -->    <link href="https://fonts.googleapis.com/css2?family=Oswald:wght@300;400;500;600;700&display=swap" rel="stylesheet">    <link href="https://fonts.googleapis.com/css2?family=Mulish:wght@300;400;500;600;700;800;900&display=swap"    rel="stylesheet">


    <!-- CSS STYLES-->
   <style>
       


/*----------------------------------------*/

/* Template default CSS
/*----------------------------------------*/

html,
body {
	height: 100%;
	font-family: "Mulish", sans-serif;
	-webkit-font-smoothing: antialiased;
	background: #f0ece2;
}

h1,
h2,
h3,
h4,
h5,
h6 {
	margin: 0;
	color: #111111;
	font-weight: 400;
	font-family: "Mulish", sans-serif;
}

h1 {
	font-size: 70px;
}

h2 {
	font-size: 36px;
}

h3 {
	font-size: 30px;
}

h4 {
	font-size: 24px;
}

h5 {
	font-size: 18px;
}

h6 {
	font-size: 16px;
}

p {
	font-size: 15px;
	font-family: "Mulish", sans-serif;
	color: #3d3d3d;
	font-weight: 400;
	line-height: 25px;
	margin: 0 0 15px 0;
}

img {
	max-width: 100%;
}

input:focus,
select:focus,
button:focus,
textarea:focus {
	outline: none;
}

a:hover,
a:focus {
	text-decoration: none;
	outline: none;
	color:  #dfd3c3;
}

ul,
ol {
	padding: 0;
	margin: 0;
}


/*---------------------
  Header
-----------------------*/

.header {
	background:  #596e79;
}

.header__logo {
	padding: 20px 0 17px;
}

.header__logo a {
	display: inline-block;
}

.header__menu {
	text-align: center;
}

.header__menu ul li {
	list-style: none;
	display: inline-block;
	position: relative;
	margin-right: 16px;
}

.header__menu ul li.active a {
	background: #e53637;
	color: #ffffff;
}

.header__menu ul li:hover a {
	color: #ffffff;
}

.header__menu ul li:hover .dropdown {
	top: 62px;
	opacity: 1;
	visibility: visible;
}

.header__menu ul li:hover .dropdown li a {
	background: transparent;
}

.header__menu ul li:last-child {
	margin-right: 0;
}

.header__menu ul li .dropdown {
	position: absolute;
	left: 0;
	top: 82px;
	width: 150px;
	background: #ffffff;
	text-align: left;
	padding: 5px 0;
	z-index: 9;
	opacity: 0;
	visibility: hidden;
	-webkit-transition: all, 0.3s;
	-o-transition: all, 0.3s;
	transition: all, 0.3s;
}

.header__menu ul li .dropdown li {
	display: block;
	margin-right: 0;
}

.header__menu ul li .dropdown li a {
	font-size: 14px;
	color: #111111;
	font-weight: 500;
	padding: 5px 20px;
}

.header__menu ul li a {
	font-size: 15px;
	color: #b7b7b7;
	display: block;
	font-weight: 700;
	-webkit-transition: all, 0.5s;
	-o-transition: all, 0.5s;
	transition: all, 0.5s;
	padding: 20px;
}

.header__menu ul li a span {
	position: relative;
	font-size: 17px;
	top: 2px;
}

.header__right {
	text-align: right;
	padding: 20px 0 15px;
}

.header__right a {
	display: inline-block;
	font-size: 18px;
	color: #ffffff;
	margin-right: 30px;
}

.header__right a:last-child {
	margin-right: 0;
}

.slicknav_menu {
	display: none;
}

/*---------------------
  Footer
-----------------------*/
       .footer {
	background: #596e79;
	padding-top: 60px;
	padding-bottom: 40px;
	position: relative;
}

.page-up {
	position: absolute;
	left: 50%;
	top: -25px;
	margin-left: -25px;
}

.page-up a {
	display: inline-block;
	font-size: 36px;
	color: #ffffff;
	height: 50px;
	width: 50px;
	background: #e53637;
	line-height: 50px;
	text-align: center;
	border-radius: 50%;
}

.page-up a span {
	position: relative;
	top: 2px;
	left: -1px;
}

.footer__nav {
	text-align: center;
}

.footer__nav ul li {
	list-style: none;
	display: inline-block;
	position: relative;
	margin-right: 40px;
}

.footer__nav ul li:last-child {
	margin-right: 0;
}

.footer__nav ul li a {
	font-size: 15px;
	color: #b7b7b7;
	display: block;
	font-weight: 700;
}

.footer__copyright__text {
	color: #b7b7b7;
	margin-bottom: 0;
	text-align: right;
}

.footer__copyright__text a {
	color: #e53637;
}
   </style>

</head>
<body>

     <!-- Header Section Begin -->
    <header class="header">
        <div class="container">
            <div class="row">
                <div class="col-lg-2">
                    <div class="header__logo">
                        <a href="./index.html">
                            <img src="#logo" alt="">
                        </a>
                    </div>
                </div>
                <div class="col-lg-8">
                    <div class="header__nav">
                        <nav class="header__menu mobile-menu">
                            <ul>
                                <li class="active"><a href="#"> <asp:label ID="Currentlabel" runat="server"/></a></li>
                                <li><a href="./categories.html">Categories <span class="arrow_carrot-down"></span></a>
                                    <ul class="dropdown">
                                        <li><a href="./categories.html">Categories</a></li>
                                        <li><a href="./anime-details.html">Anime Details</a></li>
                                        <li><a href="./anime-watching.html">Anime Watching</a></li>
                                        <li><a href="./blog-details.html">Blog Details</a></li>
                                        <li><a href="./signup.html">Sign Up</a></li>
                                        <li><a href="./login.html">Login</a></li>
                                    </ul>
                                </li>
                                <li><a href="./blog.html"><asp:label ID="Register" runat="server"/></a></li>
                                <li><a href="#">About us</a></li>
                            </ul>
                        </nav>
                    </div>
                </div>
                <div class="col-lg-2">
                    <div class="header__right">
                        <a href="#" class="search-switch"><span class="icon_search"></span></a>
                        <a href="./login.html"><span class="icon_profile"></span></a>
                    </div>
                </div>
            </div>
            <div id="mobile-menu-wrap"></div>
        </div>
    </header>
    <!-- Header End -->

    <form id="form1" runat="server">
        <div>
        </div>
    </form>


    <!-- Footer Section Begin -->
<footer class="footer">
    <div class="page-up">
        <a href="#" id="scrollToTopButton"><span class="arrow_carrot-up"></span></a>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-lg-3">
                <div class="footer__logo">
                    <a href="./index.html"><img src="img/logo.png" alt=""></a>
                </div>
            </div>
            <div class="col-lg-6">
                <div class="footer__nav">
                    <ul>
                        <li class="active"><a href="./index.html">Homepage</a></li>
                        <li><a href="./categories.html">Categories</a></li>
                        <li><a href="./blog.html">Our Blog</a></li>
                        <li><a href="#">Contacts</a></li>
                    </ul>
                </div>
            </div>

			<div>
				<p>Group info will go here</p>
			</div>
            <div class="col-lg-3">
                <p><!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                  Copyright &copy;<script>document.write(new Date().getFullYear());</script> All rights reserved | This template is made with <i class="fa fa-heart" aria-hidden="true"></i> by <a href="https://colorlib.com" target="_blank">Colorlib</a>
                  <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. --></p>

              </div>
          </div>
      </div>
  </footer>
  <!-- Footer Section End -->
</body>
</html>
