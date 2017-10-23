using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class login_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void loginButton_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            conn.Open();
            string checkUser = "select count(*) from UserData where UserName='" + TextBoxUN.Text + "'";
            SqlCommand com = new SqlCommand(checkUser, conn);
            int i = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();
            if (i == 1)
            {
                conn.Open();
                string checkPasswordQuery = "select password from UserData where UserName='" + TextBoxUN.Text + "'";
                SqlCommand passComm = new SqlCommand(checkPasswordQuery, conn);
                string password = passComm.ExecuteScalar().ToString().Replace(" ", "");
                if (password == TextBoxPass.Text)
                {
                    Session["New"] = TextBoxUN.Text;
                    Response.Write("Password Verified");
                    Response.Redirect("~/Profile/ProfileHome.aspx");
                }
                else
                {
                    Response.Write("Password Incorrect");
                }
            }
            else
            {
                Response.Write("Username Incorrect");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex);

        }

        
    }
}