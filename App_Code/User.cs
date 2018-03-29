using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

public class User
{

    SqlConnection conexion = new SqlConnection("data source = DESKTOP-AU2VG13; initial catalog = db_demo;"
        + "user id=valeriaba;password=ValeriaB.25");

    //Josue: "data source = DESKTOP-V6P625O\\MSSQLSERVER01; initial catalog = db_demo;" + "user id=josuemartinez;password=josue-18"
    //Vale: "data source = DESKTOP-AU2VG13; initial catalog = db_demo;" + "user id=valeriaba;password=ValeriaB.25"

    String sql;
    SqlCommand com;
    SqlDataReader rs;

    public User()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    public void Register(string cedula, string nombre, string primerAp, string SegundoAp, string direccion, string email, string telefono, string usuario, string password)
    {

        conexion.Open(); //Iniciar conexion

        sql = "INSERT INTO t_usuario VALUES('" + cedula + "','" + nombre + "','" + primerAp + "','" + SegundoAp + "','" + direccion + "','" + email + "','" + telefono + "','" + usuario + "',PWDENCRYPT('" + password + "')," + 0 + ")";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();

        conexion.Close(); //terminar conexion
    }

    public void Login(string usuario, string password)
    {

        conexion.Open(); //Iniciar conexion

        sql = "select * from t_usuario " +
            "Where  usuario = '" + usuario + "' " +
            "and PWDCOMPARE('" + password + "', password) = 1";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        rs = com.ExecuteReader(); //solamente para SELECT
        //rs = com.ExecuteNonQuery();   PARA INSERT, UPDATE Y DELETE

        if (rs.Read())
        {
            HttpContext.Current.Session["tipo"] = rs[9];
            HttpContext.Current.Session["cedula"] = rs[0];

            if (Int32.Parse(HttpContext.Current.Session["tipo"].ToString()) == 0)
            {
                HttpContext.Current.Response.Redirect("EscogerEvento.aspx");
            }
            else if (Int32.Parse(HttpContext.Current.Session["tipo"].ToString()) == 1)
            {
                HttpContext.Current.Response.Redirect("http://www.ulacit.ac.cr/");
            }

        }

        conexion.Close(); //terminar conexion
    }

    public void limpiarDatosDB()
    {
        conexion.Open(); //Iniciar conexion

        sql = "update a set a.id_cobro = null, a.estado = 0 from t_asiento a JOIN t_cobro c"
        + " ON(a.id_cobro = c.id_cobro) where c.procesado != 1";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();
        conexion.Close(); //terminar conexion

        conexion.Open(); //Iniciar conexion

        sql = "DELETE FROM t_cobro WHERE procesado != 1";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();
        conexion.Close(); //terminar conexion
    }
}