using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FinalApp
{
    public class DBcon //Here you can connect to your database by calling this class, without typing database details everywhere, where you want to use it
    {
        public static SqlConnection con = new SqlConnection(@"data source = DESKTOP-OP572JJ; initial catalog = Capstone; integrated security = true; MultipleActiveResultSets = True");
        public static void TryCatchSql(SqlCommand com)
        {
            try
            {
                com.ExecuteNonQuery();
            } catch(SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
        public static SqlCommand cmd(string command) //this is commont method to call sql command
        {
            return new SqlCommand(command, con);
        }
    }
}