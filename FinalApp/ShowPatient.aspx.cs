using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalApp
{
    public partial class ShowPatient : System.Web.UI.Page
    {
        private SqlDataReader reader;
        private string patient;
        private int counter, paid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Glob.authHos == 1)
            {
                HideLabels(); //hiding labels to make site looks better when they are not assigned

                if (!IsPostBack)
                    AddToDropDownList(DropDownList1); //adding strings to the list, user is choosing patient to show information about him
            }
            else
                Response.Write("<script>alert('Please log in')</script>");
        }
        protected void Button1_Click(object sender, EventArgs e) //changing status from not paid to paid and from paid to not paid
        {
            if (Glob.authHos == 1)
            {
                DBcon.con.Open();

                reader = DBcon.cmd("SELECT * FROM patient INNER JOIN bills ON patient.id=bills.patientId WHERE isAv = 1 AND patient.name = '" + DropDownList1.SelectedItem.Text + "' AND bills.id = " + TextBox1.Value).ExecuteReader();
                while (reader.Read())
                {
                    paid = reader.GetInt32(9); //checking if it is paid (1) or not paid (0)
                }
                if (paid == 0)
                {
                    DBcon.TryCatchSql(DBcon.cmd("UPDATE bills SET paid = 1 WHERE id = " + TextBox1.Value)); //if there will be any sql exception by not entering id etc, we will get an info in output console but app will be still working
                }
                else if (paid == 1)
                {
                    DBcon.TryCatchSql(DBcon.cmd("UPDATE bills SET paid = 0 WHERE id = " + TextBox1.Value));
                }
                DBcon.con.Close();
                System.Diagnostics.Debug.WriteLine(paid + " " + DropDownList1.SelectedItem.Text + " " + TextBox1.Value);
                DropDownList1.SelectedIndex = 0;
                TextBox1.Value = "";
                ListBox1.Items.Clear();
            }
            else
                Response.Write("<script>alert('Please log in')</script>");
            
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e) //showing details of selected patient
        {
            patient = "";
            DBcon.con.Open();
            reader = DBcon.cmd("SELECT * FROM patient LEFT JOIN bills ON patient.id=bills.patientId WHERE patient.isAv = 1").ExecuteReader();
            while (reader.Read())
            {
                if (DropDownList1.SelectedValue == reader.GetString(1))
                {
                    Label1.Text = reader.GetString(1);
                    Label3.Text = reader.GetInt32(2).ToString();
                    Label4.Text = reader.GetInt32(3).ToString();
                    Label5.Text = reader.GetString(4);
                    patient = reader.GetString(1);
                }
            }
            ShowLabels();
            DBcon.con.Close();
            AddToList(ListBox1);
        }




        private void AddToList(ListBox listBox) //adding bills to the list if patient have any of them
        {
            counter = 0;
            DBcon.con.Open();
            reader = DBcon.cmd("SELECT * FROM patient INNER JOIN bills ON patient.id=bills.patientId WHERE patient.isAv = 1 AND patient.name = '" + patient + "'").ExecuteReader();
            while (reader.Read())
            {
                counter++;
                if (reader.GetInt32(9) == 0)
                {
                    listBox.Items.Add("ID " + reader.GetInt32(6) + " " + reader.GetString(7) + ",");
                    listBox.Items.Add("not paid");
                    listBox.Items.Add("--------------");
                }
                else
                {
                    listBox.Items.Add("ID " + reader.GetInt32(6) + " " + reader.GetString(7) + ",");
                    listBox.Items.Add("paid");
                    listBox.Items.Add("--------------");
                }
            }
            if (counter == 0)
            {
                listBox.Items.Clear();
                listBox.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Button1.Visible = false;
                TextBox1.Visible = false;
            }
            else
            {
                listBox.Visible = true;
                Label12.Visible = true;
                Label13.Visible = true;
                Button1.Visible = true;
                TextBox1.Visible = true;
            }
            DBcon.con.Close();
        }
        private void AddToDropDownList(DropDownList dropDownList)// adding patients to dropdownlist
        {
            dropDownList.AutoPostBack = true;
            dropDownList.Items.Clear();
            dropDownList.Items.Add("");
            DBcon.con.Open();
            reader = DBcon.cmd("SELECT * FROM patient WHERE isAv = 1").ExecuteReader();
            while (reader.Read())
            {
                dropDownList.Items.Add(reader.GetString(1));
            }
            DBcon.con.Close();
            dropDownList.SelectedItem.Value = "";
            dropDownList.DataBind();
        }
        private void HideLabels()
        {
            Label1.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            Label7.Visible = false;
            Label9.Visible = false;
            Label10.Visible = false;
            Label11.Visible = false;
            Label12.Visible = false;
            Label13.Visible = false;
            Button1.Visible = false;
            TextBox1.Visible = false;
            ListBox1.Visible = false;
        }
        private void ShowLabels()
        {
            Label1.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;
            Label7.Visible = true;
            Label9.Visible = true;
            Label10.Visible = true;
            Label11.Visible = true;
        }
    }
}