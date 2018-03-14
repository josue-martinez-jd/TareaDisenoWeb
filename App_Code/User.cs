using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

public class User
{

    SqlConnection conexion = new SqlConnection("data source = DESKTOP-AU2VG13; initial catalog = databaseTarea1;" +
       "user id=valeriaba;password=ValeriaB.25");

    public User()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    public void Register(string cedula, string nombre, string primerAp, string SegundoAp, string direccion, string email, string telefono, string username, string password)
    {

        String sql;
        SqlCommand com;

        conexion.Open(); //Iniciar conexion

        sql = "INSERT INTO t_usuario VALUES('" + cedula + "','"+ nombre + "','" + primerAp + "','" + SegundoAp + "','" 
            + direccion + "','" + email + "','" + telefono + "', PWDENCRYPT('" + password + "')" + "')";

        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.ExecuteNonQuery();
        conexion.Close(); //terminar conexion
    }

    public void Login(string usuario, string password)
    {
        String sql;
        SqlCommand com;
        SqlDataReader rs;

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
            HttpContext.Current.Session["tipo"] = rs[6];

            if (Int32.Parse(HttpContext.Current.Session["tipo"].ToString()) == 0)
            {
                HttpContext.Current.Response.Redirect("https://www.google.com");
            }
            else if (Int32.Parse(HttpContext.Current.Session["tipo"].ToString()) == 1)
            {
                HttpContext.Current.Response.Redirect("http://www.ulacit.ac.cr/");
            }

        }

        conexion.Close(); //terminar conexion
    }

}