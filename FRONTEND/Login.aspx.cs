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
    public partial class Login : System.Web.UI.Page
    {
        RentEaseClient serve = new RentEaseClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            /*
             * Email = u.Email,
               Id = u.Id,
               User_Type = u.User_Type
             */

            if(!String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                //validate
                ServiceReference1.SysUser user = serve.Login(txtEmail.Text, Secrecy.HashPassword(txtPassword.Text));
                if(user!=null)
                {
                    Session["ID"] = user.Id;
                    Session["Email"] = user.Email;
                    Session["U_type"] = user.User_Type;
                }
                else
                {
                    lblMessage.Text = "Incorrect Email address or password.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }

            
        }
    }
}