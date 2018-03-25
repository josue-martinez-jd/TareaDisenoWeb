using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EscogerEvento : System.Web.UI.Page
{
    Compra compra = new Compra();
    SetLabel setLabel = new SetLabel();

    protected void Page_Load(object sender, EventArgs e)
    {
        setLabel.setLabels();
        lblDescripcion1.Text= SetLabel.Descripcion1;
        lblArtista1.Text = SetLabel.Artista1;
        lblCostoEste1.Text = SetLabel.CostoEste1;
        lblCostoNorte1.Text = SetLabel.CostoNorte1;
        lblCostoOeste1.Text = SetLabel.CostoOeste1;
        lblCostoSur1.Text = SetLabel.CostoSur1;

        lblDescripcion2.Text = SetLabel.Descripcion2;
        lblArtista2.Text = SetLabel.Artista2;
        lblCostoEste2.Text = SetLabel.CostoEste2;
        lblCostoNorte2.Text = SetLabel.CostoNorte2;
        lblCostoOeste2.Text = SetLabel.CostoOeste2;
        lblCostoSur2.Text = SetLabel.CostoSur2;

        lblDescripcion3.Text = SetLabel.Descripcion3;
        lblArtista3.Text = SetLabel.Artista3;
        lblCostoEste3.Text = SetLabel.CostoEste3;
        lblCostoNorte3.Text = SetLabel.CostoNorte3;
        lblCostoOeste3.Text = SetLabel.CostoOeste3;
        lblCostoSur3.Text = SetLabel.CostoSur3;
    }


    protected void btnSiguiente_Click(object sender, EventArgs e)
    {
        Session["id_translado"]= Int32.Parse(btnTranslado.SelectedIndex.ToString())+1;
        compra.CrearCompra(Int32.Parse(Session["id_evento"].ToString()), Int32.Parse(Session["id_translado"].ToString()), Session["cedula"].ToString());
        compra.setCompraActual();

        HttpContext.Current.Response.Redirect("Index.aspx");
    }

    protected void btnEscogerEvento1_Click(object sender, EventArgs e)
    {
        Session["id_evento"] = 1;
    }

    protected void btnEscogerEvento2_Click(object sender, EventArgs e)
    {
        Session["id_evento"] = 2;
    }

    protected void btnEscogerEvento3_Click(object sender, EventArgs e)
    {
        Session["id_evento"] = 3;
    }
}