using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FRONTEND.ServiceReference1;


namespace FRONTEND
{
    public partial class ContractView : System.Web.UI.Page
    {

        RentEaseClient serve = new RentEaseClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }




        protected void CheckOut(object sender, EventArgs e)
        {
            //make invoice
            //redirect ot invoice page

            if ( Session["ID"] != null && Session["CheckoutDurations"] != null)
            {
                CartProductWrapper[] CartItems = serve.getUserCart(int.Parse(Session["ID"].ToString()));
                int[] durations = (int[])Session["CheckoutDurations"];

                SysShopping_Cart[] finalCart = new SysShopping_Cart[CartItems.Length];

                int i = 0;
                foreach (CartProductWrapper c in CartItems)
                {
                    if (c != null)
                    {
                        finalCart[i] = c.cart;
                        i++;
                    }
                }
                int iid;

                if ((iid = serve.placeOrder(int.Parse(Session["ID"].ToString()), finalCart, durations)) > 1)
                {
                    Response.Redirect("Invoice.aspx?InvoiceID=" + iid);
                }

            }
            else
            {
                Response.Redirect("Login.asx");

            }
        }



    }
}