using System;
using WcfClient.Purchase;

namespace WcfClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var makePurchaseRequest = new MakePurchaseRequest(new PurchaseRequest
                                                                  {
                                                                      customerId = 1, productId = 1, quantity = 3
                                                                  });
            PurchaseOrchestrations_PurchaseOrchestartion_PurchasePort client =
                new PurchaseOrchestrations_PurchaseOrchestartion_PurchasePortClient("BasicHttpBinding_ITwoWayAsync");
            var response = client.MakePurchase(makePurchaseRequest);
            Console.WriteLine(response.Error.Message);
            Console.Read();
        }
    }
}
