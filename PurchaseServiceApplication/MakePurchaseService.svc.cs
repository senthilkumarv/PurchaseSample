using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PurchaseServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MakePurchaseService" in code, svc and config file together.
    public class MakePurchaseService : IMakePurchaseService
    {
        public PurchaseResponse MakePurchase(PurchaseRequest purchaseRequest)
        {
            var purchaseResponse = new PurchaseResponse
                                       {
                                           CustomerId = purchaseRequest.CustomerId,
                                           Price = 100,
                                           Message = "Response",
                                           Visits = 10
                                       };


            var streamWriter = new StreamWriter(@"C:\Temp\WS.log", true);
            streamWriter.WriteLine(DateTime.Now + " " + purchaseRequest.CustomerId);
            streamWriter.Close();
            return purchaseResponse;
        }
    }
}
