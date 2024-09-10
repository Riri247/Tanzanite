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
            dynamic BestProds = rc.getBestProds();

            String htmlstrBestProds = "";
            foreach (Product p in BestProds)
            {
                htmlstrBestProds += "<div class='Scol-lg-4 col-md-6 col-sm-6'>";
                htmlstrBestProds += "<div class='product__item'>";
                htmlstrBestProds += "<div class='product__item__pic set-bg'data-setbg='img / trending / trend - 1.jpg'>";
                htmlstrBestProds += "<div class='ep'>18 / 18</div>"; //idk what this can be so i made it product price
                htmlstrBestProds += "<div class='comment'><i class='fa fa-comments'></i> 11</div>";
                htmlstrBestProds += "<div class='view'><i class='fa fa-eye'></i> 9141</div>";
                htmlstrBestProds += "</div>";
                htmlstrBestProds += "<div class='product__item__text'>";
                htmlstrBestProds += "<ul>";
                htmlstrBestProds += "< li > Active </ li >";
                htmlstrBestProds += "<li>Movie</li>";
                htmlstrBestProds += "</ul>";
                htmlstrBestProds += "<h5><a href = '#' > The Seven Deadly Sins: Wrath of the Gods</a></h5>";

                htmlstrBestProds += "</div>";
                htmlstrBestProds += "</div>";
                htmlstrBestProds += "</div>";
            }
            ProductList.InnerHtml=htmlstrBestProds;


            String hymlstrNewProds = "";
            hymlstrNewProds += "<div class= 'section-title'>";

            hymlstrNewProds += "<h5> New Comment</h5>";


      hymlstrNewProds +=   "</div>";
            BestProds = rc.getNewProds();
            foreach (Product p in BestProds)
            {
                hymlstrNewProds += "<div class='product__sidebar__comment__item'>";
                hymlstrNewProds += "<div class='product__sidebar__comment__item__pic'>";

                hymlstrNewProds += "<img src='img/sidebar/comment-1.jpg' alt= ''>";

                hymlstrNewProds += "</div>";

                hymlstrNewProds += "<div class='product__sidebar__comment__item__text'>";

                hymlstrNewProds += "<ul>";
                hymlstrNewProds += "<li>Active</li>";

                hymlstrNewProds += "<li>Movie</li>";

                hymlstrNewProds += "</ ul >";

                hymlstrNewProds += "<h5><a href = '#'>The Seven Deadly Sins: Wrath of the Gods</a></h5>";
                hymlstrNewProds += "<span><i class= 'fa fa-eye'></i>19.141 Viewes</span>";

                hymlstrNewProds += "</div>";

                hymlstrNewProds += "</div>";
            }

            Sidebarcontent.InnerHtml = hymlstrNewProds;

            
        }

       

        // private  GetList()
    }

        //<!-- Product section start-->
        //                    <div class="col-lg-4 col-md-6 col-sm-6">
        //                        <div class="product__item">
        //                            <div class="product__item__pic set-bg" data-setbg="img/trending/trend-1.jpg">
        //                                <div class="ep">18 / 18</div>
        //                                <div class="comment"><i class="fa fa-comments"></i> 11</div>
        //                                <div class="view"><i class="fa fa-eye"></i> 9141</div>
        //                            </div>
        //                            <div class="product__item__text">
        //                                <ul>
        //                                    <li>Active</li>
        //                                    <li>Movie</li>
        //                                </ul>
        //                                <h5><a href = "#" > The Seven Deadly Sins: Wrath of the Gods</a></h5>
        //                            </div>
        //                        </div>
        //                    </div>
        //                    <!-- Product section end-->
}



//new Comment sections
        // < div class= "section-title" >
 
        //     < h5 > New Comment </ h5 >
    
        //    </ div >
    
        //                        < !--side bar procust start-->
        //<div class= "product__sidebar__comment__item" >
        //    < div class= "product__sidebar__comment__item__pic" >
 
        //         < img src = "img/sidebar/comment-1.jpg" alt = "" >
    
        //        </ div >
    
        //        < div class= "product__sidebar__comment__item__text" >
     
        //             < ul >
     
        //                 < li > Active </ li >
     
        //                 < li > Movie </ li >
     
        //             </ ul >
     
        //             < h5 >< a href = "#" > The Seven Deadly Sins: Wrath of the Gods</a></h5>
        //        <span><i class= "fa fa-eye" ></ i > 19.141 Viewes </ span >
    
        //        </ div >
    
        //    </ div >
    
        //                        < !--side bar procust end-->