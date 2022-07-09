using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalApp
{
    public partial class DeletePatient : System.Web.UI.Page
    {
        private SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Glob.authHos == 1)
                AddDataGrid(GridView1);
            else
                Response.Write("<script>alert('Please log in')</script>");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Glob.authHos == 1)
                if (TextBox1.Value.Length > 0 && TextBox2.Text.Length > 0)
                {
                    try
                    {
                        DBcon.con.Open();
                        DBcon.TryCatchSql(DBcon.cmd("UPDATE patient SET isAv = 0 WHERE id = " + TextBox1.Value + " AND name = '" + TextBox2.Text + "'"));
                        DBcon.con.Close();
                        Response.Redirect("DeletePatient.aspx");
                    }
                    catch (NoRecordsInDatabaseEx ex) //if user will type any other numer than ID and other string than surname of this ID, exception will show up
                    {
                        Console.WriteLine(ex.Message);
                        Response.Write("<script LANGUAGE='JavaScript' >alert('We don't have that patient in our database')</script>");
                    }
                }
                else
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Please fill empty textboxes!')</script>");
                }
            else
                Response.Write("<script>alert('Please log in')</script>");
        }


        private void AddDataGrid(GridView grid) //method to add patients data from database to grid view
        {
            DBcon.con.Open();
            reader = DBcon.cmd("SELECT * FROM patient WHERE isAv = 1").ExecuteReader(); //isAv returns 0 or 1, if 1, he is our patient, if 0, he is in database but he is no more our patient, it is just to be able to recover his bills
            var list = new List<Patient>();
            while (reader.Read())
            {
                list.Add(new Patient()
                {
                    id = reader.GetInt32(0),
                    name = reader.GetString(1),
                    age = reader.GetInt32(2),
                    telNo = reader.GetInt32(3),
                    email = reader.GetString(4)
                });
            }
            DBcon.con.Close();
            grid.DataSource = list;
            grid.DataBind();
        }
    }
}