using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class calculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // checks if operands have been added
        if ((ddl1.Items.FindByText("+") == null))
        {
            ddl1.Items.Add(new ListItem("+"));
            ddl1.Items.Add(new ListItem("-"));
            ddl1.Items.Add(new ListItem("*"));
            ddl1.Items.Add(new ListItem("/"));
        }
    }

    protected void solveButton_Click(object sender, EventArgs e)
    {
        // Declaration 
        Decimal op1, op2;

        // Validation
        while (operand1.Text == "" || operand2.Text == "")
        {
        answer.Text = "invalid input";
        return;
        }
    
        op1 = Decimal.Parse(operand1.Text);
        op2 = Decimal.Parse(operand2.Text);

        if(ddl1.Text == "+")
        {
            answer.Text = Convert.ToString(op1 + op2);
        }
        else if(ddl1.Text == "-")
        {
            answer.Text = Convert.ToString(op1 - op2);
        }
        else if (ddl1.Text == "*")
        {
            answer.Text = Convert.ToString(op1 * op2);
        }
        else if (ddl1.Text == "/")
        {
            answer.Text = Convert.ToString(op1 / op2);
        }
    }
}