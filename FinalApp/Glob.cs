using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace FinalApp
{
    public class Glob // this class cointains variables used couple times in the code
    {
        private static int counter, lastID;
        private static SqlDataReader reader;
        public static int authHos = 0; //basic variable for authorization, becuase I didn't have much time to implement professional authorization to this project
        public static int authMed = 0;
        public static int authIns = 0;
        public static void GetId(string command, Label label) //method to get unique id
        {
            counter = 0;
            lastID = 92743890;
            label.Text = "Label";
            DBcon.con.Open();
            reader = DBcon.cmd(command).ExecuteReader();
            while (reader.Read())
            {
                counter++;
                try
                {
                    lastID = reader.GetInt32(0);
                } catch (NoRecordsInDatabaseEx ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            DBcon.con.Close();
            if (lastID == counter)
                label.Text = (counter + 1).ToString();
            else if (counter == 0)
                label.Text = "1";
            else
                label.Text = (lastID + 1).ToString();
        }
        public static void AddData(ListBox listBox, string dbname) //method to add one data from database to the list
        {
            DBcon.con.Open();
            reader = DBcon.cmd("SELECT * FROM " + dbname).ExecuteReader();
            var list = new List<String>();

            while (reader.Read())
            {
                list.Add("ID " + reader.GetInt32(0) + " " + reader.GetString(1));
            }
            DBcon.con.Close();

            listBox.DataSource = list;
            listBox.DataBind();
        }
        public static void AddPatientData(ListBox listBox, string dbname) //method to add one data from database to the list
        {
            DBcon.con.Open();
            reader = DBcon.cmd("SELECT * FROM " + dbname + " WHERE isAv = 1").ExecuteReader();
            var list = new List<String>();

            while (reader.Read())
            {
                list.Add("ID " + reader.GetInt32(0) + " " + reader.GetString(1));
            }
            DBcon.con.Close();

            listBox.DataSource = list;
            listBox.DataBind();
        }
    }
}