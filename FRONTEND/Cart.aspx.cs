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
                CartItemHTML += "<td>";
                CartItemHTML += "<div class='input-group mb-3 d-flex align-items-center quantity-container' style='max-width: 120px;'>";
                CartItemHTML += "<div class='input-group-prepend'>";
                CartItemHTML += "<button class='btn btn-outline-black decrease' type='button'>&minus;</button>";
                CartItemHTML += "</div>";
                CartItemHTML += "<input type='text' class='form-control text-center quantity-amount' value='1' placeholder='' aria-label='Example text with button addon' aria-describedby='button-addon1' style='width:min-content;'>";
                CartItemHTML += "<div class='input-group-append'>";
                CartItemHTML += "<button class='btn btn-outline-black increase' type='button'>&plus;</button>";
                CartItemHTML += "</div>";
                CartItemHTML += "</div>";
                CartItemHTML += "</td>";
                CartItemHTML += "<td>" + c.product.Price + "</td>";
                CartItemHTML += "<td><a href='Cart.aspx?action=remove&prodID="+c.product.Id+"' class='btn btn-black btn-sm'>X</a></td>";
                CartItemHTML += "</tr>";
            }

            DispCart.InnerHtml = CartItemHTML;
        }

                           
                          
                           
                          
                          
                            
                          
                          
                          
                            
                              
                                
                              
                              
                              
                                
                              
                          
        
                          
                          
                          
        
                            
     
    }
}