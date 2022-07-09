using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalApp
{
    public partial class Medical : System.Web.UI.Page
    {
        private SqlDataReader reader;
        private int pass, hospitalId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Glob.authMed == 1)
            {
                PageLoad();
            }
            else
                Response.Write("<script>alert('Please log in')</script>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Glob.authMed == 1)
            {
                CheckUser();
                isPassed();
            }
            else
                Response.Write("<script>alert('Please log in')</script>");
        }
        private void PageLoad()
        {
            Glob.AddPatientData(ListBox1, "patient");
            Glob.GetId("SELECT * FROM bills", Label1);
        }
        
        private void CheckUser()
        {
            //when user clicks the button, program is going to check if login and password are matching with these from database
            DBcon.con.Open();
            reader = DBcon.cmd("SELECT * FROM medicalLogin").ExecuteReader();
            pass = 0;
            hospitalId = 0;
            while (reader.Read())
            {
                if (TextBox4.Text == reader.GetString(1))
                    if (TextBox5.Text == reader.GetString(2))
                    {
                        pass = 1; //if it is correct, it is going to add bill into database
                        hospitalId = reader.GetInt32(3);
                    }
            }
            DBcon.con.Close();
        }
        private void isPassed() //checking if user that want to give bill for patient is not anyone from outside
        {
            if (pass == 1)
                AddBill();
            else
                Response.Write("<script>alert('Login error')</script>");
        }
        private void AddBill()
        {
            if (TextBox1.Value.Length > 0 && TextBox3.Text.Length > 0)
                try
                {
                    DBcon.con.Open();
                    DBcon.TryCatchSql(DBcon.cmd("INSERT INTO bills VALUES (" + Label1.Text + ", '" + TextBox3.Text + "', " + TextBox1.Value + ", 0, " + hospitalId + ")"));
                    DBcon.con.Close();
                    Response.Redirect("Medical.aspx");
                }
                catch (NoRecordsInDatabaseEx ex)
                {
                    Console.WriteLine(ex.Message);
                    Response.Write("<script>alert('Please be sure that you filled every textbox correctly!')</script>");
                }
            else
                Response.Write("<script>alert('Please fill textboxes')</script>");
        }
    }
}