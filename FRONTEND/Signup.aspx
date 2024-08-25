<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="FRONTEND.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        /*---------------------
  Sign Up
-----------------------*/

.signup {
	padding-top: 130px;
	padding-bottom: 150px;
}

.signup .login__form:after {
	height: 450px;
}

.signup .login__form h5 {
	font-size: 15px;
	color: #ffffff;
	margin-top: 36px;
}

.signup .login__form h5 a {
	color: #e53637;
	font-weight: 700;
}

.signup .login__social__links {
	text-align: left;
	padding-left: 40px;
}

.signup .login__social__links h3 {
	color: #ffffff;
	font-weight: 700;
	font-family: "Oswald", sans-serif;
	margin-bottom: 30px;
}

.signup .login__social__links ul li a {
	margin: 0;
	text-align: center;
}

.container {
    	background: #596e79; 
		}
    </style>

     <!-- Signup Section Begin -->
    <section class="signup spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-6">
                    <div class="login__form">
                        <h2>Sign Up</h2>
                        <form action="#">
                            <div class="input__item">
                                <input type="text" placeholder="Email address">
                                <span class="icon_mail"></span>
                            </div>
                            <div class="input__item">
                                <input type="text" placeholder="Your Name">
                                <span class="icon_profile"></span>
                            </div>
                            <div class="input__item">
                                <input type="text" placeholder="Password">
                                <span class="icon_lock"></span>
                            </div>
                            <button type="submit" class="site-btn">Login Now</button>
                        </form>
                        <h5>Already have an account? <a href="#">Log In!</a></h5>
                    </div>
                </div>
                
            </div>
        </div>
    </section>
    <!-- Signup Section End -->

</asp:Content>
