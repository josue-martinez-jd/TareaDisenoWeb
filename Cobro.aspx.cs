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

        if (!Page.IsPostBack)
        {
            Asiento.rondaActual = 0;
        }

        for (int i=0; Asiento.cantAsientos > i; i++)
        {
            tblBoletos.Rows.Add(asiento.returnFilaAsientos(Asiento.rondaActual,Int32.Parse(Session["id_compra"].ToString())));
            Asiento.rondaActual = Asiento.rondaActual + 5;
        }
        
        

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
        try
        {
            compra.actualizarProcesado();
            HttpContext.Current.Response.Redirect("Login.aspx");
        }
        catch (Exception h)
        {

        }


    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        try
        {
            asiento.setAsientosNull();
            compra.deleteCompraActual();
            HttpContext.Current.Response.Redirect("Login.aspx");
        }
        catch (Exception h)
        {

        }

    }
}