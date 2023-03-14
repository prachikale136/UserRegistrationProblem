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
        //Prachi
        public static string FirstName = "^[A-Z][a-z]{2,}$";
        public static string LastName = "^[A-Z][a-z]{2,}$";
        public static bool ValidateString(string sample)
        {
            return Regex.IsMatch(sample, FirstName);
        }

        
    }
}
