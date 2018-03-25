using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EscogerAsiento : System.Web.UI.Page
{
    Asiento asiento = new Asiento();
    Compra compra = new Compra();
    public static int cantAsientos ;

    protected void Page_Load(object sender, EventArgs e)
    {
        asiento.setAsientos();
        updateColorAsiento(btnA1, Asiento.A1);
        updateColorAsiento(btnA2, Asiento.A2);
        updateColorAsiento(btnA3, Asiento.B1);
        updateColorAsiento(btnA4, Asiento.B2);
        updateColorAsiento(btnA5, Asiento.C1);
        updateColorAsiento(btnB1, Asiento.C2);
        updateColorAsiento(btnB2, Asiento.D1);
        updateColorAsiento(btnB3, Asiento.D2);
        updateColorAsiento(btnB4, Asiento.E1);
        updateColorAsiento(btnB5, Asiento.E2);
        if (!Page.IsPostBack)
        {
            cantAsientos = 0;
        }
        lblCantidadAsientos.Text = cantAsientos.ToString();
    }

    private void onclickColor (Button btn, int id_asiento)
    {
        if (asiento.returnEstadoAsiento(id_asiento) == 0) { 
        if (btn.CssClass != "btn btn-danger")
        {
                cantAsientos = cantAsientos + 1;
                asiento.updateToBusyAsiento(id_asiento);
            btn.CssClass = "btn btn-danger";
                lblCantidadAsientos.Text = cantAsientos.ToString();
        }
        else
        {
                cantAsientos = cantAsientos - 1;
                asiento.updateToFreeAsiento(id_asiento);
            btn.CssClass = "btn btn-success";
                lblCantidadAsientos.Text = cantAsientos.ToString();
            }
        }
    }

    protected void btnA1_Click(object sender, EventArgs e)
    {
        onclickColor(btnA1,Asiento.A1);
    }

    protected void btnA2_Click(object sender, EventArgs e)
    {
        onclickColor(btnA2, Asiento.A2);
    }

    protected void btnA3_Click(object sender, EventArgs e)
    {
        onclickColor(btnA3, Asiento.B1);
    }

    protected void btnA4_Click(object sender, EventArgs e)
    {
        onclickColor(btnA4, Asiento.B2);
    }

    protected void btnA5_Click(object sender, EventArgs e)
    {
        onclickColor(btnA5, Asiento.C1);
    }

    protected void btnB1_Click(object sender, EventArgs e)
    {
        onclickColor(btnB1, Asiento.C2);
    }

    protected void btnB2_Click(object sender, EventArgs e)
    {
        onclickColor(btnB2, Asiento.D1);
    }

    protected void btnB3_Click(object sender, EventArgs e)
    {
        onclickColor(btnB3, Asiento.D2);
    }

    protected void btnB4_Click(object sender, EventArgs e)
    {
        onclickColor(btnB4, Asiento.E1);
    }

    protected void btnB5_Click(object sender, EventArgs e)
    {
        onclickColor(btnB5, Asiento.E2);
    }


    protected void btnSiguiente_Click(object sender, EventArgs e)
    {
        setToBusy(btnA1, Asiento.A1);
        setToBusy(btnA2, Asiento.A2);
        setToBusy(btnA3, Asiento.B1);
        setToBusy(btnA4, Asiento.B2);
        setToBusy(btnA5, Asiento.C1);
        setToBusy(btnB1, Asiento.C2);
        setToBusy(btnB2, Asiento.D1);
        setToBusy(btnB3, Asiento.D2);
        setToBusy(btnB4, Asiento.E1);
        setToBusy(btnB5, Asiento.E2);

        compra.actualizarCantAsientos(cantAsientos, Int32.Parse(Session["id_compra"].ToString()));
        HttpContext.Current.Response.Redirect("Cobro.aspx");
    }


    public void updateColorAsiento(Button btn, int id_asiento)
    {
        if (asiento.returnEstadoAsiento(id_asiento) == 1)
        {
            if (btn.CssClass != "btn btn-danger")
            {
                asiento.updateToBusyAsiento(id_asiento);

                btn.CssClass = "btn btn-danger";
            }
        }
        
    }

    public void setToBusy(Button btn, int id_asiento)
    {
        if (btn.CssClass == "btn btn-danger" && asiento.returnEstadoAsiento(id_asiento) == 0)
        {
            asiento.updateToEstadoBusy(id_asiento);
        }
    }

}