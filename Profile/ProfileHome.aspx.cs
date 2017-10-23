using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Profile_ProfileHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["New"] != null)
        {
            usernameLabel.Text = Session["New"].ToString();
        }
        else
        {
            Response.Redirect("~login/login.aspx");
        }
    }

    protected void logOutButton_Click(object sender, EventArgs e)
    {
        Session["New"] = null;
        Response.Redirect("~/login/login.aspx");
    }
}