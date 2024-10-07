using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FRONTEND.ServiceReference1;

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
                htmlstrBestProds += "<div class='Scol-lg-4 col-md-6 col-sm-6'>";
                htmlstrBestProds += "<div class='product__item'>";
                htmlstrBestProds += "<div class='product_item_pic set-bg' data-setbg='img/trending/trend-1.jpg'>";
                htmlstrBestProds += "<div class='ep'>R"+p.Price+"</div>";  
                htmlstrBestProds += "<span>";
                htmlstrBestProds += "<div class='anime_details_btn'>";
                htmlstrBestProds += "<a href ='Cart.aspx?prodID="+p.Id+"' class='watch-btn'><span> Add to cart</span> <i class='fa fa-angle-right'></i></a>";
                htmlstrBestProds += "</div>";
                htmlstrBestProds += "</span>";
                htmlstrBestProds += "</div>";
                htmlstrBestProds += "<div class='product_item_text'>";
                htmlstrBestProds += "<ul>";
                htmlstrBestProds += "<li>Active</li>";
                htmlstrBestProds += "<li>"+p.Category+"</li>";
                htmlstrBestProds += "</ul>";
                htmlstrBestProds += "<h5><a href='About.aspx?id="+ p.Id+"'>"+ p.Product_Name+"</a></h5>";
                htmlstrBestProds += "</div>";
                htmlstrBestProds += "</div>";
                htmlstrBestProds += "</div>";
            }
            ProductList.InnerHtml=htmlstrBestProds;

            String hymlstrNewProds = "";
            hymlstrNewProds += "<div class='section-title'>";
            hymlstrNewProds += "<h5> New Comment</h5>";
            hymlstrNewProds += "</div>";
           
            Prods = rc.getNewProds();
            foreach (ServiceReference1.SysProduct p in Prods)
            {
                hymlstrNewProds += "<div class='product_sidebarcomment_item'>";
                hymlstrNewProds += "<div class='product_sidebarcommentitem_pic'>";
                hymlstrNewProds += "<img src='img/sidebar/comment-1.jpg' alt=''>";
                hymlstrNewProds += "</div>";
                hymlstrNewProds += "<div class='product_sidebarcommentitem_text'>";
                hymlstrNewProds += "<ul>";
                hymlstrNewProds += "<li>"+p.Category+"</li>";
                hymlstrNewProds += "</ul>";
                hymlstrNewProds += "<h5><a href='About.aspx?=id"+p.Id+"'>"+p.Product_Name+"</a></h5>";
                hymlstrNewProds += "<span>";
                hymlstrNewProds += "<div class='anime_details_btn'>";
                hymlstrNewProds += "<a href ='Cart.aspx?prodID="+p.Id+"' class='watch-btn'><span> Add to cart</span> <i class='fa fa-angle-right'></i></a>";
                hymlstrNewProds += "</div>";
                hymlstrNewProds += "</span>";
                hymlstrNewProds += "</div>";
                hymlstrNewProds += "</div>";
            }
            Sidebarcontent.InnerHtml = hymlstrNewProds;  
        }
    }
}