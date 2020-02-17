using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
public partial class ch11_3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int result;
        ServiceReference1.ch11_3SoapClient webs = new ServiceReference1.ch11_3SoapClient();
        result = webs.Add(5, 8);
        Response.Write(result);
    }
}