using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.pdf;
using FRONTEND.ServiceReference1;
using System.IO;

namespace FRONTEND
{
    public partial class Invoice : System.Web.UI.Page
    {
        RentEaseClient serve = new RentEaseClient();
        protected void Page_Load(object sender, EventArgs e)
        {

            Session["ID"] = 7;

            Request.QueryString["sdgfh"].ToString();


            if (!IsPostBack)
            {
                Request.QueryString["sdgfh"].ToString();

                if (Session["ID"]!=null && Request.QueryString["InvoiceID"] != null)
                {
                    int userId = int.Parse(Session["ID"].ToString());
                    int invoiceId = int.Parse(Request.QueryString["InvoiceID"].ToString());

                    SysInvoice cartItems = serve.getInvoice(userId, invoiceId);

                    // Generate the PDF and get the file path
                    string pdfFilePath = GeneratePDF(userId, cartItems);


                    pdfViewer.Attributes["data"] = ResolveUrl("~/pdf/" + Path.GetFileName(pdfFilePath));
                    pdfSec.Attributes["href"] = ResolveUrl("~/pdf/" + Path.GetFileName(pdfFilePath));
                }
            }

        }
        //function for displaying pdf of invoice 
        private string GeneratePDF(int UserID,SysInvoice invoice)
        {
            //getting file path or where pdfs will be stored 
            string folderPath = Server.MapPath("~/pdf/");
           
            //create file path and place order 
            int Invoice_ID = invoice.invoice.invID;
            string filename = "Invoice_" + Invoice_ID + DateTime.Now.Ticks + ".pdf";
            string pdfPath = Path.Combine(folderPath, filename);

            //create the pdf
            Document doc = new Document(PageSize.A4, 50, 50, 25,25);
            FileStream fs = new FileStream(pdfPath, FileMode.Create);
            PdfWriter pw = PdfWriter.GetInstance(doc,fs);

            doc.Open(); //open file 

            Font bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);//assigning a font to the doc 
            doc.Add(new Paragraph("Invoice", bodyFont));
            doc.Add(new Paragraph("Your Email" + Session["Email"].ToString(),bodyFont));
            doc.Add(new Paragraph("Order Date: " + DateTime.Now.ToString("MM/dd/yyyy"), bodyFont));

            //addiing information into the doc 
            PdfPTable table = new PdfPTable(4); // 4 columns: Product Image, Name, Quantity, Price
            table.AddCell("Image");
            table.AddCell("Name");
            table.AddCell("Quantity");
            table.AddCell("Price");
            decimal total = 0;
            foreach(SysInvoiceProduct ip in invoice.products)
            {
                //display image 
                string imagePath = Server.MapPath(ip.product.Image_URL);
                iTextSharp.text.Image productImage = iTextSharp.text.Image.GetInstance(imagePath);
                productImage.ScaleToFit(50f, 50f);
                PdfPCell ImageT = new PdfPCell(productImage);
                ImageT.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(ImageT);
                //display other important info 
                table.AddCell(ip.product.Product_Name);
                table.AddCell(ip.orderProduct.Quantity.ToString());
                decimal Subtotal = (decimal)(ip.orderProduct.Price * ip.orderProduct.Quantity);
                total += Subtotal;
                table.AddCell(Subtotal.ToString());

            }
            
            // Add total row
            table.AddCell(""); // Empty cell for image
            table.AddCell("");
            table.AddCell("Total");
            table.AddCell(total.ToString());

            //add table 
            doc.Add(table);
            doc.Close();
            return pdfPath;
        }

    }
}