﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_1_1 : System.Web.UI.Page
{
    protected void Button1_Click(object sender, EventArgs e)
    {  
        //宣告及設定初值
        int t, n, total = 1;
        n = int.Parse(TextBox1.Text);
        //處理
        for (t = 1; t <= n; t++)
        {
            total = total * t;
            total = short.Parse(total.ToString());//(將short改為int)
        }
        //輸出
        TextBox2.Text = total.ToString();
    }
}