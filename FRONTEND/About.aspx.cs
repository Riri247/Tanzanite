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
            if (Session["ID"] != null)
            {
                btnCart.Visible = true;

                your_rating_container.Visible = true;
            }
            else
            {
                btnCart.Visible = false;

                your_rating_container.Visible = false;

            }


            if (Request.QueryString["ID"] != null)
            {


                int id = int.Parse(Request.QueryString["ID"].ToString());
                product = rc.getProduct(id);
                images = JsonConvert.DeserializeObject<string[]>(product.Image_URL);

                cart_adder.HRef = "About.aspx?ID=" + id + "&cart=" + id;

                if (Request.QueryString["cart"] != null)
                {
                    addToCart();

                }

                PopulateProductDetails(id);


                //if they bought it already they can review
                //must be logged in
                if (Session["ID"] != null) {
                    if (rc.HasBoughtProduct(Convert.ToInt32(Session["ID"].ToString()), id))
                    {

                        your_rating_container.Visible = true;
                    }
                }
                    

            }
        }




        private void PopulateProductDetails(int productId)
        {
            var prod = rc.getProduct(productId);
            images = JsonConvert.DeserializeObject<string[]>(product.Image_URL);
            // Populate product details like image, price, and description
            ImageLit.Text = "<img src ='" + images[0] + "' alt ='' >";
            LitPrice.Text = "R" + Math.Round(prod.Price, 2);
            LitDescription.Text = prod.Decript;
            SysReview[] users = rc.getAllReviews(productId);

            if (User != null)
            {
                foreach (SysReview r in users)
                {
                    if (r != null)
                    {
                        concatRev(r.Review1, r.Star_Ratng);

                    }

                }
            }
        }

        private void concatRev(string text, int star)
        {
            string innerChild = $@"<div class='anime__review__item'>
                                                <div class='anime__review__item__pic'>
                                                </div>
                                                <div class='anime__review__item__text'>
                                                    <h6>Stars: <span>{star}</span></h6>
                                                    <p>
                                                        {text}
                                                    </p>
                                                </div>
                                            </div>";


            rev_cont.InnerHtml += innerChild;
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {

            int rid = rc.getInvoiceID(int.Parse(Session["ID"].ToString()), int.Parse(Request.QueryString["ID"].ToString()));

            try
            {

                string rev = txtReview.Value;
                int star = int.Parse(txtRate.Text);

                bool isvalid = rev.Length > 0 && star >= 0 && rid != 0;

                if (isvalid)
                {
                    rc.rateProduct(rid, int.Parse(Request.QueryString["ID"].ToString()), star, rev);
                }

            }
            catch (Exception)
            {

            }

        }

        private void addToCart()
        {
            int pid = int.Parse(Request.QueryString["ID"].ToString());
            if (Session["ID"] != null)
            {
                int uid = int.Parse(Session["ID"].ToString());
                


                string script = $"alert('Item added to cart'); window.location.href='About.aspx?ID={pid}';";

                ClientScript.RegisterStartupScript(this.GetType(), "alertRedirect", script, true);
            }
            else
            {
                string script = $"alert('Could not add item to cart'); window.location.href='About.aspx?ID={pid}';";

                ClientScript.RegisterStartupScript(this.GetType(), "alertRedirect", script, true);
            }


        
    }


}


}
