using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FRONTEND.ServiceReference1;

namespace FRONTEND
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                LoadProducts();
            }
        }

        private void LoadProducts()
        {

			RentEaseClient rc = new RentEaseClient();
			//Laoding the category
			dynamic Prods= null; //dynamic list that can be any type of products
								 //if Category was passed as a parameter

			if (Request.QueryString["Category"].ToString() != null)
			{
				String Category = Request.QueryString["Category"].ToString();

				Prods = rc.getProdsByCat(Category);
			}
			//if client either wants the best or new products
			else if (Request.QueryString["Type"].ToString() != null) {
				String type = Request.QueryString["Type"].ToString();

				switch (type) {
					case "Best": {
							
							break;
						}

					case "New":
						{
							Prods = rc.getNewProds();
							break;
						}
				}
			}

			//cehcking if the list has stuff else go back to home page
			if (Prods != null)
			{
				String htmlstrProdList = "";
				foreach (Product p in Prods) {
					htmlstrProdList += "<tr>";
					htmlstrProdList += "<td>";
					htmlstrProdList += "<a href='About.aspx?ID="+p.Id+"'>";
					htmlstrProdList += p.Product_Name;
					htmlstrProdList += "</a>";

					htmlstrProdList += "</td>";

					htmlstrProdList += "<td>";

					htmlstrProdList += "<a href='About.aspx?ID=" + p.Id + "'>";

					htmlstrProdList += "<img src='"+ p.Images+"' alt='Playstation 5'>";

					htmlstrProdList += "</a>";

					htmlstrProdList += "</td>";

					htmlstrProdList += "<td>";
					htmlstrProdList += p.Price;
					htmlstrProdList += "</td>";

					htmlstrProdList += "</tr>";
				}

				ContainerforRows.InnerHtml = htmlstrProdList;
			}
			else {
				Response.Redirect("Home.aspx");
			}
        }
    }
}

	//< !--product start-- >
	//	< tr >
	//		< td >
	//		< a href = "playstation_5.html" >
	//		 Playstation 5
	//		 </ a >
 
	//		 </ td >
 
	//		 < td >
 
	//		 < a href = "playstation_5.html" >
  
	//		  < img src = "https://i0.wp.com/allgamingconsoles.co.za/wp-content/uploads/2021/12/ps5.jpeg?fit=1500%2C1500&ssl=1" alt = "Playstation 5" >
	 
	//			 </ a >
	 
	//			 </ td >
	 
	//			 < td >
	//			 R15 000
	//			 </ td >
	 
	//		 </ tr >