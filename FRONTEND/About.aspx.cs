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
    public partial class About : System.Web.UI.Page
    {
        RentEaseClient rc = new RentEaseClient();
        SysProduct product;
        SysReview[] reviews;
        string[] images;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    LoadProduct();
            //}

            if (Request.QueryString["ID"] != null)
            {


                int id = int.Parse(Request.QueryString["ID"].ToString());
              
                product = rc.getProduct(id);
                 images = JsonConvert.DeserializeObject<string[]>(product.Image_URL);
                reviews = rc.getAllReviews(id);

                LoadProduct();
                foreach (SysReview r in reviews)
                {
                    concat(r.Review1, r.Star_Ratng);
                }
            }
        }


        private void concat(string text, int rating)
        {
            string innerChild = $@"<div class='anime__review__item'>
                <div class='anime__review__item__text'>
                <h6> Star: {rating}</h6>
                <p>{text}</p>
                </div>
                </div>";

            divReviews.InnerHtml += innerChild;
        }

    private void LoadProduct()
        {
            String Descphtml = "";

            foreach (string f in images) {

                Descphtml = $@"<div class='hero__items set-bg' data-setbg='{f}'> <!-- Change image directory per loop-->
                        <div class='row'>
                        <div class='col-lg-6'>
                            <div class='hero__text'>
                                <div class='label'>{product.Category}</div> <!-- product type-->
                                <h2>Electronics</h2> <!-- Product name-->
                                <p>{product.Decript}</p> <!--- Description-->";

                //this varibale is to check of the user bought the thing its stand in value will be true for now but you guys change it witht he function
                bool CheckIfPurchased = true;

                //if the they purchased show the review button
                if (CheckIfPurchased) {
                    Descphtml = $@"    <a href ='#anime__details__form'>< span > Review </ span > <i class='fa fa-angle-right'></i></a> <!-- Review button must only be seen  when the user has bought it before-->";

                }
                Descphtml = $@"    </div>
                        </div>
                    </div>
                </div>";
            }
            Descriptiondiv.InnerHtml = Descphtml;



          //  string htmlstrProduct = "<div class='anime__details__text'>";
          //  htmlstrProduct += "<div class='anime__details__title'>";
          //  //Name
          //// error for some reason  htmlstrProduct += "<h3>"+Product.Name+"</h3>";

          //  //maker
          //  htmlstrProduct += "<span>Maker</span>";

          //  htmlstrProduct += "</div>";


          //  htmlstrProduct += "<div class='anime__details__rating'>";

          //  htmlstrProduct += "<div class='rating'>";
          //  //ratings idk if this will go
          //  htmlstrProduct += "<a href='#'><i class='fa fa-star'></i></a>";

          //  htmlstrProduct += "<a href='#'><i class='fa fa-star'></i></a>";

          //  htmlstrProduct += "<a href ='#'><i class='fa fa-star'></i></a>";

          //  htmlstrProduct += "<a href='#'><i class='fa fa-star'></i></a>";

          //  htmlstrProduct += "<a href='#'><i class='fa fa-star-half-o'></i></a>";

          //  htmlstrProduct += "</div>";

          //  htmlstrProduct += "<span>Number of votes</span>";
          //  htmlstrProduct += "</div>";
          //  //Discription
          // //error we dont have the proper function yet htmlstrProduct += "<p>" + Product.Description + "</p>";
          //  htmlstrProduct += "<div class='anime__details__widget'>";


          //  htmlstrProduct += "<div class='row'>";


          //  htmlstrProduct += "<div class='col -lg-6 col-md-6'>";


          //  htmlstrProduct += "<ul>";

          //  //additional detals may remove later
          //  htmlstrProduct += "<li><span>Type:</span> Type of thing</li>";
          //  htmlstrProduct += "<li><span>Studios:</span>category</li>";

          //  htmlstrProduct += "<li><span>Date aired:</span>Date added</li>";


          //  htmlstrProduct += "<li><span>Status:</span>status</li>";


          //  htmlstrProduct += "</ul>";


          //  htmlstrProduct += "</div>";


          //  htmlstrProduct += "<div class='col -lg-6 col-md-6'>";


          //  htmlstrProduct += "<ul>";

          //  //other descriptions
          //  htmlstrProduct += "<li><span>Scores:</span>7.31/1,515</li>";


          //  htmlstrProduct += "<li><span>Rating:</span>8.5/161times</li>";

          //  htmlstrProduct += "<li><span>Duration:</span>24 min/ep</li>";

          //  htmlstrProduct += "<li><span>Quality:</span>HD</li>";

          //  htmlstrProduct += "<li><span>Views:</span>131,541</li>";


          //  htmlstrProduct += "</ul>";

          //  htmlstrProduct += "</div>";

          //  htmlstrProduct += "</div>";

          //  htmlstrProduct += "</div>";

          //  htmlstrProduct += "<div class='anime__details__btn'>";


          //  htmlstrProduct += "<a href ='#' class='follow-btn'><i class='fa fa-heart-o'></i> Follow ??? idk if we need this </a>";

          //  htmlstrProduct += "< a href ='#' class='watch-btn'><span> Add to cart</span> <i";
          //  htmlstrProduct += "class= 'fa fa-angle-right'></i></a>";
          //  htmlstrProduct += "</div>";
          //  htmlstrProduct += "</div>";
        }
    }
}
