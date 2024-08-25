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
        /// <returns>Returns a User if the login was successful, otherwise null.</returns>
        public User Login(string email, string password)
        {
            var query = from u in RentEaseDB.Users where u.Email == email && u.password == password 
                        select new User {
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
        /// <returns>Returns a Product if the ID matches, otherwise null.</returns>
        public Product getProduct(int ID)
        {
            var query = from p in RentEaseDB.Products where p.Id == ID select p;

            return query.FirstOrDefault();
        }

        /// <summary>
        /// This method gets all products.
        /// </summary>
        /// <returns>Returns a list of Product, otherwise null.</returns>
        public List<Product> getProducts()
        {
            var query = from p in RentEaseDB.Products select p;

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
            try { 

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
            var query = from u in RentEaseDB.Users where u.Id == ID 
                        select new User {
                            Email = u.Email,
                            Id = u.Id,
                            User_Type = u.User_Type,
                            Surname = u.Surname,
                            U_Name = u.U_Name
                            
                         };

             return query.FirstOrDefault();

        }










    }
}
