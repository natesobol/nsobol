using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class registration_registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            conn.Open();
            string checkUser = "select count(*) from UserData where UserName='"+TextBoxUN.Text+"'";
            SqlCommand com = new SqlCommand(checkUser, conn);
            int i = Convert.ToInt32(com.ExecuteScalar().ToString());
            if (i == 1)
            {
                Response.Write("User already exists");
            }

            conn.Close();
        }
    }

    protected void submitButton_Click(object sender, EventArgs e)
    {
        try
        {
            //generate GUID
            Guid newGUID = Guid.NewGuid();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            conn.Open();
            string insertQuery = "insert into UserData (ID,UserName,Email,Password,Country) values (@ID ,@Uname , @email ,@password ,@country)";
            SqlCommand com = new SqlCommand(insertQuery, conn);
            com.Parameters.AddWithValue("@ID", newGUID.ToString());
            com.Parameters.AddWithValue("@Uname", TextBoxUN.Text);
            com.Parameters.AddWithValue("@email", TextBoxEmail.Text);
            com.Parameters.AddWithValue("@password", TextBoxPass.Text);
            com.Parameters.AddWithValue("@country", DropDownListCounty.SelectedItem.ToString());

            com.ExecuteNonQuery();
            Response.Redirect("Manager.aspx");
            Response.Write("Registration is successful");

            conn.Close();
        }
        catch (Exception ex)    
        {
            Response.Write("Error: " + ex.ToString());
        }
    }
  
}