using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FRONTEND.ServiceReference1;

namespace FRONTEND
{
    public partial class Cart : System.Web.UI.Page
    {
        RentEaseClient serve = new RentEaseClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["action"].ToString().Equals("remove") && Request.QueryString["prodID"] != null)
            {
                if (Session["ID"] != null)
                {

                    int UserID = int.Parse(Session["ID"].ToString());
                    //check if user added to the cart 
                    if (Request.QueryString["prodID"].ToString() != null)
                    {
                        int prodID = int.Parse(Request.QueryString["prodID"].ToString());

                        serve.removeFromCart(UserID, prodID);

                    }
                }
            }
            if(!IsPostBack)
            {
                //check if user is logged in 
                if(Session["ID"]!=null)
                {

                    int UserID = int.Parse(Session["ID"].ToString());
                    //check if user added to the cart 
                    if (Request.QueryString["prodID"].ToString()!=null)
                    {
                        int prodID = int.Parse(Request.QueryString["prodID"].ToString());
                        
                        serve.addToCart(UserID, prodID);

                    }
                   
                    LoadCart(UserID);
                }
            }
        }

        private void LoadCart(int UserID)
        {
            dynamic CartItems = serve.getUserCart(UserID);
            string CartItemHTML = "";
            int DurationBoxCount = 1;
            int QuantityboxCount = 1;

            foreach(CartProductWrapper c in CartItems)
            {
                CartItemHTML += "<tr>";
                CartItemHTML += "<td class='product-thumbnail'>";
                CartItemHTML += "<img src='"+c.product.Image_URL+"' alt='Image' class='img-fluid'  style='width: 300px; height: 200px;'>";
                CartItemHTML += "</td>";
                CartItemHTML += "<td class='product-name'>";
                CartItemHTML += "<h2 class='h5 text-black'>"+c.product.Product_Name+"</h2>";
                CartItemHTML += "</td>";
                CartItemHTML += "<td>R"+c.product.Price+"</td>";

                //first adding the whoe text i have so far
                LiteralControl FirstPart = new LiteralControl(CartItemHTML);

                //putting in the thing
                divCartStuff.Controls.Add(FirstPart);

                //making an empty tablecell and adding to it
                TableCell Td = new TableCell();

                //making a quantity and duration input
                LiteralControl htmlName = new LiteralControl("<h2> Quantity if product </h2>"); //adding the title
                TextBox QuanText = new TextBox();
                QuanText.ID = "txtQuantity" + QuantityboxCount; //naming the id
                QuantityboxCount++; //incremetning
                LiteralControl htmlDura = new LiteralControl("<h2> Duration product </h2>"); //adding the title
                TextBox DuraText = new TextBox();
                DuraText.ID = "txtQuantity" + DurationBoxCount; //naming the id
                DurationBoxCount++; //incremetning

                //adding it all in order
                Td.Controls.Add(htmlName);
                Td.Controls.Add(QuanText);
                Td.Controls.Add(htmlDura);
                Td.Controls.Add(DuraText);

                //adding the td to placeholder
                divCartStuff.Controls.Add(Td);


                //  CartItemHTML += "<td>";

                //Commented out the stuff you did
                //CartItemHTML += "<div class='input-group mb-3 d-flex align-items-center quantity-container' style='max-width: 120px;'>";
                //CartItemHTML += "<div class='input-group-prepend'>";
                //CartItemHTML += "<button class='btn btn-outline-black decrease' type='button'>&minus;</button>";
                //CartItemHTML += "</div>";
                //CartItemHTML += "<input type='text' class='form-control text-center quantity-amount' value='1' placeholder='' aria-label='Example text with button addon' aria-describedby='button-addon1' style='width:min-content;'>";
                //CartItemHTML += "<div class='input-group-append'>";
                //CartItemHTML += "<button class='btn btn-outline-black increase' type='button'>&plus;</button>";
                //CartItemHTML += "</div>";
                //CartItemHTML += "</div>";



                //  CartItemHTML = "</td>";
                //adding the rest 


                CartItemHTML = "<td>" + c.product.Price + "</td>";
                CartItemHTML += "<td><a href='Cart.aspx?action=remove&prodID="+c.product.Id+"' class='btn btn-black btn-sm'>X</a></td>";
                CartItemHTML += "</tr>";

                divCartStuff.Controls.Add(new LiteralControl(CartItemHTML));
                
            }

            DispCart.InnerHtml = CartItemHTML;


        }



        protected void CheckOut(object sender, EventArgs e) { 
            
        }



    }
}