using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cobro : System.Web.UI.Page
{
    Asiento asiento = new Asiento();
    Compra compra = new Compra();
    SetLabel setlabels = new SetLabel();

    protected void Page_Load(object sender, EventArgs e)
    {

        TableRow row = new TableRow();
        TableCell cell1 = new TableCell();
        cell1.Text = "blah blah blah";
        row.Cells.Add(cell1);
        tblBoletos.Rows.Add(row);

        setlabels.setlabelsCobro();

        lblDescripcion.Text= SetLabel.DescripcionCobro;
        lblHorario.Text= SetLabel.HorarioCobro;
        lblTranslado.Text = SetLabel.TransladoCobro;
        lblPrecioTranslado.Text= SetLabel.PrecioTransladoCobro;
        lblGraderia.Text= SetLabel.GraderiaCobro;
        lblPrecioUnidad.Text= SetLabel.PrecioUnidadCobro;
        lblCantidadAsientos.Text= SetLabel.CantAsientosCobro;
        lblTotal.Text= SetLabel.TotalCobro;
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        HttpContext.Current.Response.Redirect("Login.aspx");
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        asiento.setAsientosNull();
        compra.deleteCompraActual();
        HttpContext.Current.Response.Redirect("Login.aspx");
    }
}