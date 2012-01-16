using System;
using WcfClient.Purchase;

namespace WcfClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Operation_1Request purchaseRequest = new Operation_1Request(new PurchaseRequest
                                                                            {
                                                                                customerId = 5,
                                                                                productId = 1,
                                                                                quantity = 3
                                                                            });
            PurchaseOrchestrations_PurchaseOrchestartion_PurchasePort client = new PurchaseOrchestrations_PurchaseOrchestartion_PurchasePortClient("BasicHttpBinding_ITwoWayAsync");
            var response = client.Operation_1(purchaseRequest);
            Console.Read();
        }
    }
}
