using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FRONTEND.ServiceReference1;

namespace FRONTEND
{
    public partial class ManageP : System.Web.UI.Page
    {
        RentEaseClient Rs = new RentEaseClient();

        protected void Page_Load(object sender, EventArgs e)
        {


                        LoadPRoducts();





        }

            private void LoadPRoducts()
        {
                String producthtml = "";

                dynamic ListProds = Rs.getProducts();

                 ListProds = Rs.getProducts();


                 ListProds = Rs.GetMerchantProds(1);

            if (ListProds != null) {
                foreach (SysProduct p in ListProds)
                {
                    producthtml += $@"<div class='Scrollable'>
        <div class='NameBox'>
            <p>{p.Product_Name}<br>{p.Category}</p>   
            </div>

         <div class='btnbox'>
<div class='anime__details__btn'>
                                <a href='#' class='follow-btn'> Remove</a>      
                              <a href='ManageOneP.aspx?ID={p.Id}' class='follow-btn'> Edit</a>      
                            </div>
            </div>
    </div>";

                }

             scrollContain.InnerHtml = producthtml;
            }
        }
    }
}