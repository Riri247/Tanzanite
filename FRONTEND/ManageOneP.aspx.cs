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

        protected void Page_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD

            if (Session["ID"] == null)
                Response.Redirect("Home.aspx");
=======
            /// ADMIN CHECK

>>>>>>> main

            if (!IsPostBack)
            {
                ViewState["inputCount"] = 1;

                if (Request.QueryString["ID"] != null)
                {
                    product = rc.getProduct(int.Parse(Request.QueryString["ID"]));
                    
                }

                if (product == null)
                {
                    response.ForeColor = System.Drawing.Color.Red;
                    response.Text = "Could not find the product, You are now creating a product.";
                }
                else
                {
                    response.ForeColor = System.Drawing.Color.Green;
                    response.Text = "You are now creating a product.";
                }
            }

            populate();
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
                image_url_holder.Controls.Clear(); // Clear previous controls
                int count = 1;

                foreach (String img in images)
                {
                    TextBox txtImg = new TextBox()
                    {
                        Text = img,
                        CssClass = "Pinput",
                        ID = "image" + count
                    };

                    image_url_holder.Controls.Add(txtImg);
                    count++;
                }
                ViewState["inputCount"] = count - 1; // Store count correctly
            }
            else
            {
                int currentCount = int.Parse(ViewState["inputCount"].ToString());

                for (int i = 1; i <= currentCount; i++)
                {
                    if (i != 1)
                    {
                        TextBox txtImg = new TextBox()
                        {
                            CssClass = "Pinput",
                            ID = "image" + i
                        };
                        txtImg.Attributes["placeholder"] = "Enter Value " + i;

                        image_url_holder.Controls.Add(txtImg);
                    }
                    
                }

            }
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
                List<string> arrImages = new List<string>();

                for (int i = 1; i <= int.Parse(ViewState["inputCount"].ToString()); i++)
                {
                    TextBox txtImg = (TextBox)image_url_holder.FindControl("image" + i);
                    if (txtImg != null)
                    {
                        arrImages.Add(txtImg.Text); // Add the image URL from the textbox to the list
                    }
                }

                if (product != null)
                {
                    if (rc.EditProduct(product.Id, strName, strDescrip, intQuant, dblPrice, product.M_ID, arrImages.ToArray()))
                    {
                        response.ForeColor = System.Drawing.Color.Green;
                        response.Text = "Product Successfully edited";

                        
                    }
                    else
                    {
                        response.ForeColor = System.Drawing.Color.Red;
                        response.Text = "Product Could Not be edited";
                    }
                }
                else
                {

                    int id = rc.AddProduct(strName, strDescrip, intQuant, dblPrice, int.Parse(Session["ID"].ToString()), arrImages.ToArray());

                    if (id != -1)
                    {
                        response.ForeColor = System.Drawing.Color.Green;
                        response.Text = "Product Successfully added to the database";
                        // get ID
                        Response.Redirect("ManageOneP.aspx?ID=" + id);
                    }
                    else
                    {
                        response.ForeColor = System.Drawing.Color.Red;
                        response.Text = "Product Could Not be added to the database";
                    }
                }
            }
            catch (Exception ex)
            {
                response.ForeColor = System.Drawing.Color.Red;
                response.Text = "An error occurred: " + ex.Message; // Display the specific error message
            }
        }

        protected void addInput_Click(object sender, EventArgs e)
        {
            int currentCount = int.Parse(ViewState["inputCount"].ToString());

         
            TextBox txtImg = new TextBox()
            {
                CssClass = "Pinput",
<<<<<<< HEAD
                ID = "image" + inputCount+1
=======
                ID = "image" + (currentCount + 1)
>>>>>>> main
            };
            txtImg.Attributes["placeholder"] = "Enter Value " + (currentCount + 1);

            image_url_holder.Controls.Add(txtImg);
            ViewState["inputCount"] = currentCount + 1; // Update count in ViewState
        }

<<<<<<< HEAD
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
=======
    
>>>>>>> main
    }
}
