using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalApp
{
    public partial class Insurance : System.Web.UI.Page
    {
        private SqlDataReader reader;
        private string paid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Glob.authIns == 1)
            {
                Glob.AddData(ListBox1, "hospital"); //adding data to the list
                Glob.AddPatientData(ListBox2, "patient");
                ListBox3.Visible = false;
            }
            else
                Response.Write("<script>alert('Please log in')</script>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Glob.authIns == 1)
            {
                ListBox3.Items.Clear();
                if (TextBox1.Value.Length > 0 && TextBox2.Value.Length == 0) //if user typed value only in the first textbox, display all bills from this hospital
                {
                    info("SELECT * FROM bills WHERE hospitalId = " + TextBox1.Value);
                }
                else if (TextBox1.Value.Length == 0 && TextBox2.Value.Length > 0)//if user typed value only in the second textbox, display all bills of patient
                {
                    info("SELECT * FROM bills WHERE patientId = " + TextBox2.Value);
                }
                else if (TextBox1.Value.Length > 0 && TextBox2.Value.Length > 0)//if user typed value in all textboxes, display all bills of patient from this hospital
                {
                    info("SELECT * FROM bills WHERE hospitalId = " + TextBox1.Value + " AND patientId = " + TextBox2.Value);
                }
                else //if user didn't type value in textboxes, display all bills
                {
                    info("SELECT * FROM bills");
                }
            }
            else
                Response.Write("<script>alert('Please log in')</script>");
        }
        private void info(string command) //method to make code shorter, because we are using pretty much same code for every if statement
        {
            DBcon.con.Open();
            reader = DBcon.cmd(command).ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetInt32(3) == 0)
                    paid = "not paid";
                else if (reader.GetInt32(3) == 1)
                    paid = "paid";
                ListBox3.Items.Add(reader.GetString(1) + ",");
                ListBox3.Items.Add("for patient nr " + reader.GetInt32(2) + ",");
                ListBox3.Items.Add("posted by hospital nr " + reader.GetInt32(4) + ",");
                ListBox3.Items.Add(paid);
                ListBox3.Items.Add("------------");
            }
            DBcon.con.Close();
            ListBox3.Visible = true;
            TextBox1.Value = "";
            TextBox2.Value = "";
        }
    }
}