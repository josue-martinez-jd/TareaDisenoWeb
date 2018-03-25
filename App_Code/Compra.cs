using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Cobro
/// </summary>
public class Compra
{
    SqlConnection conexion = new SqlConnection("data source = DESKTOP-AU2VG13; initial catalog = db_demo;" +
    "user id=valeriaba;password=ValeriaB.25");

    //Josue: "data source = DESKTOP-V6P625O\\MSSQLSERVER01; initial catalog = db_demo;" + "user id=josuemartinez;password=josue-18"
    //Vale: "data source = DESKTOP-AU2VG13; initial catalog = db_demo;" + "user id=valeriaba;password=ValeriaB.25"

    String sql;
    SqlCommand com;
    SqlDataReader rs;

    public Compra()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void CrearCompra(int id_evento, int id_translado, string cedula)
    {
        conexion.Open(); //Iniciar conexion

        sql = "insert into t_cobro values('" + id_evento + "','" + id_translado + "',null,null,0,'" + cedula + "')";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();
        conexion.Close(); //terminar conexion
    }

    public void setCompraActual()
    {
        conexion.Open(); //Iniciar conexion

        sql = "select max(id_cobro) from t_cobro";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        rs = com.ExecuteReader(); //solamente para SELECT

        if (rs.Read())
        {
            HttpContext.Current.Session["id_compra"] = rs[0];
        }
            
        conexion.Close(); //terminar conexion
    }

    public void actualizarGraderia(int id_graderia, int id_cobro)
    {
        conexion.Open(); //Iniciar conexion

        sql = "UPDATE t_cobro SET id_graderia="+id_graderia+" WHERE id_cobro="+id_cobro+"";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();
        conexion.Close(); //terminar conexion
    }


    public void actualizarCantAsientos(int cantidad, int id_cobro)
    {
        conexion.Open(); //Iniciar conexion

        sql = "UPDATE t_cobro SET cantidadAsientos = " + cantidad + " WHERE id_cobro = " + id_cobro + "";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();
        conexion.Close(); //terminar conexion
    }

    
}