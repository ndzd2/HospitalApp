using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalApp
{
    public partial class MedDep : System.Web.UI.Page
    {
        private SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            Glob.AddData(ListBox1, "hospital");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            CheckLogIn("Medical.aspx");
        }

        private void CheckLogIn(string siteName)
        {
            //when user clicks the button, program is going to check if he checked hospital,
            //if login and password are matching with these from database, he is going to be taken to hospital site
            DBcon.con.Open();
            reader = DBcon.cmd("SELECT * FROM medicalLogin INNER JOIN hospital ON medicalLogin.hospitalId = hospital.id").ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    try
                    {
                        if (TextBox1.Text == reader.GetString(1) && Convert.ToInt32(TextBox3.Value) == reader.GetInt32(4))
                        {
                            if (TextBox2.Text == reader.GetString(2))
                            {
                                DBcon.con.Close();
                                Glob.authMed = 1;
                                Response.Redirect(siteName);
                            }
                            else
                                DBcon.con.Close();
                        }
                        else
                            DBcon.con.Close();
                    }
                    catch (FormatException ex)
                    {
                        return;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                return;
            }
        }
    }
}