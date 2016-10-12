using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                Calendar1.Visible = false;
            }

            //if (!IsPostBack)
            //{
            //    Calendar1.Visible = false;
            //}

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }

            //if (Calendar1.Visible)
            //{
            //    Calendar1.Visible = false;
            //}
            //else
            //{
            //    Calendar1.Visible = true;
            //}

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();

            //TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
            //Calendar1.Visible = false;
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string cadena = ConfigurationManager.ConnectionStrings["DBZ"].ConnectionString;
            using (SqlConnection cnx = new SqlConnection(cadena))
            {
                SqlCommand cmd = new SqlCommand("InsertarF", cnx);
                cnx.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", Convert.ToDateTime(TextBox1.Text));
                cmd.ExecuteNonQuery();
            }
        }

        //Create procedure Sp
        //    @fecha date,
        //    @nombre varchar (20)
        //    as
        //insert into laP values 
        //    @fecha,@nombre




















        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    string cadena = ConfigurationManager.ConnectionStrings["DBZ"].ConnectionString;
        //    using (SqlConnection cnx = new SqlConnection(cadena))
        //    {
        //        SqlCommand cmd = new SqlCommand("InsertarF", cnx);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@fecha", Convert.ToDateTime(TextBox1.Text));
        //        cmd.ExecuteNonQuery(); 
        //    }
        //}


        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    string cadena = ConfigurationManager.ConnectionStrings["DBZ"].ConnectionString;
        //    using (SqlConnection cnx = new SqlConnection(cadena))
        //    {
        //        cnx.Open();
        //        SqlCommand cmd = new SqlCommand("InsertarF ", cnx);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@fecha", Convert.ToDateTime(TextBox1.Text));
        //        cmd.ExecuteNonQuery();
        //    }             
        //}


        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    string cadena = ConfigurationManager.ConnectionStrings["DBZ"].ConnectionString;
        //    using (SqlConnection cnx = new SqlConnection(cadena))
        //    {                
        //        cnx.Open();
        //        SqlCommand cmd = new SqlCommand("InsertarF", cnx);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@fecha",Convert.ToDateTime( TextBox1.Text));
        //        cmd.ExecuteNonQuery();             
        //    }
        //}
    }
}