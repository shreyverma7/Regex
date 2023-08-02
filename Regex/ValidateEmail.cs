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
        string uc2_Regex = "^[@]{1}[a-z]{0,}$";
        string uc3_Regex = "^[.]{1}[a-z]{2}$";
        public void UC1_Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc1_Regex);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation UnSuccessful");
        }
        public void UC2_Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc2_Regex);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation UnSuccessful");
        }
        public void UC3_Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc3_Regex);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation UnSuccessful");
        }
    }
}
