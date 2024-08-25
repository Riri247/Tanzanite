using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RentEase_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRentEase" in both code and config file together.
    [ServiceContract]
    public interface IRentEase
    {

        
        [OperationContract]
        User Login(string email, string password);

        [OperationContract]
        bool Register(string email, string password, string name, string surname);

        [OperationContract]
        Product getProduct(int ID);

        [OperationContract]
        List<Product> getProducts();

        [OperationContract]
        bool addToCart(int UserID, int ProductID);

        [OperationContract]
        bool removeFromCart(int UserID, int ProductID);

        [OperationContract]
        List<Product> getUserCart(int ID);

        [OperationContract]
        User getUser(int ID);

    }
}
