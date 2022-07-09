using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalApp
{
    public class NoRecordsInDatabaseEx : Exception
    {
        public NoRecordsInDatabaseEx() { }
        public NoRecordsInDatabaseEx(string name) : base(String.Format("No records found in Database", name)) //exception when user will type bad id name or something which is not in database
        {

        }
    }
}