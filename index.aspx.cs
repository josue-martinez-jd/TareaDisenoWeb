using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    Compra compra = new Compra();
    SetLabel setLabel = new SetLabel();

    protected void Page_Load(object sender, EventArgs e)
    {
        setLabel.setLabelsGraderia(1);
        setLabel.setLabelsGraderia(2);
        setLabel.setLabelsGraderia(3);
        setLabel.setLabelsGraderia(4);
        lblPrecioEste.Text = SetLabel.PrecioEste;
        lblPrecioNorte.Text = SetLabel.PrecioNorte;
        lblPrecioOeste.Text = SetLabel.PrecioOeste;
        lblPrecioSur.Text = SetLabel.PrecioSur;
        

    }

    protected void btnGraderiaEste_Click(object sender, EventArgs e)
    {
        Session["id_graderia"] = 3;
        compra.actualizarGraderia(Int32.Parse(Session["id_graderia"].ToString()), Int32.Parse(Session["id_compra"].ToString()));
        HttpContext.Current.Response.Redirect("EscogerAsiento.aspx");
    }

    protected void btnGraderiaNorte_Click(object sender, EventArgs e)
    {
        Session["id_graderia"] = 1;
        compra.actualizarGraderia(Int32.Parse(Session["id_graderia"].ToString()), Int32.Parse(Session["id_compra"].ToString()));
        HttpContext.Current.Response.Redirect("EscogerAsiento.aspx");
    }

    protected void btnGraderiaOeste_Click(object sender, EventArgs e)
    {
        Session["id_graderia"] = 4;
        compra.actualizarGraderia(Int32.Parse(Session["id_graderia"].ToString()), Int32.Parse(Session["id_compra"].ToString()));
        HttpContext.Current.Response.Redirect("EscogerAsiento.aspx");
    }

    protected void btnGraderiaSur_Click(object sender, EventArgs e)
    {
        Session["id_graderia"] = 2;
        compra.actualizarGraderia(Int32.Parse(Session["id_graderia"].ToString()), Int32.Parse(Session["id_compra"].ToString()));
        HttpContext.Current.Response.Redirect("EscogerAsiento.aspx");
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        compra.deleteCompraActual();
        HttpContext.Current.Response.Redirect("Index.aspx");
    }
}