using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalApp
{
    public partial class UpdatePatient : System.Web.UI.Page
    {
        private int outputValue;
        private bool isNumber, isNumber2;
        protected void Page_Load(object sender, EventArgs e)
        {
            HideText();
            Glob.AddPatientData(ListBox1, "patient");
        }
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e) //method to show or hide textboxes based on change that you want to make
        {
            TextBoxChecked(CheckBox1, TextBox1, TextBox2, Button1);
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
        }
        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxChecked(CheckBox2, TextBox3, TextBox4, Button2);
            CheckBox1.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxChecked(CheckBox3, TextBox5, TextBox6, Button3);
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox4.Checked = false;
        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxChecked(CheckBox4, TextBox7, TextBox8, Button4);
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ButtonClickedString(TextBox1, TextBox2, "name");
            CheckBox1.Checked = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ButtonClickedInt(TextBox3, TextBox4, "age");
            CheckBox2.Checked = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ButtonClickedInt(TextBox5, TextBox6, "telNo");
            CheckBox3.Checked = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ButtonClickedString(TextBox7, TextBox8, "email");
            CheckBox4.Checked = false;
        }
        private void HideText()
        {
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            TextBox4.Visible = false;
            TextBox5.Visible = false;
            TextBox6.Visible = false;
            TextBox7.Visible = false;
            TextBox8.Visible = false;
            Button1.Visible = false;
            Button2.Visible = false;
            Button3.Visible = false;
            Button4.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
        }
        private void ShowText(TextBox textBox1, TextBox textBox2)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
        }
        private void HideTwoTextes(TextBox textBox1, TextBox textBox2)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
        }
        private void TextBoxChecked(CheckBox checkBox, TextBox textBox1, TextBox textBox2, Button button)
        {
            if (checkBox.Checked)
            {
                ShowText(textBox1, textBox2);
                button.Visible = true;
            }
            else if (!checkBox.Checked)
            {
                HideTwoTextes(textBox1, textBox2);
                button.Visible = false;
            }
        }
        private void ButtonClickedString(TextBox textBox1, TextBox textBox2, string column) //we are checking if id textbox is number and updating values in database
        {
            outputValue = 0;
            isNumber = false;
            DBcon.con.Open();
            isNumber = int.TryParse(textBox1.Text, out outputValue);
            if (isNumber && textBox2.Text.Length > 0)
            {
                var cmd = DBcon.cmd("UPDATE patient SET " + column + " = '" + textBox2.Text + "' WHERE id = " + textBox1.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                } catch(NoRecordsInDatabaseEx ex)
                {
                    Console.WriteLine(ex.Message);
                    Response.Write("<script>alert('" + ex.Message + "')</script>");
                }
            } else
                Response.Write("<script>alert('Please insert correct data in every textbox')</script>");
            DBcon.con.Close();
        }
        private void ButtonClickedInt(TextBox textBox1, TextBox textBox2, string column) //we are checking if id textbox and the second textbox is number and updating values in database
        {
            outputValue = 0;
            isNumber = false;
            isNumber2 = false;
            DBcon.con.Open();

            isNumber = int.TryParse(textBox1.Text, out outputValue);
            isNumber2 = int.TryParse(textBox2.Text, out outputValue);
            if (isNumber && isNumber2)
            {
                var cmd = DBcon.cmd("UPDATE patient SET " + column + " = " + textBox2.Text + " WHERE id = " + textBox1.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (NoRecordsInDatabaseEx ex)
                {
                    Console.WriteLine(ex.Message);
                    Response.Write("<script>alert('" + ex.Message + "')</script>");
                }
            }
            else
                Response.Write("<script>alert('Please insert correct data in every textbox')</script>");
            DBcon.con.Close();
        }
    }
}