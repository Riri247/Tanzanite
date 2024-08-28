using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FRONTEND
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Implement your authentication logic here.
            bool isAuthenticated = AuthenticateUser(email, password);

            if (isAuthenticated)
            {
                // Redirect to the homepage or any other page upon successful login.
                Response.Redirect("Home.aspx");
            }
            else
            {
                // Display an error message
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Invalid email or password.');", true);
            }
        }

        private bool AuthenticateUser(string email, string password)
        {
            // Replace this with your actual authentication logic
            // For example, querying the database to check if the credentials are correct.

            // Example placeholder logic:
            return email == "admin@example.com" && password == "password";
        }
    }
}