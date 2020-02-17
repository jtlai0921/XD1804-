<%@ WebService Language="C#" Class="ch11_3" %>

using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class ch11_3 : System.Web.Services.WebService
{
    [WebMethod]
    public int Add(int num1, int num2) 
    {
        return num1 + num2;
    }
    [WebMethod]
    public int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }
    [WebMethod]
    public int Multiple(int num1, int num2)
    {
        return num1 * num2;
    }
    [WebMethod]
    public int Divide(int num1, int num2)
    {
        return num1 / num2;
    }
}