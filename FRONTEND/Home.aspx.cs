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

        private void LoadProducts()
        {
            RentEaseClient rc = new RentEaseClient();
            dynamic Prods = rc.getProducts();

            String htmlstrBestProds = "";
            foreach (ServiceReference1.SysProduct p in Prods)
            {
                string[] images = JsonConvert.DeserializeObject<string[]>(p.Image_URL);


                htmlstrBestProds += "<div class='Scol-lg-4 col-md-6 col-sm-6'>";
                htmlstrBestProds += "<div class='product__item'>";
                htmlstrBestProds += "<img class='product_item_pic set-bg' src='"+images[0]+"' alt='none' width='50%' height='50%'/>";
                htmlstrBestProds += "<div class='ep'>R"+p.Price+"</div>";  
                htmlstrBestProds += "<span>";
                htmlstrBestProds += "<div class='anime_details_btn'>";
                //if they are logged in they will see the add to cart shandiz
                if (Session["ID"] != null) {
                    htmlstrBestProds += "<a href ='Cart.aspx?prodID=" + p.Id + "' class='watch-btn'><span> Add to cart</span> <i class='fa fa-angle-right'></i></a>";
                }
              
                htmlstrBestProds += "</div>";
                htmlstrBestProds += "</span>";
                htmlstrBestProds += "</div>";
                htmlstrBestProds += "<div class='product_item_text'>";
                htmlstrBestProds += "<h5><a href='About.aspx?id="+ p.Id+"'>"+ p.Product_Name+"</a></h5>";
                htmlstrBestProds += "</div>";
                htmlstrBestProds += "</div>";
            }
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