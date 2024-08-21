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
        void Login();
        //function for getting stats for merchants 
        //how many products they rented out 
        //number of people who rented their products 
        //and the profit they have made overall
        [OperationContract]
        void GetStats();
    }
}
