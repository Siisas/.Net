using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class check : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBoxList1.SelectedItem != null)
            {
                Response.Write(CheckBoxList1.SelectedItem.Text);
               
            }
            else
            {
                Response.Write("Selecciona una opcion");

            }

            
        }

        protected void Select_Click(object sender, EventArgs e)
        {
            foreach (ListItem Li in CheckBoxList1.Items)
            {
                Li.Selected = true;
            }
        }

        protected void DesSelect_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in CheckBoxList1.Items)
            {
                li.Selected = false;
            }
        }
    }
}