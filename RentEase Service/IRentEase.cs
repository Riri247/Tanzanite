using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RentEase_Service
{

    public class SysProduct
    {

        public int Id;
        public string Product_Name;
        public string Decript;
        public int Quantity;
        public decimal Price;
        public int M_ID;
        public bool Available;
        public string Rental_Agreement;
        public string Category;
        public DateTime Registration_Date;
        public string Image_URL;

    }


    public class SysUser
    {
        public int Id;
        public string U_Name;
        public string Surname;
        public string Email;
        public string User_Type;
        public string password;

    }

    public class SysShopping_Cart
    {
        public int P_ID;
        public int C_ID;
        public int Quantity;

    }

    public class CartProductWrapper
    {
        public SysProduct product;
        public SysShopping_Cart cart;
    }

    //making the returnable invoice thing
   
    public class GetInvoice {
        public int invID;
        public DateTime invDate;
        public decimal INvPrice;
    }

    public class SysReview
    {
        public int Invoice_ID;
        public int Product_ID;
        public int Star_Ratng;
        public string Review1;
    }



    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRentEase" in both code and config file together.
    [ServiceContract]
    public interface IRentEase
    {


        /// <summary>
        /// This method logis in a user.
        /// </summary>
        /// <param name="email">The email of the user logging in.</param>
        /// <param name="password">The password of the user logging in.</param>
        /// <returns>Returns a SysUser (Email, Id, User_Type) if the login was successful, otherwise null.</returns>
        [OperationContract]
        SysUser Login(string email, string password);

        /// <summary>
        /// This method registers a user.
        /// </summary>
        /// <param name="email">The email of the user being registered.</param>
        /// <param name="password">The password of the user being registered.</param>
        /// <param name="name">The name of the user being registered.</param>
        /// <param name="surname">The surname of the user being registered.</param>
        /// <returns>Returns true if an account was registered, otherwise false.</returns>
        [OperationContract]
        bool Register(string email, string password, string name, string surname);


        /// <summary>
        /// This method gets a product.
        /// </summary>
        /// <param name="ID">The ID of the product being queried.</param>
        /// <returns>Returns a SysProduct object which holds a Product's attributes and it's Images in a json string format if the ID matches, otherwise null.</returns>
        [OperationContract]
        SysProduct getProduct(int ID);

        /// <summary>
        /// This method gets all products.
        /// </summary>
        /// <returns>Returns a list of a SysProduct object where each holds it's Images in a json string format, otherwise null.</returns>
        [OperationContract]
        List<SysProduct> getProducts();


        /// <summary>
        /// This method adds a product to the user's shopping cart.
        /// </summary>
        /// <param name="UserID">The ID of the user.</param>
        /// <param name="ProductID">The ID of the product.</param>
        /// <returns>Returns true if the product was added to the cart, otherwise false.</returns>
        [OperationContract]
        bool addToCart(int UserID, int ProductID);


        /// <summary>
        /// This method removes a product from the user's shopping cart.
        /// </summary>
        /// <param name="UserID">The ID of the user.</param>
        /// <param name="ProductID">The ID of the product.</param>
        /// <returns>Returns true if the product was removed from the cart, otherwise false.</returns>
        [OperationContract]
        bool removeFromCart(int UserID, int ProductID);

        /// <summary>
        /// This method gets a user's shopping cart.
        /// </summary>
        /// <param name="ID">The ID of the user.</param>
        /// <returns>Returns a list of CartProductWrapper which is a class that holds a Product and a hopping_Cart, otherwise null.</returns>
        [OperationContract]
        List<CartProductWrapper> getUserCart(int ID);

        /// <summary>
        /// This method gets a user's data.
        /// </summary>
        /// <param name="ID">The ID of the user.</param>
        /// <returns>Returns a SysUser, otherwise null.</returns>
        [OperationContract]
        SysUser getUser(int ID);


        /// <summary>
        /// This method changes a user's password.
        /// </summary>
        /// <param name="ID">The ID of the user.</param>
        /// <returns>Returns true if the user's password was changed, otherwise false.</returns>
        [OperationContract]
        bool changePassword(int ID, string password);


        /// <summary>
        /// This method adds a product to the database.
        /// </summary>
        /// <param name="description">The description of the product.</param>
        /// <param name="quantity">The quantity of the product.</param>
        /// <param name="price">The price of the product.</param>
        /// <param name="merchantID">The ID of the merchant associated with the product.</param>
        /// <param name="images">The name/ link of the images of this product.</param>
        /// <returns>Returns true if the product was added successfully, otherwise false.</returns>
        [OperationContract]
        int AddProduct(string name, string description, int quantity, decimal price, int merchantID, string[] images);

        /// <summary>
        /// This method edits a product in the database.
        /// </summary>
        /// <param name="ProductID">The ID of the product being edited.</param>
        /// <param name="description">The description of the product.</param>
        /// <param name="quantity">The quantity of the product.</param>
        /// <param name="price">The price of the product.</param>
        /// <param name="merchantID">The ID of the merchant associated with the product.</param>
        /// <param name="images">The name/ link of the images of this product.</param>
        /// <returns>Returns true if the product was added successfully, otherwise false.</returns>
        [OperationContract]
        bool EditProduct(int ProductID, string name, string description, int quantity, decimal price, int merchantID, string[] images);


        /// <summary>
        /// This method changes a product's quantity.
        /// </summary>
        /// <param name="ID">The ID of the product being changed.</param>
        /// <returns>Returns true if the product specifications were changed successfully, otherwise false.</returns>
        [OperationContract]
        bool changeQuantity(int ID, int quantity);



        /// <summary>
        /// This method changes a product's description.
        /// </summary>
        /// <param name="ID">The ID of the product being changed.</param>
        /// <returns>Returns true if the product specifications were changed successfully, otherwise false.</returns>
        [OperationContract]
        bool changeDescription(int ID, string description);



        /// <summary>
        /// This method changes a product's price.
        /// </summary>
        /// <param name="ID">The ID of the product being changed.</param>
        /// <returns>Returns true if the product specifications were changed successfully, otherwise false.</returns>
        [OperationContract]
        bool changePrice(int ID, double price);


        /// <summary>
        /// This method changes a product's name.
        /// </summary>
        /// <param name="ID">The ID of the product being changed.</param>
        /// <returns>Returns true if the product specifications were changed successfully, otherwise false.</returns>
        [OperationContract]
        bool changeName(int ID, string name);


        /// <summary>
        /// This method deletes a product from the database.
        /// </summary>
        /// <param name="ID">The ID of the product being deleted.</param>
        /// <returns>Returns true if the product was deleted successfully, otherwise false.</returns>
        [OperationContract]
        bool removeProduct(int ID);


        /// <summary>
        /// This method creates an invoice and orders.
        /// All the arrays must be parallel arrays which have data parralel to (related to) the corresponding product in the array of products
        /// </summary>
        /// <param name="ID">The ID of the user.</param>
        /// <param name="cart">The shopping cart of products in the invoice.</param>
        /// <param name="arrDurations">The durations of the products in the invoice.</param>
        /// <returns>Returns the ID of the invoice if one was created, or -1 otherwise</returns>
        [OperationContract]
        int placeOrder(int ID, SysShopping_Cart[] cart, int[] arrDurations);


        /// <summary>
        /// This method rates a product in a user's invoice
        /// </summary>
        /// <param name="InvoiceID">The ID of the invoice the product belongs to</param>
        /// <param name="ProductID">The ID of the product/param>
        /// <param name="stars">The star rating</param>
        /// <param name="review">The text review of the product</param>
        /// <returns></returns>
        [OperationContract]
        bool rateProduct(int InvoiceID, int ProductID, int stars, string review);



        /// <summary>
        /// This method dactivates a product
        /// </summary>
        /// <param name="ID">ID of the product to be deactivated</param>
        /// <returns></returns>
        [OperationContract]
        bool deactivateProduct(int ID);

        /// <summary>
        /// This method dactivates a product
        /// </summary>
        /// <param name="UserID">ID of the user to be who made the review</param>
        /// <param name="InvoiceID">ID of the invoice the review belongs to</param>
        /// <param name="ProductID">ID of the product that the review belongs to</param>
        /// <returns>A review for a user</returns>
        [OperationContract]
        SysReview getReview(int UserID, int InvoiceID, int ProductID);


        /// <summary>
        /// This method dactivates a product
        /// </summary>
        /// <param name="ProductID">ID of the product that the review belongs to</param>
        /// <returns>A list of reviews for a user</returns>
        [OperationContract]
        List<SysReview> getAllReviews(int ProductID);



        /// <summary>
        /// Method to get the best products, determined by the product's average rating being above or equal to 3.5
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<SysProduct> getBestProds();

        //get by recent
        [OperationContract]
        List<SysProduct> getNewProds();


        /// <summary>
        /// Method returns the user invoices 
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns>
        /// Returns a list of the wrapper class invoices
        /// </returns>
        [OperationContract]
        List<GetInvoice> getUserInvoices(int UserID);

        /// <summary>
        /// Method to edit user data 
        /// </summary>
        /// <param name="OneUser"></param>
        [OperationContract]
        void EditUserData(SysUser OneUser);

        /// <summary>
        /// Method to get all users
        /// </summary>
        /// <returns>
        /// a list of user wrapper class
        /// </returns>
        [OperationContract]
        List<SysUser> GetAllusers();


        /// <summary>
        /// Method see if user has bought product
        /// </summary>
        /// <returns>
        /// true if the user bought, false otherwise
        /// </returns>
        [OperationContract]
        bool HasBoughtProduct(int UserID, int ProductID)
    }
}
