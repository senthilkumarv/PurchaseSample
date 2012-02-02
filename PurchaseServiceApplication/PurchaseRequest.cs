using System;
using System.ServiceModel;

[Serializable]
[MessageContract]
public class PurchaseRequest
{
    private int customerId;
    private int productId;
    private int quantity;

    [MessageBodyMember]
    public int CustomerId
    {
        get { return customerId; }
        set { customerId = value; }
    }

    [MessageBodyMember]
    public int ProductId
    {
        get { return productId; }
        set { productId = value; }
    }

    [MessageBodyMember]
    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }
}