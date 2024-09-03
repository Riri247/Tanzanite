using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RentEase_Service
{
    public class ProductImage
    {
            public Product Product { get; set; }
            public Image Image { get; set; }
    }
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRentEase" in both code and config file together.
    [ServiceContract]
    public interface IRentEase
    {
        

        
        [OperationContract]
        User Login(string email, string password);

        [OperationContract]
        bool Register(string email, string password, string name, string surname);

        [OperationContract]
        ProductImage getProduct(int ID);

        [OperationContract]
        List<ProductImage> getProducts();

        [OperationContract]
        bool addToCart(int UserID, int ProductID);

        [OperationContract]
        bool removeFromCart(int UserID, int ProductID);

        [OperationContract]
        List<Product> getUserCart(int ID);

        [OperationContract]
        User getUser(int ID);

        [OperationContract]
        bool changePassword(int ID, string password);

        [OperationContract]
        bool AddProduct(string description, int quantity, decimal price, int merchantID, string[] images);

        [OperationContract]
        bool changeQuantity(int ID, int quantity);

        [OperationContract]
        bool changeDescription(int ID, string description);
        
        [OperationContract]
        bool changePrice(int ID, double price);

        [OperationContract]
        bool changePrice(int ID, string name);

        [OperationContract]
        bool removeProduct(int ID);

        [OperationContract]
        int placeOrder(int ID, Product[] arrProducts, int[] arrQuantities, int[] arrDurations);


        // method to deactivate user
        // method to make product unavailable
        // make report table
        // make complaint table

    }
}
