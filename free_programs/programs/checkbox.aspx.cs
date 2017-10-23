using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class checkbox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       if(CheckBox1.Checked == true)
        {
            CheckBox1.Text = "checked";
        }
       if (CheckBox1.Checked == false)
        {
            CheckBox1.Text = "unchecked";
        }
        
    }
}