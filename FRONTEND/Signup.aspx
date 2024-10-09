<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="FRONTEND.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <!-- Signup Section Begin -->
    <section class="signup spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-6">
                    <div class="login__form">
                        <h2>Sign Up</h2>
                        <form id="form1" runat="server">
                            <div class="input__item">
                                <input type="text" placeholder="Email address"  runat="server" id="txtEmail">
                                <span class="icon_mail"></span>
                            </div>
                            <div class="input__item">
                                <input type="text" placeholder="Your Name"  runat="server" id="txtName">
                                <span class="icon_profile"></span>
                            </div>
                            <div class="input__item">
                                <input type="text" placeholder="Your Surname"  runat="server" id="txtSur">
                                <span class="icon_profile"></span>
                            </div>
                            <div class="input__item">
                                <input type="text" placeholder="Password" runat="server" id="txtPassword">
                                <span class="icon_lock"></span>
                            </div>
                            <ASP:button ID="btnRegister" class="site-btn" runat="server" Text="Register" OnClick="btnRegister_Click"/>
                            <div>
                                <asp:Label ID="lblMessage" runat="server"/>
                            </div>
                        </form>
                        <h5>Already have an account? <a href="Login.aspx">Log In!</a></h5>
                    </div>
                </div>
                
            </div>
        </div>
    </section>
    <!-- Signup Section End -->

</asp:Content>
