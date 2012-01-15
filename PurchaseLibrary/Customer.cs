using System;

namespace PurchaseHelper
{
    [Serializable]
    public class Customer
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public int Visits { get; set; }
    }
}
