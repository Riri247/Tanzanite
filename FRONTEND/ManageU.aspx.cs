using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FRONTEND.ServiceReference1;
namespace FRONTEND
{
    public partial class ManageU : System.Web.UI.Page
    {

        RentEaseClient Rs = new RentEaseClient();
        protected void Page_Load(object sender, EventArgs e)
        {


          

            if (!IsPostBack) {
                if (Session["U_Type"] != null)
                {
                    if (Session["U_Type"].ToString() == "Adm")
                    {
                        LoadUSers();

                    }
                    else { Response.Redirect("Home.aspx"); }



                }
                else { Response.Redirect("Home.aspx"); }
            }
        }

        private void LoadUSers()
        {
            String usehtml = "";

            dynamic ListUse = Rs.GetAllusers();

            if (ListUse != null) {

                foreach (SysUser U in ListUse) {
                    usehtml += $@"  <div class='Scrollable'>
        < div  class ='NameBox'>
            <p> {U.U_Name}</p>
        <p> {U.Email}</p>
        <p> {U.User_Type} </p>
            </div>
        

         <div class='btnbox>
<div class='anime__details__btn'>
                                <a href='#' class='follow-btn'> Remove</a>      
                                <a href ='EditUser.aspx?ID={U.Id}' class='follow-btn'> Edit</a>      
                            </div>
            </div>
    </div>";
                }

                ScrollDiv.InnerHtml = usehtml;
            }


        }
    }
}