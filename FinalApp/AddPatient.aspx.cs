using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalApp
{
    public partial class AddPatient : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Glob.authHos == 1)
                Glob.GetId("SELECT * FROM patient", Label1); //assigning unique ID to patient that we want to add
            else
                Response.Write("<script>alert('Please log in')</script>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Glob.authHos == 1)
                Inserting(); //inserting patient into database
            else
                Response.Write("<script>alert('Please log in')</script>");
        }
        private void Inserting()
        {
            try
            {
                if (TextBox1.Text.Length > 0)
                {
                    DBcon.con.Open();
                    DBcon.TryCatchSql(DBcon.cmd("INSERT INTO patient VALUES (" + Label1.Text + ", '" + TextBox1.Text + " " + TextBox2.Text + "', " + TextBox3.Value + ", " + TextBox4.Value + ", '" + TextBox5.Text + "', 1)"));
                    DBcon.con.Close();
                    Response.Redirect("AddPatient.aspx");
                } else if (TextBox1.Text.Length == 0)
                {
                    DBcon.con.Open();
                    DBcon.TryCatchSql(DBcon.cmd("INSERT INTO patient VALUES (" + Label1.Text + ", '" + TextBox2.Text + "', " + TextBox3.Value + ", " + TextBox4.Value + ", '" + TextBox5.Text + "', 1)"));
                    DBcon.con.Close();
                    Response.Redirect("AddPatient.aspx");
                }
            } catch (FillTextboxEx ex)
            {
                Console.WriteLine(ex.Message); //if something will go wrong, we are going to get a message about it
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
    }
}