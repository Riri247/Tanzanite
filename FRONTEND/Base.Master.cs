using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FRONTEND
{
    public partial class Base : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //checking if the user is logged in
            if (Session["ID"] != null) {

                AccountOne.Visible = true;
                CartOne.Visible = true;

                if (Session["U_Type"]!= null) {
                    if (Session["U_Type"].ToString() == "Man")
                    {
                        ProductOne.Visible = true;
                    }
                    else if (Session["U_Type"].ToString() == "Adm") {
                        ProductOne.Visible = true;
                        UserOne.Visible = true;
                    }
                
                }
            }

        }
    }
}