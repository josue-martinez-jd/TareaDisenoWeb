using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EscogerEvento : System.Web.UI.Page
{

    Evento evento = new Evento();

    protected void Page_Load(object sender, EventArgs e)
    {
        evento.CrearEvento("Conciert", "Ghost", 40000, 60000, 80000, 100000, "7:00pm", 100, 2000);
    }



}