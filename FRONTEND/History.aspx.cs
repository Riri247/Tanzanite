using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FRONTEND.ServiceReference1;

namespace FRONTEND
{
    public partial class History : System.Web.UI.Page
    {

        RentEaseClient Rs = new RentEaseClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if not reloaded load invoices for that user
            if (!IsPostBack) {
                LoadInvoices();
            }
        }

        private void LoadInvoices()
        {

            //if they are logged inn generate the invoices else take them back to the home page
            if (Session["ID"] != null) {
                //maing the id a int
                int CusID = Convert.ToInt32(Session["ID"].ToString());
                dynamic ListInvoices = Rs.getUserInvoices(CusID);
                String Scrollhtml = "";
                if (ListInvoices != null) {
                    foreach (GetInvoice gi in ListInvoices) {
                        Scrollhtml = $@"<div class='Scrollable'>";

 Scrollhtml = $@"<div class = 'NameBox'>";

                        Scrollhtml = $@"<p> {gi.invID}</p>";

                        Scrollhtml = $@"<p>{gi.invDate} </p>";


                        Scrollhtml = $@"</div>";



                        Scrollhtml = $@" <div class='btnbox'>";
                        Scrollhtml = $@"< div class='anime__details__btn'>";

                        Scrollhtml = $@"<a href='Invoice.aspx?ID={gi.invID}' class='follow-btn'> View </a>";



                        Scrollhtml = $@"</div>";

                        Scrollhtml = $@"</div>";

                        Scrollhtml = $@"</div>";

                    }

}                   divScrool.InnerHtml = Scrollhtml;

            } else {
                Response.Redirect("Home.aspx");
            }
        }
    }
}


 //< div class= "Scrollable" >
 
 //        < div  class = "NameBox" >
  
 //             < p > INvoice NUm </ p >
    
 //           < p > INvoice Date </ p >
      

 //                 </ div >
      


 //              < div class= "btnbox" >
 //      < div class= "anime__details__btn" >
        
 //                                       < a href = "#" class= "follow-btn" > View </ a >
           

 //                                      </ div >
           
 //                      </ div >
           
 //              </ div >