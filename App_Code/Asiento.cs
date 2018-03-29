using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for Asiento
/// </summary>
public class Asiento
{
    SqlConnection conexion = new SqlConnection("data source = DESKTOP-AU2VG13; initial catalog = db_demo;" +
    "user id=valeriaba;password=ValeriaB.25");

    //Josue: "data source = DESKTOP-V6P625O\\MSSQLSERVER01; initial catalog = db_demo;" + "user id=josuemartinez;password=josue-18"
    //Vale: "data source = DESKTOP-AU2VG13; initial catalog = db_demo;" + "user id=valeriaba;password=ValeriaB.25"

    String sql;
    SqlCommand com;
    SqlDataReader rs;

    public static int cantAsientos;
    public static int rondaActual;

    public Asiento()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static int A1;
    public static int A2;
    public static int B1;
    public static int B2;
    public static int C1;
    public static int C2;
    public static int D1;
    public static int D2;
    public static int E1;
    public static int E2;

    

    public void setAsientos()
    {
        int graderia = Int32.Parse(HttpContext.Current.Session["id_graderia"].ToString());

        switch(graderia){
            case 1:
                A1 = 1;
                A2 = 2;
                B1 = 3;
                B2 = 4;
                C1 = 5;
                C2 = 6;
                D1 = 7;
                D2 = 8;
                E1 = 9;
                E2 = 10;
                break;
            case 2:
                A1 = 11;
                A2 = 12;
                B1 = 13;
                B2 = 14;
                C1 = 15;
                C2 = 16;
                D1 = 17;
                D2 = 18;
                E1 = 19;
                E2 = 20;
                break;
            case 3:
                A1 = 21;
                A2 = 22;
                B1 = 23;
                B2 = 24;
                C1 = 25;
                C2 = 26;
                D1 = 27;
                D2 = 28;
                E1 = 29;
                E2 = 30;
                break;
            case 4:
                A1 = 31;
                A2 = 32;
                B1 = 33;
                B2 = 34;
                C1 = 35;
                C2 = 36;
                D1 = 37;
                D2 = 38;
                E1 = 39;
                E2 = 40;
                break;
            default:
                break;
        }

    }

    public void updateToEstadoBusy(int id_asiento)
    {
        conexion.Open(); //Iniciar conexion

        sql = "UPDATE t_asiento SET estado = 1"
            + " WHERE id_asiento = " + id_asiento + "";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();
        conexion.Close(); //terminar conexion
    }

    public void updateToFreeAsiento(int id_asiento)
    {
        conexion.Open(); //Iniciar conexion

        sql = "UPDATE t_asiento set id_cobro = null WHERE " + id_asiento + " = 1 and estado = 0";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();
        conexion.Close(); //terminar conexion
    }


    public int returnEstadoAsiento(int id_asiento)
    {
        int estado = 0;
        conexion.Open(); //Iniciar conexion

        sql = "select estado from t_asiento where id_asiento=" + id_asiento + "";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        rs = com.ExecuteReader(); //solamente para SELECT

        if (rs.Read())
        {
            estado = Int32.Parse(rs[0].ToString());
        }
        conexion.Close(); //terminar conexion

        return estado;

    }

    public void updateToBusyAsiento(int id_asiento)
    {
        conexion.Open(); //Iniciar conexion

        sql = "UPDATE t_asiento SET id_cobro =" + HttpContext.Current.Session["id_compra"]
            + " WHERE id_asiento = " + id_asiento + "";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();
        conexion.Close(); //terminar conexion
    }

    public void setAsientosNull()
    {
        conexion.Open(); //Iniciar conexion

        sql = "Update t_asiento set id_cobro = null where id_cobro = " + Int32.Parse(HttpContext.Current.Session["id_compra"].ToString()) + "";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();
        conexion.Close(); //terminar conexion
    }

    public TableRow returnFilaAsientos(int ronda, int id_compra)
    {
        conexion.Open(); //Iniciar conexion
        TableRow row = new TableRow();

        TableCell cellAsiento = new TableCell();
        TableCell cellDescripcion = new TableCell();
        TableCell cellHorario = new TableCell();
        TableCell cellGraderia = new TableCell();
        TableCell cellPrecioU = new TableCell();

        sql = "select a.id_asiento as asiento,e.descripcion, e.horario, g.nombre as graderia,'₡' + CONVERT(varchar, CAST(g.precio AS money), 1) as precioUnidad"
        +" from t_cobro c"
        +" JOIN t_asiento a"
        +" ON(a.id_cobro = c.id_cobro)"
        +" JOIN t_evento e"
        +" ON(c.id_evento = e.id_evento)"
        +" JOIN t_graderia g"
        +" ON(c.id_graderia = g.id_graderia)"
        +" where a.id_cobro= " + id_compra + "";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        rs = com.ExecuteReader(); //solamente para SELECT

        if (rs.Read()) {
            cellAsiento.Text = rs[0].ToString();
            cellDescripcion.Text = rs[1].ToString();
            cellHorario.Text = rs[2].ToString();
            cellGraderia.Text = rs[3].ToString();
            cellPrecioU.Text = rs[4].ToString();
        }

        row.Cells.Add(cellAsiento);
        row.Cells.Add(cellDescripcion);
        row.Cells.Add(cellHorario);
        row.Cells.Add(cellGraderia);
        row.Cells.Add(cellPrecioU);

        conexion.Close(); //terminar conexion

        return row;
        
    }
}