using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    User user = new User();
    

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Session["tipo"] = null;
            Session["cedula"] = null;
            Session["id_compra"] = null;
            Session["id_graderia"] = null;
            Session["id_translado"] = null;
            Session["id_evento"] = null;

            user.limpiarDatosDB();
        }

    }


    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        user.Login(txtUsernameLogin.Text, txtPasswordLogin.Text);
    }


    protected void btnRegister_Click(object sender, EventArgs e)
    {
        user.Register(txtCedulaRegistro.Text, txtNombreRegistro.Text, txtPrimerApRegistro.Text, txtSegundoApRegistro.Text, txtDireccionRegistro.Text, txtEmailRegistro.Text, txtTelefonoRegistro.Text, txtUsernameRegistro.Text, txtPasswordRegistro.Text);
    }



}