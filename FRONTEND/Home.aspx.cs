using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FRONTEND.ServiceReference1;
using Newtonsoft.Json;

namespace FRONTEND
{
    public partial class Home : System.Web.UI.Page
    {

        RentEaseClient rc = new RentEaseClient();


        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["cart"] != null)
            {
                addCart();

            }


            if (!IsPostBack)
            {
                LoadProducts(0,50000);
            }


        }


        /*//if they are logged in they will see the add to cart shandiz
           
										<button class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> add to cart</button>
									</div>     
         */
        private void LoadProducts(decimal min,decimal Max)
        {
            dynamic Prods = rc.getProducts();
            int counter = 0;
            String htmlstrBestProds = "<table class='table'>"; // Start of  table


            foreach (ServiceReference1.SysProduct p in Prods)
            {
                if(p.Price<= Max && p.Price>=min)
                {
                    string[] images = JsonConvert.DeserializeObject<string[]>(p.Image_URL);


                    if (counter % 3 == 0) // Every 3 products, start a new row
                    {
                        if (counter > 0)
                        {
                            htmlstrBestProds += "</tr>";
                        }
                        htmlstrBestProds += "<tr>"; // Start a new row
                    }






                    // Build HTML for each product
                    htmlstrBestProds += "<td>";
                    htmlstrBestProds += "<div class='product'>";

                    // Product Image
                    htmlstrBestProds += "<a href='About.aspx?ID=" + p.Id + "'>";
                    htmlstrBestProds += "<div class='product-img'>";
                    htmlstrBestProds += $"<div class='product__item__pic set-bg' data-setbg='{images[0]}' alt='{p.Product_Name}' style='background-image: url(&quot;{images[0]}&quot;);' />";
                    htmlstrBestProds += "</div>";
                    htmlstrBestProds += "</a>";
                    // Product Details (Category, Name, Price)
                    htmlstrBestProds += "<div class='product-body'>";
                    //< div class="product__item__pic set-bg" data-setbg="img/trending/trend-2.jpg" >
                    //                        <div class="ep">18 / 18</div>
                    //                        <div class="comment"><i class="fa fa-comments"></i> 11</div>
                    //                        <div class="view"><i class="fa fa-eye"></i> 9141</div>
                    //                    </div>

                    htmlstrBestProds += "<p class='product-category'>" + p.Category + "</p>";
                    htmlstrBestProds += "<a href = 'About.aspx?ID=" + p.Id + "'>" + "<h3 class='product-name'>" + p.Product_Name + "</h3></a>";
                    htmlstrBestProds += "<h4 style='color:red'>R" + Math.Round(p.Price, 2) + "</h4>";
                    if (Session["ID"] != null)
                    {

                        htmlstrBestProds += "<div class='add-to-cart'>";
                        htmlstrBestProds += $"<a href='Home.aspx?cart={p.Id}' class='add-to-cart-btn'><span><i class='fa fa-shopping-cart'></i> Add to cart</span> <i class='fa fa-angle-right'></i></a>";
                        htmlstrBestProds += "</div>";
                    }
                    htmlstrBestProds += "</div>";



                    counter++;
                }
            }
            htmlstrBestProds += "</tr></table>"; // Close the last row and table
            ProductList.InnerHtml = htmlstrBestProds;

            String hymlstrNewProds = "";
            hymlstrNewProds += "<div class='section-title'>";
            hymlstrNewProds += "<h5> New Comment</h5>";
            hymlstrNewProds += "</div>";

            dynamic newProds = rc.getNewProds();
            foreach (ServiceReference1.SysProduct p in newProds)
            {
                string[] images = JsonConvert.DeserializeObject<string[]>(p.Image_URL);
                hymlstrNewProds += "<div class='product_sidebarcomment_item'>";
                hymlstrNewProds += "<div class='product_sidebarcommentitem_pic'>";
                hymlstrNewProds += "<img src='" + images[0] + "' width='40%' height='40%' alt=''>";
                hymlstrNewProds += "</div>"; 
                hymlstrNewProds += "<div class='product_sidebarcommentitem_text'>";
                hymlstrNewProds += "<ul>";
                hymlstrNewProds += "<li>" + p.Category + "</li>";
                hymlstrNewProds += "</ul>";
                hymlstrNewProds += "<h5><a href='About.aspx?ID=" + p.Id + "'>" + p.Product_Name + "</a></h5>";
                hymlstrNewProds += "<span>";
                hymlstrNewProds += "<div class='anime_details_btn'>";
                //if they are logged in they will see the add to cart shandiz
                if (Session["ID"] != null)
                    hymlstrNewProds += $"<a href='Home.aspx?cart={p.Id}' class='watch-btn'><span> Add to cart</span> <i class='fa fa-angle-right'></i></a>";


                hymlstrNewProds += "</div>";
                hymlstrNewProds += "</span>";
                hymlstrNewProds += "</div>";
                hymlstrNewProds += "</div>";
            }

            Sidebarcontent.InnerHtml = hymlstrNewProds;
        }



        private void addCart()
        {

            if (Session["ID"] != null)
            {
                int uid = int.Parse(Session["ID"].ToString());
                int pid = int.Parse(Request.QueryString["cart"].ToString());

                if (rc.addToCart(uid, pid))
                {

                    Response.Redirect("Home.aspx");
                }
                else
                {
                    string script = $"alert('Could not add item to cart'); window.location.href='Home.aspx';";

                    ClientScript.RegisterStartupScript(this.GetType(), "alertRedirect", script, true);
                }


            }
            else
            {
                string script = $"alert('Could not add item to cart'); window.location.href='Home.aspx';";

                ClientScript.RegisterStartupScript(this.GetType(), "alertRedirect", script, true);
            }


        }

        //button for filering by 
        protected void btnFilterPrice_Click(object sender, EventArgs e)
        {
            int minPrice = int.Parse(txtPriceMin.Text);
            int maxPrice = int.Parse(txtPriceMax.Text);

            //filtering by price 
            LoadProducts(minPrice, maxPrice);
        }

        //button for sorting products 
        protected void btnAlpha(object sender, EventArgs e)
        {
            dynamic prods = rc.GetSortedProducts();
            SortByLetter(prods);
        }

        private void SortByLetter(dynamic SortedProds)
        {

            int counter = 0;
            String htmlstrBestProds = "<table class='table'>"; // Start of  table


            foreach (ServiceReference1.SysProduct p in SortedProds)
            {

                    string[] images = JsonConvert.DeserializeObject<string[]>(p.Image_URL);


                    if (counter % 3 == 0) // Every 3 products, start a new row
                    {
                        if (counter > 0)
                        {
                            htmlstrBestProds += "</tr>";
                        }
                        htmlstrBestProds += "<tr>"; // Start a new row
                    }






                    // Build HTML for each product
                    htmlstrBestProds += "<td>";
                    htmlstrBestProds += "<div class='product'>";

                    // Product Image
                    htmlstrBestProds += "<a href='About.aspx?ID=" + p.Id + "'>";
                    htmlstrBestProds += "<div class='product-img'>";
                    htmlstrBestProds += $"<div class='product__item__pic set-bg' data-setbg='{images[0]}' alt='{p.Product_Name}' style='background-image: url(&quot;{images[0]}&quot;);' />";
                    htmlstrBestProds += "</div>";
                    htmlstrBestProds += "</a>";
                    // Product Details (Category, Name, Price)
                    htmlstrBestProds += "<div class='product-body'>";
                    htmlstrBestProds += "<p class='product-category'>" + p.Category + "</p>";
                    htmlstrBestProds += "<a href = 'About.aspx?ID=" + p.Id + "'>" + "<h3 class='product-name'>" + p.Product_Name + "</h3></a>";
                    htmlstrBestProds += "<h4 style='color:red'>R" + Math.Round(p.Price, 2) + "</h4>";
                    if (Session["ID"] != null)
                    {

                        htmlstrBestProds += "<div class='add-to-cart'>";
                        htmlstrBestProds += $"<a href='Home.aspx?cart={p.Id}' class='add-to-cart-btn'><span><i class='fa fa-shopping-cart'></i> Add to cart</span> <i class='fa fa-angle-right'></i></a>";
                        htmlstrBestProds += "</div>";
                    }
                    htmlstrBestProds += "</div>";
                    counter++;
                }
            htmlstrBestProds += "</tr></table>"; // Close the last row and table
            ProductList.InnerHtml = htmlstrBestProds;

        }


        }

}
