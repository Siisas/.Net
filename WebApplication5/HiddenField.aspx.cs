using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class HiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaDatos();

            }
        }        public void CargaDatos()
        {
            string cadena = ConfigurationManager.ConnectionStrings["DBZS"].ConnectionString;
            using (SqlConnection cnx = new SqlConnection(cadena))
            {
                //string SqlQuery = "SELECT ID,NOMBRE,FECHA,ID_GENERO FROM PELICULAS WHERE ID=1040";
                string SqlQuery = "Select * from peliculas";
                SqlCommand cmd = new SqlCommand(SqlQuery,cnx);
                cnx.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                    while (rdr.Read())
                {
                        TextBox1.Text = rdr["nombre"].ToString();
                        TextBox2.Text = rdr["fecha"].ToString();
                        TextBox3.Text = rdr["id_genero"].ToString();
                        HiddenField1.Value = rdr["id"].ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cadena = ConfigurationManager.ConnectionStrings["dbzs"].ConnectionString;
            using (SqlConnection cnx = new SqlConnection(cadena))
            {
                string SQLQUERY = "UPDATE PELICULAS SET NOMBRE=@NOMBRE,FECHA=@FECHA,ID_GENERO=@ID_GENERO WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(SQLQUERY, cnx);
                cmd.Parameters.AddWithValue("@nombre", TextBox1.Text);
                cmd.Parameters.AddWithValue("@fecha",Convert.ToDateTime(TextBox2.Text));
                cmd.Parameters.AddWithValue("@id_genero", TextBox3.Text);
                cmd.Parameters.AddWithValue("@id", HiddenField1.Value);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CargaDatos();
        }
    }
}