using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FRONTEND.ServiceReference1;
using Newtonsoft.Json;

namespace FRONTEND
{
    public partial class Cart : System.Web.UI.Page
    {
        RentEaseClient serve = new RentEaseClient();
        decimal GTotal;
        List<decimal> Totals = new List<decimal>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["action"]!= null && Request.QueryString["prodID"] != null)
            {
                if (Session["ID"] != null)
                {

                    int UserID = int.Parse(Session["ID"].ToString());
                    string action = Request.QueryString["action"].ToString();
                    //check if user added to the cart 
                    if (Request.QueryString["prodID"]!= null && action == "remove")
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
                    if (Request.QueryString["prodID"]!=null)
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
            //adding discount
            decimal perc = 0;
            String discText = "No";
          
                dynamic CartItems = serve.getUserCart(UserID);
            string CartItemHTML = "";
            int DurationBoxCount = 1;
            int QuantityboxCount = 1;

            foreach(CartProductWrapper c in CartItems)
            {
                if (c != null) {
                    //empting the carthtml thing
                    CartItemHTML = "";
                    string[] images = JsonConvert.DeserializeObject<string[]>(c.product.Image_URL);
                    CartItemHTML += "<tr>";
                    CartItemHTML += "<td class='product-thumbnail'>";
                    CartItemHTML += "<img src='" + images[0] + "' alt='Image' class='img-fluid'  style='width: 300px; height: 200px;'>";
                    CartItemHTML += "</td>";
                    CartItemHTML += "<td class='product-name'>";
                    CartItemHTML += "<h2 class='h3 text-black'>" + c.product.Product_Name + "</h2>";
                    CartItemHTML += "</td>";
                    CartItemHTML += "<td><h3>R" + c.product.Price + "</h3></td>";

                    //first adding the whole text i have so far
                    LiteralControl FirstPart = new LiteralControl(CartItemHTML);

                    //putting in the place holder
                    divCartStuff.Controls.Add(FirstPart);

                    //making an empty tablecell and adding to it
                    TableCell Td = new TableCell();

                    //making a quantity and duration input
                    LiteralControl htmlName = new LiteralControl("<h2> Quantity of product </h2>"); //adding the title
                    TextBox QuanText = new TextBox();
                    QuanText.Text = (c.cart.Quantity).ToString();
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
                    //adding discount
                    

                    if (serve.HasBoughtProduct(int.Parse(Session["ID"].ToString()),c.product.Id)) {
                        perc = Convert.ToDecimal(0.1);
                        discText = "yes";
                    }

                        decimal TemTotal = c.product.Price * c.cart.Quantity;
                    Totals.Add(TemTotal);
                    CartItemHTML = "<td><h3>R" + TemTotal + "</h3></td>";
                    CartItemHTML += "<td><a href='Cart.aspx?action=remove&prodID=" + c.product.Id + "' class='btn btn-black btn-sm'>X</a></td>";
                    CartItemHTML += "</tr>";

                    divCartStuff.Controls.Add(new LiteralControl(CartItemHTML));

                }
            }

            // DispCart.InnerHtml = CartItemHTML;

            //ccalculating the price

            //getting whole total
            decimal TempTotal = 0;
            foreach (decimal t in Totals) {
                TempTotal += t;
            }
            //showing
            lbltotal.Text = TempTotal.ToString();


            //adding  the vat
            decimal vat = TempTotal * Convert.ToDecimal(0.15);


            //dicount
            decimal disc = TempTotal * perc;

          

            lblCperc.Text = $@"{(perc*100)}%";

            GTotal = TempTotal - disc + vat;
            lblGTots.Text = GTotal.ToString();

        }



        protected void CheckOut(object sender, EventArgs e) { 
            //make invoice
            //redirect ot invoice page
        }



    }
}