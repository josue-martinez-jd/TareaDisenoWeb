using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Evento
/// </summary>
public class Evento
{
    SqlConnection conexion = new SqlConnection("data source = DESKTOP-AU2VG13; initial catalog = db_demo;" +
   "user id=valeriaba;password=ValeriaB.25");

    //Josue: "data source = DESKTOP-V6P625O\\MSSQLSERVER01; initial catalog = db_demo;" + "user id=josuemartinez;password=josue-18"
    //Vale: "data source = DESKTOP-AU2VG13; initial catalog = db_demo;" + "user id=valeriaba;password=ValeriaB.25"

    public Evento()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void CrearEvento(string cedula, string nombre, string primerAp, string SegundoAp, string direccion, string email, string telefono, string username, string password)
    {

        String sql;
        SqlCommand com;

        conexion.Open(); //Iniciar conexion

        sql = "INSERT INTO t_usuario VALUES('" + cedula + "','" + nombre + "','" + primerAp + "','" + SegundoAp + "','"
            + direccion + "','" + email + "','" + telefono + "', PWDENCRYPT('" + password + "')" + "')";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();
        conexion.Close(); //terminar conexion
    }
}