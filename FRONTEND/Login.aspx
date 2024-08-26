<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FRONTEND.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--style-->
    <style>
        /*---------------------
  Login
-----------------------*/

.login {
	padding-top: 130px;
	padding-bottom: 120px;
}

.login__form {
	position: relative;
	padding-left: 145px;
}

.login__form:after {
	position: absolute;
	right: -14px;
	top: -40px;
	height: 330px;
	width: 1px;
	background: rgba(255, 255, 255, 0.2);
	content: "";
}

.login__form h3 {
	color: #ffffff;
	font-weight: 700;
	font-family: "Oswald", sans-serif;
	margin-bottom: 30px;
}

.login__form form .input__item {
	position: relative;
	width: 370px;
	margin-bottom: 20px;
}

.login__form form .input__item:before {
	position: absolute;
	left: 50px;
	top: 10px;
	height: 30px;
	width: 1px;
	background: #b7b7b7;
	content: "";
}

.login__form form .input__item input {
	height: 50px;
	width: 100%;
	font-size: 15px;
	color: #b7b7b7;
	background: #ffffff;
	border: none;
	padding-left: 76px;
}

.login__form form .input__item input::-webkit-input-placeholder {
	color: #b7b7b7;
}

.login__form form .input__item input::-moz-placeholder {
	color: #b7b7b7;
}

.login__form form .input__item input:-ms-input-placeholder {
	color: #b7b7b7;
}

.login__form form .input__item input::-ms-input-placeholder {
	color: #b7b7b7;
}

.login__form form .input__item input::placeholder {
	color: #b7b7b7;
}

.login__form form .input__item span {
	color: #b7b7b7;
	font-size: 20px;
	position: absolute;
	left: 15px;
	top: 13px;
}

.login__form form button {
	border-radius: 0;
	margin-top: 10px;
}

.login__form .forget_pass {
	font-size: 15px;
	color: #ffffff;
	display: inline-block;
	position: absolute;
	right: 60px;
	bottom: 12px;
}

.login__register {
	padding-left: 30px;
}

.login__register h3 {
	color: #ffffff;
	font-weight: 700;
	font-family: "Oswald", sans-serif;
	margin-bottom: 30px;
}

.login__register .primary-btn {
	background: #e53637;
	padding: 12px 42px;
}

.login__social {
	padding-top: 52px;
}

.login__social__links {
	text-align: center;
}

.login__social__links span {
	color: #ffffff;
	display: block;
	font-size: 13px;
	font-weight: 700;
	letter-spacing: 2px;
	text-transform: uppercase;
	margin-bottom: 30px;
}

.login__social__links ul li {
	list-style: none;
	margin-bottom: 15px;
}

.login__social__links ul li:last-child {
	margin-bottom: 0;
}

.login__social__links ul li a {
	color: #ffffff;
	display: block;
	font-size: 13px;
	font-weight: 700;
	letter-spacing: 2px;
	text-transform: uppercase;
	width: 460px;
	padding: 14px 0;
	position: relative;
	margin: 0 auto;
}

.login__social__links ul li a.facebook {
	background: #4267b2;
}

.login__social__links ul li a.google {
	background: #ff4343;
}

.login__social__links ul li a.twitter {
	background: #1da1f2;
}

.login__social__links ul li a i {
	font-size: 20px;
	position: absolute;
	left: 32px;
	top: 14px;
}

    	.container {
    	background: #596e79; 
		}
    </style>

    <!-- Login Section Begin -->
    <section class="login spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-6">
                    <div class="login__form">
                        <h3>Login</h3>
                        <form action="#">
                            <div class="input__item">
                                <input type="text" placeholder="Email address">
                                <span class="icon_mail"></span>
                            </div>
                            <div class="input__item">
                                <input type="text" placeholder="Password">
                                <span class="icon_lock"></span>
                            </div>
                            <button type="submit" class="site-btn">Login Now</button>
                        </form>
                        <a href="#" class="forget_pass">Forgot Your Password?</a>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="login__register">
                        <h3>Dont’t Have An Account?</h3>
                        <a href="#" class="primary-btn">Register Now</a>
                    </div>
                </div>
            </div>
            <div class="login__social">
                <div class="row d-flex justify-content-center">
                    <div class="col-lg-6">
                        <div class="login__social__links">
                            <span>or</span>
                            <ul>
                                <li><a href="#" class="facebook"><i class="fa fa-facebook"></i> Sign in With
                                Facebook</a></li>
                                <li><a href="#" class="google"><i class="fa fa-google"></i> Sign in With Google</a></li>
                                <li><a href="#" class="twitter"><i class="fa fa-twitter"></i> Sign in With Twitter</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Login Section End -->
</asp:Content>
