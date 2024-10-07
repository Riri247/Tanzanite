using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FRONTEND.ServiceReference1;
using HashPass;

namespace FRONTEND
{
    public partial class Signup : System.Web.UI.Page
    {
        RentEaseClient serve = new RentEaseClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //check if all fields have a value 
            if(!String.IsNullOrEmpty(txtEmail.Value) && !String.IsNullOrEmpty(txtSur.Value) &&
               !String.IsNullOrEmpty(txtPassword.Value) && !String.IsNullOrEmpty(txtName.Value))
            {
                if (serve.Register(txtEmail.Value,Secrecy.HashPassword(txtPassword.Value),txtName.Value,txtSur.Value))
                {
                    Response.Redirect("Home.aspx");
                }
                {
                    lblMessage.Text = "Fatal error occured";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblMessage.Text = "Please fill in all the fields.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}