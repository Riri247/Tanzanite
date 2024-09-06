using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RentEase_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RentEase" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RentEase.svc or RentEase.svc.cs at the Solution Explorer and start debugging.
    public class RentEase : IRentEase
    {
        RentDatadbmlDataContext RentEaseDB = new RentDatadbmlDataContext();

        /// <summary>
        /// This method logis in a user.
        /// </summary>
        /// <param name="email">The email of the user logging in.</param>
        /// <param name="password">The password of the user logging in.</param>
        /// <returns>Returns a User (Email, Id, User_Type) if the login was successful, otherwise null.</returns>
        public User Login(string email, string password)
        {
            var query = from u in RentEaseDB.Users
                        where u.Email == email && u.password == password
                        select new User
                        {
                            Email = u.Email,
                            Id = u.Id,
                            User_Type = u.User_Type
                        };

            return query.FirstOrDefault();
        }

        /// <summary>
        /// This method checks if an account exists with the given email.
        /// </summary>
        /// <param name="email">The email to check.</param>
        /// <returns>Returns true if an account exists, otherwise false.</returns>
        public bool isAccount(string email)
        {
            return RentEaseDB.Users.Any(u => u.Email == email);
        }

        /// <summary>
        /// This method registers a user.
        /// </summary>
        /// <param name="email">The email of the user being registered.</param>
        /// <param name="password">The password of the user being registered.</param>
        /// <param name="name">The name of the user being registered.</param>
        /// <param name="surname">The surname of the user being registered.</param>
        /// <returns>Returns true if an account was registered, otherwise false.</returns>
        public bool Register(string email, string password, string name, string surname)
        {
            try
            {
                if (isAccount(email))
                    return false;
                // create user
                var u = new User
                {
                    U_Name = name,
                    Surname = surname,
                    Email = email,
                    password = password,
                    User_Type = "Customer"

                };

                RentEaseDB.Users.InsertOnSubmit(u);
                RentEaseDB.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// This method gets a product.
        /// </summary>
        /// <param name="ID">The ID of the product being queried.</param>
        /// <returns>Returns an ProductImage object which holds a Product and it's Images if the ID matches, otherwise null.</returns>
        public ProductImage getProduct(int ID)
        {
            var query = from p in RentEaseDB.Products 
                        join img in RentEaseDB.Images on p.Id equals img.P_ID
                        where p.Id == ID 
                        select new ProductImage {
                            Product = p,
                            Image = img
                        };
;
            return query.FirstOrDefault();
        }

        /// <summary>
        /// This method gets all products.
        /// </summary>
        /// <returns>Returns a list of an ProductImage object where each Prodc=uctImage holds a Product and it's Images, otherwise null.</returns>
        public List<ProductImage> getProducts()
        {
            var query = from p in RentEaseDB.Products
                        join img in RentEaseDB.Images on p.Id equals img.P_ID
                        where p.Quantity > 0
                        select new ProductImage {
                            Product = new Product{
                                    Product_Name = p.Product_Name,
                                    Price = p.Price,
                                    Quantity = p.Quantity
                            },
                            Image = new Image {
                                Image_URL = img.Image_URL
                            }
                        };

            return query.DefaultIfEmpty().ToList();
        }

        /// <summary>
        /// This method adds a product to the user's shopping cart.
        /// </summary>
        /// <param name="UserID">The ID of the user.</param>
        /// <param name="ProductID">The ID of the product.</param>
        /// <returns>Returns true if the product was added to the cart, otherwise false.</returns>
        public bool addToCart(int UserID, int ProductID)
        {
            try
            {
                var s = new Shopping_cart
                {
                    P_ID = ProductID,
                    C_ID = UserID
                };

                RentEaseDB.Shopping_carts.InsertOnSubmit(s);
                RentEaseDB.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }

        /// <summary>
        /// This method removes a product from the user's shopping cart.
        /// </summary>
        /// <param name="UserID">The ID of the user.</param>
        /// <param name="ProductID">The ID of the product.</param>
        /// <returns>Returns true if the product was removed from the cart, otherwise false.</returns>
        public bool removeFromCart(int UserID, int ProductID)
        {
            // Find the user by ID
            var cartToDelete = RentEaseDB.Shopping_carts.FirstOrDefault(c => c.C_ID == UserID && c.P_ID == ProductID);

            // If the cart exists
            if (cartToDelete != null)
            {
                RentEaseDB.Shopping_carts.DeleteOnSubmit(cartToDelete);
                RentEaseDB.SubmitChanges();
                return true;
            }

            return false;
        }


        /// <summary>
        /// This method gets a user's shopping cart.
        /// </summary>
        /// <param name="ID">The ID of the user.</param>
        /// <returns>Returns a list of Product, otherwise null.</returns>
        public List<Product> getUserCart(int ID)
        {
            var query = from c in RentEaseDB.Shopping_carts
                        join p in RentEaseDB.Products
                        on c.P_ID equals p.Id
                        where c.C_ID == ID
                        select new Product
                        {
                            Id = p.Id,
                            Decript = p.Decript,
                            Quantity = p.Quantity,
                            Price = p.Price
                        };

            return query.DefaultIfEmpty().ToList();
        }


        /// <summary>
        /// This method gets a user's data.
        /// </summary>
        /// <param name="ID">The ID of the user.</param>
        /// <returns>Returns a User, otherwise null.</returns>
        public User getUser(int ID)
        {
            var query = from u in RentEaseDB.Users
                        where u.Id == ID
                        select new User
                        {
                            Email = u.Email,
                            Id = u.Id,
                            User_Type = u.User_Type,
                            Surname = u.Surname,
                            U_Name = u.U_Name

                        };

            return query.FirstOrDefault();

        }


        /// <summary>
        /// This method changes a user's password.
        /// </summary>
        /// <param name="ID">The ID of the user.</param>
        /// <returns>Returns true if the user's password was changed, otherwise false.</returns>
        public bool changePassword(int ID, string password)
        {
            // get user
            var user = (from u in RentEaseDB.Users
                        where u.Id == ID
                        select u).FirstOrDefault();

            // if user was found
            if (user != null)
            {
                // change password
                user.password = password;

                RentEaseDB.SubmitChanges();

                return true;
            }

            return false;
        }

        
        /// <summary>
        /// This method adds a product to the database.
        /// </summary>
        /// <param name="description">The description of the product.</param>
        /// <param name="quantity">The quantity of the product.</param>
        /// <param name="price">The price of the product.</param>
        /// <param name="merchantID">The ID of the merchant associated with the product.</param>
        /// <param name="images">The name/ link of the images of this product.</param>
        /// <returns>Returns true if the product was added successfully, otherwise false.</returns>
        public bool AddProduct(string description, int quantity, decimal price, int merchantID, string[] images)
        {
            try
            {
                // create product
                var product = new Product
                {
                    Decript = description,
                    Quantity = quantity,
                    Price = price,
                    M_ID = merchantID
                };

                RentEaseDB.Products.InsertOnSubmit(product);
                RentEaseDB.SubmitChanges();

                List<Image> lstImages = new List<Image>();
                int product_id = product.Id;

                // create Images
                foreach(string image in images){

                    var img = new Image {
                        P_ID = product_id,
                        Image_URL = image,
                    };

                    lstImages.Add(img);

                }

                RentEaseDB.Images.InsertAllOnSubmit(lstImages);
                RentEaseDB.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


        /// <summary>
        /// This method deletes a product from the database.
        /// </summary>
        /// <param name="ID">The ID of the product being deleted.</param>
        /// <returns>Returns true if the product was deleted successfully, otherwise false.</returns>
        public bool removeProduct(int ID)
        {
            // Find the product by ID
            var prodToDelete = RentEaseDB.Products.FirstOrDefault(p => p.Id == ID);

            // If the product exists
            if (prodToDelete != null)
            {
                RentEaseDB.Products.DeleteOnSubmit(prodToDelete);
                RentEaseDB.SubmitChanges();
                return true;
            }

            return false;
        }


        /// <summary>
        /// This method changes a product's quantity.
        /// </summary>
        /// <param name="ID">The ID of the product being changed.</param>
        /// <returns>Returns true if the product specifications were changed successfully, otherwise false.</returns>
        public bool changeQuantity(int ID, int quantity)
        {
            var prod = (from p in RentEaseDB.Products
                       where p.Id == ID
                       select p).FirstOrDefault();

            if (prod != null && quantity >= 0)
            {
                prod.Quantity = quantity;
                RentEaseDB.SubmitChanges();
                return true;
            }

            return false;

        }

        /// <summary>
        /// This method changes a product's description.
        /// </summary>
        /// <param name="ID">The ID of the product being changed.</param>
        /// <returns>Returns true if the product specifications were changed successfully, otherwise false.</returns>
        public bool changeDescription(int ID, string description)
        {
            var prod = (from p in RentEaseDB.Products
                       where p.Id == ID
                       select p).FirstOrDefault();

            if (prod != null)
            {
                prod.Decript = description;
                RentEaseDB.SubmitChanges();
                return true;
            }

            return false;

        }

        /// <summary>
        /// This method changes a product's price.
        /// </summary>
        /// <param name="ID">The ID of the product being changed.</param>
        /// <returns>Returns true if the product specifications were changed successfully, otherwise false.</returns>
        public bool changePrice(int ID, double price)
        {
            var prod = (from p in RentEaseDB.Products
                       where p.Id == ID
                       select p).FirstOrDefault();

            if (prod != null && price >= 0)
            {
                prod.Price = (decimal)price;
                RentEaseDB.SubmitChanges();
                return true;
            }

            return false;

        }


        /// <summary>
        /// This method changes a product's name.
        /// </summary>
        /// <param name="ID">The ID of the product being changed.</param>
        /// <returns>Returns true if the product specifications were changed successfully, otherwise false.</returns>
        public bool changePrice(int ID, string name)
        {
            var prod = (from p in RentEaseDB.Products
                       where p.Id == ID
                       select p).FirstOrDefault();

            if (prod != null)
            {
                prod.Product_Name = name;
                RentEaseDB.SubmitChanges();
                return true;
            }

            return false;

        }

        /// <summary>
        /// This method creates an invoice and orders.
        /// All the arrays must be parallel arrays which have data parralel to (related to) the corresponding product in the array of products
        /// </summary>
        /// <param name="ID">The ID of the user.</param>
        /// <param name="arrProducts">The products in the invoice.</param>
        /// <param name="arrQuantities">The quantities of the produts in the invoice.</param>
        /// <param name="arrDurations">The durations of the products in the invoice.</param>
        /// <returns>Returns the ID of the invoice if one was created, or -1 otherwise</returns>
        public int placeOrder(int ID, Product[] arrProducts, int[] arrQuantities, int[] arrDurations)
        {
            if (!(arrProducts.Length == arrDurations.Length && arrDurations.Length == arrQuantities.Length))
                return -1;
            
            int parrallel_length = arrProducts.Length;

            try
            {
                // CREATE INVOICE
                Invoice invoice = new Invoice
                {
                    I_Date = new DateTime()
                };

                RentEaseDB.Invoices.InsertOnSubmit(invoice);
                RentEaseDB.SubmitChanges();

                int invoice_id = invoice.ID;

                // CREATE CUSTOME INVOICE
                Customer_Invoice customer_Invoice = new Customer_Invoice
                {
                    C_ID = ID,
                    Invoice_ID = invoice_id
                };

                RentEaseDB.Customer_Invoices.InsertOnSubmit(customer_Invoice);
                RentEaseDB.SubmitChanges();

                List<Order> orders = new List<Order>();

                // CREATE ORDERS for every product in that invoice
                for (int i = 0; i < parrallel_length; i++)
                {
                    // create new order
                    Order order = new Order
                    {
                        Invoice_ID = invoice_id,
                        Product_ID = arrProducts[i].Id,
                        subTotal = arrProducts[i].Price,
                        Quantity = arrQuantities[i],
                        Durantion = arrDurations[i]
                    };
                    // add to list of orders
                    orders.Add(order);

                }

                RentEaseDB.Orders.InsertAllOnSubmit(orders);
                RentEaseDB.SubmitChanges();

                return invoice_id;

            }
            catch (Exception)
            {
                return -1;
            }

        }

        List<Product> IRentEase.getProdsByCat(string Category)
        {
            dynamic prodlist = (from p in RentEaseDB.Products
                                where p.Category == Category
                                select p).DefaultIfEmpty();

            if (prodlist != null)
            {
                List<Product> TempList = new List<Product>();
                foreach (Product p in prodlist)
                {
                    TempList.Add(p);
                }
                return TempList;
            }
            else { return null; }
        }

        List<Product> IRentEase.getBestProds()
        {
            throw new NotImplementedException();
        }

        List<Product> IRentEase.getNewProds()
        {

            // Get the first day of the current month
            DateTime firstDayOfCurrentMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            dynamic prodlist = (from p in RentEaseDB.Products
                                //finding products registered after the month
                                where p.Registration_Date > firstDayOfCurrentMonth
                                select p).DefaultIfEmpty();

            if (prodlist != null)
            {
                List<Product> TempList = new List<Product>();
                foreach (Product p in prodlist)
                {
                    TempList.Add(p);
                }
                return TempList;
            }
            else { return null; }
        }
    }
}
