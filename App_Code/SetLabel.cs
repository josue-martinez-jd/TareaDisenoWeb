using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SetLabel
/// </summary>
public class SetLabel
{
    SqlConnection conexion = new SqlConnection("data source = DESKTOP-AU2VG13; initial catalog = db_demo;" +
    "user id=valeriaba;password=ValeriaB.25");

    //Josue: "data source = DESKTOP-V6P625O\\MSSQLSERVER01; initial catalog = db_demo;" + "user id=josuemartinez;password=josue-18"
    //Vale: "data source = DESKTOP-AU2VG13; initial catalog = db_demo;" + "user id=valeriaba;password=ValeriaB.25"

    String sql;
    SqlCommand com;
    SqlDataReader rs;

    public SetLabel() { }

    // EscogerEvento
    public static string Descripcion1;
    public static string Artista1;
    public static string CostoEste1;
    public static string CostoOeste1;
    public static string CostoNorte1;
    public static string CostoSur1;

    public static string Descripcion2;
    public static string Artista2;
    public static string CostoEste2;
    public static string CostoOeste2;
    public static string CostoNorte2;
    public static string CostoSur2;

    public static string Descripcion3;
    public static string Artista3;
    public static string CostoEste3;
    public static string CostoOeste3;
    public static string CostoNorte3;
    public static string CostoSur3;

    //index
    public static string PrecioEste;
    public static string PrecioOeste;
    public static string PrecioNorte;
    public static string PrecioSur;

    //Cobro
    public static string DescripcionCobro;
    public static string HorarioCobro;
    public static string TransladoCobro;
    public static string PrecioTransladoCobro;
    public static string GraderiaCobro;
    public static string PrecioUnidadCobro;
    public static string CantAsientosCobro;
    public static string TotalCobro;

    public void setLabelsEvento()
    {
        conexion.Open(); //Iniciar conexion

        sql = "select * from t_evento where id_evento=1";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        rs = com.ExecuteReader(); //solamente para SELECT

        if (rs.Read())
        {
            Descripcion1 = rs[1].ToString();
            Artista1 = rs[2].ToString();
            CostoEste1 = "₡" + rs[3].ToString();
            CostoOeste1 = "₡" + rs[4].ToString();
            CostoNorte1 = "₡" + rs[5].ToString();
            CostoSur1 = "₡" + rs[6].ToString();
          }
        conexion.Close(); //terminar conexion
        conexion.Open(); //Iniciar conexion
        sql = "select * from t_evento where id_evento=2";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        rs = com.ExecuteReader(); //solamente para SELECT

        if (rs.Read())
        {
            Descripcion2 = rs[1].ToString();
            Artista2 = rs[2].ToString();
            CostoEste2 = "₡" + rs[3].ToString();
            CostoOeste2 = "₡" + rs[4].ToString();
            CostoNorte2 = "₡" + rs[5].ToString();
            CostoSur2 = "₡" + rs[6].ToString();
        }
        conexion.Close(); //terminar conexion
        conexion.Open(); //Iniciar conexion
        sql = "select * from t_evento where id_evento=3";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        rs = com.ExecuteReader(); //solamente para SELECT

        if (rs.Read())
        {
            Descripcion3 = rs[1].ToString();
            Artista3 = rs[2].ToString();
            CostoEste3 = "₡" + rs[3].ToString();
            CostoOeste3 = "₡" + rs[4].ToString();
            CostoNorte3 = "₡" + rs[5].ToString();
            CostoSur3 = "₡" + rs[6].ToString();
        }

        conexion.Close(); //terminar conexion
    }

    public void setLabelsGraderia(int id_graderia)
    {
        conexion.Open(); //Iniciar conexion

        sql = "select * from t_graderia where id_graderia=" + id_graderia + "";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        rs = com.ExecuteReader(); //solamente para SELECT

        if (rs.Read())
        {
            if (id_graderia == 1)
            {
                PrecioNorte = "₡" + rs[2].ToString();
            }
            else if (id_graderia == 2)
            {
                PrecioSur = "₡" + rs[2].ToString();
            }
            else if (id_graderia == 3)
            {
                PrecioEste = "₡" + rs[2].ToString();
            }
            else if (id_graderia == 4)
            {
                PrecioOeste = "₡" + rs[2].ToString();
            }
        }
        conexion.Close(); //terminar conexion
    }

    public void setlabelsCobro()
    {
        conexion.Open(); //Iniciar conexion

        sql = "select e.descripcion, e.horario, t.nombre as Translado, '₡' + CONVERT(varchar, CAST(t.precio AS money), 1) as PrecioTranslado, g.nombre as Graderia,'₡' + CONVERT(varchar, CAST(g.precio AS money), 1) as PrecioUnidad ,c.cantidadAsientos , '₡' + CONVERT(varchar, CAST(t.precio + (c.cantidadAsientos * g.precio) AS money), 1) as Total"
            + " from t_cobro c"
            + " JOIN t_evento e"
            + " ON(c.id_evento = e.id_evento)"
            + " JOIN t_translado t"
            + " ON(c.id_translado = t.id_translado)"
            + " JOIN t_graderia g"
            + " ON(c.id_graderia = g.id_graderia)"
            + " where c.id_cobro="+ Int32.Parse(HttpContext.Current.Session["id_compra"].ToString());


        com = conexion.CreateCommand();
        com.CommandText = sql;
        rs = com.ExecuteReader(); //solamente para SELECT

        if (rs.Read())
        {
            DescripcionCobro = rs[0].ToString();
            HorarioCobro = rs[1].ToString();
            TransladoCobro = rs[2].ToString();
            PrecioTransladoCobro = rs[3].ToString();
            GraderiaCobro = rs[4].ToString();
            PrecioUnidadCobro = rs[5].ToString();
            CantAsientosCobro = rs[6].ToString();
            TotalCobro = rs[7].ToString();
        }
        conexion.Close(); //terminar conexion

    }
}