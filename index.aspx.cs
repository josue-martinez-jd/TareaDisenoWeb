using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    Compra compra = new Compra();

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnClubLounge_Click(object sender, EventArgs e)
    {
        


    }

    protected void btnGraderiaEste_Click(object sender, EventArgs e)
    {
        compra.actualizarGraderia(3, Int32.Parse(Session["id_compra"].ToString()));
        HttpContext.Current.Response.Redirect("EscogerAsiento.aspx");
    }

    protected void btnGraderiaNorte_Click(object sender, EventArgs e)
    {
        compra.actualizarGraderia(1, Int32.Parse(Session["id_compra"].ToString()));
        HttpContext.Current.Response.Redirect("EscogerAsiento.aspx");
    }

    protected void btnGraderiaOeste_Click(object sender, EventArgs e)
    {
        compra.actualizarGraderia(4, Int32.Parse(Session["id_compra"].ToString()));
        HttpContext.Current.Response.Redirect("EscogerAsiento.aspx");
    }

    protected void btnGraderiaSur_Click(object sender, EventArgs e)
    {
        compra.actualizarGraderia(2, Int32.Parse(Session["id_compra"].ToString()));
        HttpContext.Current.Response.Redirect("EscogerAsiento.aspx");
    }
}