﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch7_4_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //文字模式計數器                    
        Application["ArriveCounter"] = Convert.ToInt32(Application["ArriveCounter"]) + 1;
        Response.Write("《這是一個文字模式計數器》" + "<br>");
        Response.Write("你是本站的第" + Application["ArriveCounter"] + "位貴賓");
    }
}