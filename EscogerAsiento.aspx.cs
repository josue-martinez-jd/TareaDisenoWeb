using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EscogerAsiento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    private void onclickColor (Button btn)
    {
        if (btn.CssClass != "btn btn-danger")
        {
            btn.CssClass = "btn btn-danger";
        }
        else
        {
            btn.CssClass = "btn btn-success";
        }
    }

    protected void btnA1_Click(object sender, EventArgs e)
    {
        onclickColor(btnA1);
    }

    protected void btnA2_Click(object sender, EventArgs e)
    {
        onclickColor(btnA2);
    }

    protected void btnA3_Click(object sender, EventArgs e)
    {
        onclickColor(btnA3);
    }

    protected void btnA4_Click(object sender, EventArgs e)
    {
        onclickColor(btnA4);
    }

    protected void btnA5_Click(object sender, EventArgs e)
    {
        onclickColor(btnA5);
    }

    protected void btnB1_Click(object sender, EventArgs e)
    {
        onclickColor(btnB1);
    }

    protected void btnB2_Click(object sender, EventArgs e)
    {
        onclickColor(btnB2);
    }

    protected void btnB3_Click(object sender, EventArgs e)
    {
        onclickColor(btnB3);
    }

    protected void btnB4_Click(object sender, EventArgs e)
    {
        onclickColor(btnB4);
    }

    protected void btnB5_Click(object sender, EventArgs e)
    {
        onclickColor(btnB5);
    }

}