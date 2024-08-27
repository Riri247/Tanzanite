using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FRONTEND
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void AddInitialProducts()
        {
            ServiceReference1.RentEaseClient rentEaseService = new ServiceReference1.RentEaseClient();
            // Call your AddProduct method to insert products into the database
            rentEaseService.AddProduct("Clarens Sofa", 10, 400.00m, 1);
            rentEaseService.AddProduct("Baltimore Sofa", 10, 550.00m, 2);
            rentEaseService.AddProduct("Montagu Sofa", 5, 450.00m, 3);
            rentEaseService.AddProduct("Ashton Chair", 8, 370.00m, 4);
            rentEaseService.AddProduct("Campbell Chair", 6, 400.00m, 5);
            rentEaseService.AddProduct("Ballito Chair", 4, 200.00m, 6);
            rentEaseService.AddProduct("Hamilton Chair", 4, 550.00m, 7);
            rentEaseService.AddProduct("Centurion Table", 3, 550.00m, 8);
            rentEaseService.AddProduct("Derby Table", 5, 200.00m, 9);
            rentEaseService.AddProduct("Molteno Table", 12, 300.00m, 10);
            rentEaseService.AddProduct("Designer Book Drawer", 10, 600.00m, 11);
            rentEaseService.AddProduct("Lamp Stand", 4, 400.00m, 12);
            rentEaseService.AddProduct("Designer Chairs", 8, 580.00m, 13);
            rentEaseService.AddProduct("Orange Leather Couch", 3, 600.00m, 14);
            rentEaseService.AddProduct("Computer Stand", 20, 300.00m, 15);
            rentEaseService.AddProduct("George Lamp", 10, 300.00m, 16);
            rentEaseService.AddProduct("Heidelberg Lamp", 10, 200.00m, 17);
            rentEaseService.AddProduct("Infantana Lamp", 20, 150.00m, 18);
            rentEaseService.AddProduct("Biggie Furniture Movers", 1, 1400.00m, 19);
            rentEaseService.AddProduct("Storage Rentals", 40, 460.00m, 20);

            // Add more products as needed
        }
    }
}