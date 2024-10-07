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

            if (Session["ID"] == null)
                Response.Redirect("Home.aspx");

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
                ID = "image" + inputCount+1
            };

            image_url_holder.Controls.Add(txtImg);
            inputCount++;
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {

                string strName = name.Value;
                string strDescrip = description.Value;
                string strCat = category.Value;
                decimal dblPrice = decimal.Parse(price.Value);
                int intQuant = int.Parse(quantity.Value);
                bool blAvail = available.Checked;
                string strAgree = agreement.Value;
                List<String> arrImages = new List<String>();


                for (int i = 1; i <= inputCount; i++)
                {
                    arrImages[i] = ((TextBox)image_url_holder.FindControl("image" + 1)).Text;

                }


                if (product != null)
                {
                    


                }
                else
                {

                    if (rc.AddProduct(strDescrip, intQuant, dblPrice, int.Parse(Session["ID"].ToString()), arrImages.ToArray()))
                    {
                        response.ForeColor = System.Drawing.Color.Green;
                        response.Text = "Product Successully added to the database";
                    }
                    else
                    {
                        response.ForeColor = System.Drawing.Color.Red;
                        response.Text = "Product Could Not be added to the database";


                    }


                }
            }
            catch (Exception)
            {
                Response.Redirect("ManageOneP.aspx");
                response.ForeColor = System.Drawing.Color.Red;
                response.Text = "An error occurred, You are now creating a product.";
            }

        }
    }
}