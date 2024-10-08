using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FRONTEND.ServiceReference1;
namespace FRONTEND
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    LoadProduct();
            //}
        }

        private void LoadProduct()
        {
            RentEaseClient rc = new RentEaseClient();

            int ID = Convert.ToInt32(Request.QueryString["ID"].ToString());
            var Product = rc.getProduct(ID);
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

 //< div class= "anime__details__text" >
 
 //   < div class= "anime__details__title" >
  
 //        < h3 > Product NAme </ h3 >
     
 //               < span > Maker </ span >
     
 //           </ div >
     
 //             < div class= "anime__details__rating" >
      
 //            < div class= "rating" >
       
 //             < a href = "#" >< i class= "fa fa-star" ></ i ></ a >
            
 //                 < a href = "#" >< i class= "fa fa-star" ></ i ></ a >
                 
 //         < a href = "#" >< i class= "fa fa-star" ></ i ></ a >
                      
 //    < a href = "#" >< i class= "fa fa-star" ></ i ></ a >
                           
 //       < a href = "#" >< i class= "fa fa-star-half-o" ></ i ></ a >
                                
 //            </ div >
                                
 //           < span > Number of votes</span>
 //                    </div>
 //                           <p>Description</p>
 //              <div class= "anime__details__widget" >
                                  
 //              < div class= "row" >
                                   
 //           < div class= "col-lg-6 col-md-6" >
                                    
 //            < ul >
                                    
 //             < li >< span > Type:</ span > Type of thing</li>
 //                   <li><span>Studios:</ span > category </ li >
                                           
 //          < li >< span > Date aired:</ span > Date added </ li >
                                                  
 //           < li >< span > Status:</ span > status </ li >
                                                       

 //             </ ul >
                                                       
 //             </ div >
                                                       
 //     < div class= "col-lg-6 col-md-6" >
                                                        
 //      < ul >
                                                        
 //     < li >< span > Scores:</ span > 7.31 / 1,515 </ li >
                                                               
 //       < li >< span > Rating:</ span > 8.5 / 161 times </ li >
                                                                      
                            //          < li >< span > Duration:</ span > 24 min / ep </ li >
                                                                             
                            //              < li >< span > Quality:</ span > HD </ li >
                                                                                  
                            //                      < li >< span > Views:</ span > 131,541 </ li >
                                                                                         
                            //                      </ ul >
                                                                                         
                            //                     </ div >
                                                                                         
                            //               </ div >
                                                                                         
                            //             </ div >
                                                                                         
                            //          < div class= "anime__details__btn" >
                                                                                          
                            //                < a href = "#" class= "follow-btn" >< i class= "fa fa-heart-o" ></ i > Follow ??? idk if we need this </ a >
                                                                                                    
                            //          < a href = "#" class= "watch-btn" >< span > Add to cart</span> <i
                            //       class= "fa fa-angle-right" ></ i ></ a >
                            //    </ div >
                            //</ div >


