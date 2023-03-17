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
        public static string Regex_Rule = "^[+]?[0-9]{2}[ ][0-9]{10}$";

        public bool validatePhoneNumber(string inputString)
        {
            return Regex.IsMatch(inputString, Regex_Rule);
        }
    }
}
