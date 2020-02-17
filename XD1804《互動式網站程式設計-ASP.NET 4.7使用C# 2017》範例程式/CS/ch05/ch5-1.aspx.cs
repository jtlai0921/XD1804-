using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch5_1 : System.Web.UI.Page
{

    protected void Button1_Click(object sender, EventArgs e)
    {
        string temp = "";
        if (CheckBox1.Checked == true)
            temp += CheckBox1.Text + "\n";
        if (CheckBox2.Checked == true)
            temp += CheckBox2.Text + "\n";
        if (CheckBox3.Checked == true)
            temp += CheckBox3.Text + "\n";
        TextBox1.Text = temp;
    }
}