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
        dynamic CartItems;
        RentEaseClient serve = new RentEaseClient();
        decimal GTotal;
        List<decimal> Totals = new List<decimal>();
        CartProductWrapper[] CartItems2;

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
                else
                {
                    Response.Redirect("Login.asx");

                }
            }

                if(Session["ID"]!=null)
                {

                    int UserID = int.Parse(Session["ID"].ToString());
                  
                   
                    LoadCart(UserID);
                }
        }

        private void LoadCart(int UserID)
        {
            //adding discount
            decimal perc = 0;
          
            CartItems = serve.getUserCart(UserID);
            int QuantityboxCount = 1;
            string CartItemHTML = "";

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
                    Td.ID = "td" + c.product.Id;

                    //making a quantity and duration input
                    LiteralControl htmlName = new LiteralControl("<h2> Quantity of product </h2>"); //adding the title
                    TextBox QuanText = new TextBox();
                    QuanText.Text = (c.cart.Quantity).ToString();

                    QuanText.ID = "txtQuantity" + QuantityboxCount; //naming the id
                    QuantityboxCount++; //incremetning
                    LiteralControl htmlDura = new LiteralControl("<h2> Duration product in days</h2>"); //adding the title
                    TextBox DuraText = new TextBox();
                     DuraText.ID = "txtDuration" + c.product.Id; //naming the id
                     DuraText.TextMode = TextBoxMode.Number;
                    DuraText.Text = c.Duration.ToString();
                   


                    //adding it all in order
                    Td.Controls.Add(htmlName);
                    Td.Controls.Add(QuanText);
                    Td.Controls.Add(htmlDura);
                    Td.Controls.Add(DuraText);

                    //adding the td to placeholder
                    divCartStuff.Controls.Add(Td);


                    TableCell td = (TableCell)divCartStuff.FindControl("td" + c.product.Id);
                    TextBox txt = (TextBox)td.FindControl("txtDuration" + c.product.Id);

                    if (serve.HasBoughtProduct(int.Parse(Session["ID"].ToString()),c.product.Id)) {
                        perc = Convert.ToDecimal(0.1);

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

            
            if (Session["ID"] != null) {

                CartItems = serve.getUserCart(int.Parse(Session["ID"].ToString()));
                
                int[] durations = new int[CartItems.Length];
                SysShopping_Cart[] finalCart = new SysShopping_Cart[CartItems.Length];

                int i = 0;
                 foreach(CartProductWrapper c in CartItems)
                 {
                    if (c != null) {
                        

                        TableCell td = (TableCell)divCartStuff.FindControl("td" + c.product.Id);
                        TextBox txt = (TextBox)td.FindControl("txtDuration" + c.product.Id);

                        int duration = 1;

                        try
                        {
                            duration = int.Parse(txt.Text);
                        }
                        catch (Exception)
                        {
                            duration = 1;
                        }

                          
                        
                        durations[i] = duration;
                        finalCart[i] = c.cart;
                        i++;

                    }
                 }
                serve.placeOrder(int.Parse(Session["ID"].ToString()),finalCart, durations);
                 if (durations.Length == finalCart.Length)
                {
                    Session["CheckoutDurations"] = durations;

                    Response.Redirect("ContractView.aspx");
                }

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {


            


            foreach (CartProductWrapper c in CartItems)
            {
                String dynamicID = "txtDuration" + c.product.Id;
                TextBox txtBox = (TextBox)divCartStuff.FindControl(dynamicID);

                serve.EditCart(Convert.ToInt32(Session["ID"].ToString()), c.product.Id, Convert.ToInt32(txtBox.Text));
            }
            }
    }
}