using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegestrationUsingRegex
{
   
    internal class Pattern
    {
        public static string Regex_Rule = "^[A-Za-z0-9]{3,}([.][a-zA-z]+)?[@][A-Za-z]+[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";

        public bool validateEmail(string inputString)
        {
            return Regex.IsMatch(inputString, Regex_Rule);
        }
    }
}
