using System;
using System.ServiceModel;

[Serializable]
[MessageContract]
public class PurchaseResponse
{
    private int customerId;
    private int visits;
    private int price;
    private string message;

    [MessageBodyMember] 
    public int CustomerId
    {
        get { return customerId; }
        set { customerId = value; }
    }

    [MessageBodyMember] 
    public int Visits
    {
        get { return visits; }
        set { visits = value; }
    }

    [MessageBodyMember] 
    public int Price
    {
        get { return price; }
        set { price = value; }
    }

    [MessageBodyMember] 
    public string Message
    {
        get { return message; }
        set { message = value; }
    }
}