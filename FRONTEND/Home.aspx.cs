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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProducts();
            }
        }
        /*//if they are logged in they will see the add to cart shandiz
           
										<button class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i> add to cart</button>
									</div>     
         */
        private void LoadProducts()
        {
            RentEaseClient rc = new RentEaseClient();
            dynamic Prods = rc.getProducts();
            int counter = 0;
            String htmlstrBestProds = "<table class='table'>"; // Start of  table
            foreach (ServiceReference1.SysProduct p in Prods)
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
                htmlstrBestProds += "<a href='About.aspx?id=" + p.Id + "'>";
                htmlstrBestProds += "<div class='product-img'>";
                htmlstrBestProds += "<img src='" + images[0] + "' alt='" + p.Product_Name + "' />";
                htmlstrBestProds += "</div>";
                htmlstrBestProds += "</ a >";
                // Product Details (Category, Name, Price)
                htmlstrBestProds += "<div class='product-body'>";
                htmlstrBestProds += "<p class='product-category'>" + p.Category + "</p>";
                htmlstrBestProds += "<a href = 'About.aspx?id=" + p.Id + "'>" + "<h3 class='product-name'>" + p.Product_Name + "</h3></a>";
                htmlstrBestProds += "<h4 style='color:red'>R" + Math.Round(p.Price, 2) + "</h4>";
                if (Session["ID"] != null) {
                    htmlstrBestProds+="<div class='add-to-cart'>";
                    htmlstrBestProds += "<a href ='Cart.aspx?prodID=" + p.Id + "' class='add-to-cart-btn'><span><i class='fa fa-shopping - cart'></i> Add to cart</span> <i class='fa fa-angle-right'></i></a>";
                    htmlstrBestProds += "</div>";
                }
                htmlstrBestProds += "</div>";



                counter++;
            }
            htmlstrBestProds += "</tr></table>"; // Close the last row and table
            ProductList.InnerHtml=htmlstrBestProds;

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
                hymlstrNewProds += "<img src='"+images[0]+"' width='40%' height='40%' alt=''>";
                hymlstrNewProds += "</div>";
                hymlstrNewProds += "<div class='product_sidebarcommentitem_text'>";
                hymlstrNewProds += "<ul>";
                hymlstrNewProds += "<li>"+p.Category+"</li>";
                hymlstrNewProds += "</ul>";
                hymlstrNewProds += "<h5><a href='About.aspx?=id"+p.Id+"'>"+p.Product_Name+"</a></h5>";
                hymlstrNewProds += "<span>";
                hymlstrNewProds += "<div class='anime_details_btn'>";
                //if they are logged in they will see the add to cart shandiz
                if (Session["ID"] != null)
                {
                    hymlstrNewProds += "<a href ='Cart.aspx?prodID=" + p.Id + "' class='watch-btn'><span> Add to cart</span> <i class='fa fa-angle-right'></i></a>";
                }
               
                hymlstrNewProds += "</div>";
                hymlstrNewProds += "</span>";
                hymlstrNewProds += "</div>";
                hymlstrNewProds += "</div>";
            }

            Sidebarcontent.InnerHtml = hymlstrNewProds;  
        }
    }
}