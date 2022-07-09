using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalApp
{
    public partial class Hospital : System.Web.UI.Page //reakcja na przyciski bedzie nakierowywac na nowe webformy
    {

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Glob.authHos == 1)
                Response.Redirect("AddPatient.aspx");
            else
                Response.Write("<script>alert('Please log in')</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Glob.authHos == 1)
                Response.Redirect("UpdatePatient.aspx");
            else
                Response.Write("<script>alert('Please log in')</script>");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Glob.authHos == 1)
                Response.Redirect("DeletePatient.aspx");
            else
                Response.Write("<script>alert('Please log in')</script>");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Glob.authHos == 1)
                Response.Redirect("ShowPatient.aspx");
            else
                Response.Write("<script>alert('Please log in')</script>");
        }
    }
}