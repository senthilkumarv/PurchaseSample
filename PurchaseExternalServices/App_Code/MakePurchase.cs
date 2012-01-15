using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for MakePurchase
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class MakePurchase : System.Web.Services.WebService {

    public MakePurchase () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string ProcessPurchase()
    {
     
        var sw = new StreamWriter(@"C:\Temp\PurchaseProcess.txt", true);
        sw.WriteLine(DateTime.Now + " RequestRecived");
        return "Hello World";
    }
    
}
