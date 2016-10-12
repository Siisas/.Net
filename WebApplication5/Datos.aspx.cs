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
    public partial class Datos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cadena = ConfigurationManager.ConnectionStrings["DBZ"].ConnectionString;
            using (SqlConnection cnx = new SqlConnection(cadena))
            {
                SqlCommand cn = new SqlCommand("Select * from laP", cnx);
                cnx.Open();
                DropDownList1.DataSource = cn.ExecuteReader();
                DropDownList1.DataTextField = "fecha";
                DropDownList1.DataValueField = "fecha";
                DropDownList1.DataBind();
                cnx.Close();
            }    

        }
    }
}