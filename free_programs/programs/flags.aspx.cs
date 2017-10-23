using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class flags : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((flagDDL.Items.FindByText("US") == null))
        {
            flagDDL.Items.Add(new ListItem("US"));
            flagDDL.Items.Add(new ListItem("UK"));
            flagDDL.Items.Add(new ListItem("FR"));
            flagDDL.Items.Add(new ListItem("DE"));
        }
    }

    protected void changeFlag_Click(object sender, EventArgs e)
    {
        if (flagDDL.Text == "US")
        {
            flagImage.ImageUrl = "img/us.png";
        }
        else if(flagDDL.Text == "UK")
        {
            flagImage.ImageUrl = "img/gb.png";
        }
        else if(flagDDL.Text == "FR")
        {
            flagImage.ImageUrl = "img/fr.png";
        }
        else if(flagDDL.Text == "DE")
        {
            flagImage.ImageUrl = "img/de.png";
        }
    }
}