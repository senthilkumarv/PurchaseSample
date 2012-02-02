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
                                                                      customerId = 1,
                                                                      productId = 5,
                                                                      quantity = 13
                                                                  });
            PurchaseOrchestrations_PurchaseOrchestartion_PurchasePort client =
                new PurchaseOrchestrations_PurchaseOrchestartion_PurchasePortClient("BasicHttpBinding_ITwoWayAsync");
            for (int i = 0; i < 10; i++)
            {

                var response = client.MakePurchase(makePurchaseRequest);
                Console.WriteLine(response.Error.Message);
            }

            Console.Read();
        }
    }
}
