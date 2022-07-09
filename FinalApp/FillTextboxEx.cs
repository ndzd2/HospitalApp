using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalApp
{
    public class FillTextboxEx : Exception
    {
        public FillTextboxEx() { }
        public FillTextboxEx(string name) : base(String.Format("Please fill every textbox", name)) //exception which tell user that he forgot to fill every required textbox
        {

        }
    }
}