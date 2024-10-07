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
    public partial class ManageOneP : System.Web.UI.Page
    {
        SysProduct product;
        RentEaseClient rc = new RentEaseClient();
        int inputCount = 1;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ID"] != null)
                {
                    product = rc.getProduct(int.Parse(Request.QueryString["ID"].ToString()));
                    populate();

                }
            }
            else
            {
                
               RecreateTextBoxes();
            }

            

            if (product == null)
            {
                Response.Redirect("ManageOneP.aspx");
                response.ForeColor = System.Drawing.Color.Red;
                response.Text = "Could not find the product, You are now creating a product.";
            }
            else
            {
                response.ForeColor = System.Drawing.Color.Green;
                response.Text = "You are now creating a product.";
            }

        }

        private void RecreateTextBoxes()
        {
            throw new NotImplementedException();
        }

        private void populate()
        {
            if (product != null)
            {

                name.Value = product.Product_Name;
                description.Value = product.Decript;
                category.Value = product.Category;
                price.Value = product.Price.ToString("0.00");
                quantity.Value = product.Quantity.ToString();
                available.Checked = product.Available;
                agreement.Value = product.Rental_Agreement;

                String[] images = JsonConvert.DeserializeObject<String[]>(product.Image_URL);

                Controls.Remove(image1);
                int count = 1;

                foreach (String img in images){

                    TextBox txtImg = new TextBox()
                    {
                        Text = img,
                        CssClass = "Pinput",
                        ID = "image" + count
                    };
                  
                    image_url_holder.Controls.Add(txtImg);


                    count++;
                }
                inputCount = count;

            }

        }

        protected void addInput_Click(object sender, EventArgs e)
        {
            TextBox txtImg = new TextBox()
            {
                CssClass = "Pinput",
            };

            image_url_holder.Controls.Add(txtImg);
            inputCount++;
        }


    }
}