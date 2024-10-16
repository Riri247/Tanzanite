﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Newtonsoft.Json;

namespace RentEase_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RentEase" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RentEase.svc or RentEase.svc.cs at the Solution Explorer and start debugging.
    public class RentEase : IRentEase
    {
        RentDatadbmlDataContext RentEaseDB = new RentDatadbmlDataContext();


        public SysUser Login(string email, string password)
        {
            var query = from u in RentEaseDB.Users
                        where u.Email == email && u.password == password
                        select new SysUser
                        {
                            Email = u.Email,
                            Id = u.Id,
                            User_Type = u.User_Type
                        };

            return query.FirstOrDefault();
        }


        public bool isAccount(string email)
        {
            return RentEaseDB.Users.Any(u => u.Email == email);
        }


        public bool Register(string email, string password, string name, string surname)
        {
            //try
            //{
                if (isAccount(email))
                    return false;

                // create user
                var u = new User
                {
                    U_Name = name,
                    Surname = surname,
                    Email = email,
                    password = password,
                    User_Type = "Cus"
                };

                RentEaseDB.Users.InsertOnSubmit(u);
                RentEaseDB.SubmitChanges();
                return true;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);

            //    return false;
            //}
        }

        public SysProduct getProduct(int ID)
        {
            var query = from p in RentEaseDB.Products
                        where p.Id == ID
                        select new SysProduct
                        {
                            Id = p.Id,
                            Product_Name = p.Product_Name,
                            Quantity = p.Quantity,
                            Price = p.Price,
                            M_ID = p.M_ID,
                            Decript=p.Decript,
                            Available = p.Available,
                            Rental_Agreement = p.Rental_Agreement,
                            Category = p.Category,
                            Registration_Date = p.Registration_Date,
                            Image_URL = p.Image_URL
                        };

            return query.FirstOrDefault();
        }

        public List<SysProduct> getProducts()
        {
            var query = from p in RentEaseDB.Products
                        where p.Quantity > 0
                        select new SysProduct
                        {
                            Id = p.Id,
                            Decript = p.Decript,
                            Quantity = p.Quantity,
                            Image_URL = p.Image_URL,
                            Price = p.Price,
                            Category = p.Category,
                            Product_Name = p.Product_Name
                        };

            return query.DefaultIfEmpty().ToList();
        }


        public bool addToCart(int UserID, int ProductID)
        {

            if (checkcart(UserID, ProductID))
            {
                var query = (from sc in RentEaseDB.Shopping_carts
                             where sc.C_ID == UserID && sc.P_ID == ProductID
                             select sc).FirstOrDefault();

                if (query != null)
                {
                    // increase quantity

                    query.Quantity++;

                    RentEaseDB.SubmitChanges();
                    return true;

                }
                else { return false; }

            }
            else { createCart(UserID, ProductID);  return true; }

            return false;


        }


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



        public List<CartProductWrapper> getUserCart(int ID)
        {
            var query = from c in RentEaseDB.Shopping_carts
                        join p in RentEaseDB.Products
                        on c.P_ID equals p.Id
                        where c.C_ID == ID
                        select new CartProductWrapper
                        {
                            product = new SysProduct
                            {
                                Id = p.Id,
                                Product_Name = p.Product_Name,
                                Quantity = p.Quantity,
                                Price = p.Price,
                                M_ID = p.M_ID,
                                Available = p.Available,
                                Rental_Agreement = p.Rental_Agreement,
                                Category = p.Category,
                                Registration_Date = p.Registration_Date,
                                Image_URL = p.Image_URL

                            },

                            cart = new SysShopping_Cart
                            {
                                C_ID = c.C_ID,
                                P_ID = c.P_ID,
                                Quantity = c.Quantity
                            },

                            Duration = 1

                        };

            return query.DefaultIfEmpty().ToList();
        }



        public SysUser getUser(int ID)
        {
            var query = from u in RentEaseDB.Users
                        where u.Id == ID
                        select new SysUser
                        {
                            Email = u.Email,
                            Id = u.Id,
                            User_Type = u.User_Type,
                            Surname = u.Surname,
                            U_Name = u.U_Name
                        };

            return query.FirstOrDefault();
        }

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


        public int AddProduct(string name, string description, int quantity, decimal price, int merchantID, string[] images)
        {
            try
            {
                // create product
                var product = new Product
                {
                    Decript = description,
                    Quantity = quantity,
                    Price = price,
                    M_ID = merchantID,
                    Image_URL = JsonConvert.SerializeObject(images, Formatting.Indented)
                };

                RentEaseDB.Products.InsertOnSubmit(product);
                RentEaseDB.SubmitChanges();

                return product.Id;
            }
            catch (Exception)
            {
                return -1;
            }

        }

            public bool EditProduct(int ProductID, string name, string description, int quantity, decimal price, int merchantID, string[] images)
        {
            
            try
            {
                var query = from p in RentEaseDB.Products
                            where p.Id == ProductID && p.M_ID == merchantID
                            select p;

                Product product = query.FirstOrDefault();

                if (product != null)
                {
                    product.Product_Name = name;
                    product.Decript = description;
                    product.Quantity = quantity;
                    product.Price = price;
                    product.Image_URL = JsonConvert.SerializeObject(images, Formatting.Indented);

                    RentEaseDB.SubmitChanges();

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                return false;
            }

        }


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


        public bool changeName(int ID, string name)
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


        public int placeOrder(int ID, SysShopping_Cart[] cart, int[] arrDurations)
        {
            if (!(cart.Length == arrDurations.Length))
                return -1;

            int parrallel_length = cart.Length;

            try
            {
                // CREATE INVOICE
                Invoice invoice = new Invoice
                {
                    I_Date = new DateTime(),
                    Total_Quantity = 0,
                    Total_Cost = 0
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

                    invoice.Total_Quantity++;

                    // create new order
                    Order order = new Order
                    {
                        Invoice_ID = invoice_id,
                        Product_ID = cart[i].P_ID,
                        subTotal = getPrice(cart[i].P_ID),
                        Quantity = cart[i].Quantity,
                        Durantion = arrDurations[i]
                    };


                    invoice.Total_Cost += order.subTotal * order.Quantity;

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


        private decimal getPrice(int ID)
        {
            var query = from p in RentEaseDB.Products
                        where p.Id == ID
                        select p.Price;

            return query.FirstOrDefault();
        }



        public List<SysProduct> getBestProds()
        {
            var query = from p in RentEaseDB.Products
                        join r in RentEaseDB.Reviews
                        on p.Id equals r.Product_ID
                        group r by new
                        {
                            p.Id,
                            p.Product_Name,
                            p.Quantity,
                            p.Price,
                            p.M_ID,
                            p.Available,
                            p.Rental_Agreement,
                            p.Category,
                            p.Registration_Date,
                            p.Image_URL
                        } into productGroup
                        where productGroup.Average(r => r.Star_Rating) >= 3.5
                        select new SysProduct
                        {
                            Id = productGroup.Key.Id,
                            Product_Name = productGroup.Key.Product_Name,
                            Quantity = productGroup.Key.Quantity,
                            Price = productGroup.Key.Price,
                            M_ID = productGroup.Key.M_ID,
                            Available = productGroup.Key.Available,
                            Rental_Agreement = productGroup.Key.Rental_Agreement,
                            Category = productGroup.Key.Category,
                            Registration_Date = productGroup.Key.Registration_Date,
                            Image_URL = productGroup.Key.Image_URL
                        };


            return query.DefaultIfEmpty().ToList();
        }

        public List<SysProduct> getNewProds()
        {

            // Get the first day of the current month
            DateTime firstDayOfCurrentMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            var query = from p in RentEaseDB.Products
                            //finding products registered after the month
                        where p.Registration_Date > firstDayOfCurrentMonth
                        select new SysProduct
                        {
                            Id = p.Id,
                            Product_Name = p.Product_Name,
                            Quantity = p.Quantity,
                            Price = p.Price,
                            M_ID = p.M_ID,
                            Available = p.Available,
                            Rental_Agreement = p.Rental_Agreement,
                            Category = p.Category,
                            Registration_Date = p.Registration_Date,
                            Image_URL = p.Image_URL
                        };

            dynamic prodlist = query.DefaultIfEmpty().ToList();

            if (prodlist != null)
            {
                return prodlist;
            }
            else { return null; }
        }

        public int getInvoiceID(int UserID, int ProductID)
        {
            var query = from i in RentEaseDB.Customer_Invoices
                        join p in RentEaseDB.Orders
                        on i.Invoice_ID equals p.Invoice_ID
                        where i.C_ID == UserID
                        select i.Invoice_ID;


            return query.FirstOrDefault();
        }

        public bool rateProduct(int InvoiceID, int ProductID, int stars, string review)
        {

            Review tmpReview = new Review()
            {
                Invoice_ID = InvoiceID,
                Product_ID = ProductID,
                Star_Rating = stars,
                Review1 = review
            };



            try
            {
                RentEaseDB.Reviews.InsertOnSubmit(tmpReview);
                RentEaseDB.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deactivateProduct(int ID)
        {
            var query = from p in RentEaseDB.Products
                        where p.Id == ID
                        select p;

            Product product = query.FirstOrDefault();

            try
            {
                product.Available = false;

                RentEaseDB.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

        public List<GetInvoice> getUserInvoices(int UserID)
        {
            var ListInvoices = (from i in RentEaseDB.Customer_Invoices
                                    where i.C_ID == UserID
                                    select i).FirstOrDefault();




            if (ListInvoices != null)
            {
                List<GetInvoice> Listinv = new List<GetInvoice>();

                


                    //GetInvoice Temp = new GetInvoice();
                    //Temp.invID = ListInvoices.Invoice_ID;


                    dynamic Tempinv = (from i in RentEaseDB.Invoices
                                   where i.ID == ListInvoices.Invoice_ID
                                       select i).DefaultIfEmpty();

                    if (Tempinv != null)
                    {

                    foreach (Invoice i in Tempinv) {

                        Listinv.Add(new GetInvoice
                        {
                            invID = i.ID,
                            invDate = i.I_Date,
                            INvPrice = i.Total_Cost
                        });
                    }

                }

                   

               

                return Listinv;

            }
            else
            {
                return null;
            }

        }

        public SysInvoice getInvoice(int UserID, int InvoiceID)
        {
            SysInvoice invoice = new SysInvoice();

            var query = (from i in RentEaseDB.Invoices
                       where i.ID == InvoiceID
                       select new GetInvoice
                       { 
                               invID = i.ID,
                               invDate = i.I_Date,
                               INvPrice = i.Total_Cost
                       }).FirstOrDefault();



            if (query != null)
            {
                invoice.invoice = query;

                var query2 = (from o in RentEaseDB.Orders
                              where o.Invoice_ID == InvoiceID
                              join p in RentEaseDB.Products
                              on o.Product_ID equals p.Id
                              select new SysInvoiceProduct
                              {
                                  orderProduct = new SysOrder
                                  {
                                      Invoice_ID = o.Invoice_ID,
                                      Product_ID = o.Product_ID,
                                      Quantity = o.Quantity,
                                      subTotal = o.subTotal,
                                      Duration = o.Durantion,
                                      Price = o.Price

                                  },

                                  product = new SysProduct
                                  {
                                      Id = p.Id,
                                      Product_Name = p.Product_Name,
                                      Quantity = p.Quantity,
                                      Price = p.Price,
                                      M_ID = p.M_ID,
                                      Available = p.Available,
                                      Rental_Agreement = p.Rental_Agreement,
                                      Category = p.Category,
                                      Registration_Date = p.Registration_Date,
                                      Image_URL = p.Image_URL
                                  }
  
                            }).DefaultIfEmpty().ToList();
                            
                invoice.products = query2;

                return invoice;


            }
            else
            {
                return null;
            }


        }


        public SysReview getReview(int UserID, int InvoiceID, int ProductID)
        {

            var query = from r in RentEaseDB.Reviews
                        join i in RentEaseDB.Invoices
                        on r.Invoice_ID equals i.ID
                        join ci in RentEaseDB.Customer_Invoices
                        on r.Invoice_ID equals ci.Invoice_ID
                        select new SysReview
                        {
                            Invoice_ID = r.Invoice_ID,
                            Product_ID = r.Product_ID,
                            Star_Ratng = r.Star_Rating,
                            Review1 = r.Review1

                        };

            return query.FirstOrDefault();

        }


        public List<SysReview> getAllReviews(int ProductID)
        {

            var quary = from r in RentEaseDB.Reviews
                        where r.Product_ID == ProductID
                        select new SysReview
                        {
                            Invoice_ID = r.Invoice_ID,
                            Product_ID = r.Product_ID,
                            Star_Ratng = r.Star_Rating,
                            Review1 = r.Review1
                        };

            return quary.DefaultIfEmpty().ToList();
        }

        public void EditUserData(SysUser OneUser)
        {
            var sysUser = (from u in RentEaseDB.Users
                           where u.Id == OneUser.Id
                           select u).FirstOrDefault();
            if (sysUser != null)
            {
                try
                {
                    //editing userr data
                    
                    sysUser.U_Name = OneUser.U_Name;
                    Console.Write($@"Name {OneUser.U_Name}");
                    sysUser.Surname = OneUser.Surname;
                    Console.Write($@"Name {OneUser.Surname}");
                    sysUser.Email = OneUser.Email;
                    Console.Write($@"Name {OneUser.Email}");
                    sysUser.User_Type = OneUser.User_Type;
                    Console.Write($@"Name {OneUser.User_Type}");

                    if (!String.IsNullOrEmpty(OneUser.password)) {
                        sysUser.password = OneUser.password;
                    }

                    
                    RentEaseDB.SubmitChanges();
                }
                catch(Exception e)
                {
                    Console.Write(e.Message);
                }
            }
            else
            {
                return;
            }
        }

        public List<SysUser> GetAllusers()
        {
            dynamic query = (from u in RentEaseDB.Users
                             select u).DefaultIfEmpty();


            List<SysUser> LisUSer = new List<SysUser>();

            if (query != null)
            {
                foreach (User u in query)
                {
                    LisUSer.Add(new
                    SysUser
                    {
                        Email = u.Email,
                        Id = u.Id,
                        User_Type = u.User_Type,
                        Surname = u.Surname,
                        U_Name = u.U_Name
                    });

                }
                return LisUSer;
            }
            else { return null; }


          


        }

        public bool HasBoughtProduct(int UserID, int ProductID)
        {
            var query = from ip in RentEaseDB.Orders
                        join i in RentEaseDB.Customer_Invoices
                        on ip.Invoice_ID equals i.C_ID
                        where ip.Product_ID == ProductID && i.C_ID == UserID
                        select ip;

            // Check if any results were returned
            return query.Any();
        }

        public List<SysProduct> GetMerchantProds(int MerchatID)
        {
            // Get the first day of the current month
            DateTime firstDayOfCurrentMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            var query = from p in RentEaseDB.Products
                            //finding products registered after the month
                        where p.M_ID == MerchatID
                        select new SysProduct
                        {
                            Id = p.Id,
                            Product_Name = p.Product_Name,
                            Quantity = p.Quantity,
                            Price = p.Price,
                            M_ID = p.M_ID,
                            Available = p.Available,
                            Rental_Agreement = p.Rental_Agreement,
                            Category = p.Category,
                            Registration_Date = p.Registration_Date,
                            Image_URL = p.Image_URL
                        };

            dynamic prodlist = query.DefaultIfEmpty().ToList();

            if (prodlist != null)
            {
                return prodlist;
            }
            else { return null; }
        }

        public bool checkcart(int useId, int prodID)
        {
            var TempCart = (from ci in RentEaseDB.Shopping_carts
                            where ci.C_ID == useId & ci.P_ID == prodID
                            select ci).FirstOrDefault();


            if (TempCart != null) {
                return true;
            }
            return false;
        
        }

        public void createCart(int useId, int prodID)
        {
            var s = new Shopping_cart
            {
                P_ID = prodID,
                C_ID = useId,
                Quantity = 1
            };

            RentEaseDB.Shopping_carts.InsertOnSubmit(s);
            RentEaseDB.SubmitChanges();
        }

        
    public List<SysProduct> GetSortedProducts()
    {
        // Fetch the list of products from the database where Quantity > 0
        dynamic listProducts = (from p in RentEaseDB.Products
                            where p.Quantity > 0
                            select p).ToList();

        // Initialize the list of tProduct
        List<SysProduct> sortedProducts = new List<SysProduct>();

        // Check if the list is not empty
        if (listProducts != null)
        {
            // Convert each Product entity to tProduct
            foreach (Product p in listProducts)
            {
                SysProduct tProd = new SysProduct
                {
                   Id=p.Id,
                   Product_Name=p.Product_Name,
                   Decript=p.Decript,
                   Quantity=p.Quantity,
                   Price=p.Price,
                    M_ID=p.M_ID,
                    Available=p.Available,
                    Rental_Agreement=p.Rental_Agreement,
                    Category=p.Category,
                    Registration_Date=p.Registration_Date,
                    Image_URL=p.Image_URL,
                };
                sortedProducts.Add(tProd);
            }

            // Sort the list by product name in alphabetical order (case-insensitive)
            sortedProducts.Sort((x, y) => string.Compare(x.Product_Name, y.Product_Name, StringComparison.OrdinalIgnoreCase));
        }

        // Return the sorted list of tProduct (empty if no data was found)
        return sortedProducts;
    }

        public void EditCart(int UserId, int ProductId, int Quantity)
        {
            var cartToDelete = RentEaseDB.Shopping_carts.FirstOrDefault(c => c.C_ID == UserId && c.P_ID == ProductId);

            // If the cart exists
            if (cartToDelete != null)
            {
                cartToDelete.Quantity = Quantity;
                RentEaseDB.SubmitChanges();
               
            }
        }
    }
}
