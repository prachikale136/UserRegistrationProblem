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
        public static string Regex_Rule = "^[A-Za-z]{8,}[A-Z]+[0-9]+@([!@#$%^&*])$";

        public bool validatePassword(string inputString)
        {
            return Regex.IsMatch(inputString, Regex_Rule);
        }

       
    }
}
