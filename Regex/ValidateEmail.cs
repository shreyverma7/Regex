using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblems
{
    public class ValidateEmail
    {
        //abc.xyz@bridgelabz.co.in 
        string uc1_Regex = "^[a-z]{0,}$";
        public void UC1_Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc1_Regex);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation UnSuccessful");
        }
    }
}
