using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FRONTEND.ServiceReference1;
using Newtonsoft.Json;
using System.Collections.Specialized;


namespace FRONTEND
{
    public partial class About : System.Web.UI.Page
    {
        RentEaseClient rc = new RentEaseClient();
        SysProduct product;
        string[] images;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    LoadProduct();
            //}
            if(Session["ID"]!=null)
            {
                btnSubmit.Visible = true;
                txtRate.Visible = true;
                txtRev.Visible = true;
            }
            else
            {
                txtRate.Visible = false;
                txtRev.Visible = false;
                btnSubmit.Visible = false;
            }

            if (Request.QueryString["ID"] != null)
            {


                int id = int.Parse(Request.QueryString["ID"].ToString());
                product = rc.getProduct(id);
                 images = JsonConvert.DeserializeObject<string[]>(product.Image_URL);

                PopulateProductDetails(id);
              
            }
        }


     

        private void PopulateProductDetails(int productId)
        {
            var prod = rc.getProduct(productId);
            images = JsonConvert.DeserializeObject<string[]>(product.Image_URL);
            // Populate product details like image, price, and description
            ImageLit.Text = "<img src ='" +images[0] + "' alt ='' >";
            LitPrice.Text = "R" + Math.Round(prod.Price, 2);
            LitDescription.Text = prod.Decript;
            SysReview[] users = rc.getAllReviews(productId);
             
            if(User!=null)
            {
                foreach (SysReview r in users)
                {
                    if(r!=null)
                    {
                        lblName.Text = r.Review1;
                        lblTheRate.Text = r.Star_Ratng.ToString();
                    }

                }
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {

            int rid = rc.getInvoiceID(int.Parse(Session["ID"].ToString()), int.Parse(Request.QueryString["ID"].ToString()));

            rc.rateProduct(rid, int.Parse(Request.QueryString["ID"].ToString()), int.Parse(txtRate.Text), txtRev.Text);




        }
    }



}


