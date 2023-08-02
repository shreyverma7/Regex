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
        string uc4_Regex_Optional = "^[a-z]+[._+-]{0,1}[a-z]{0,}$";
        string actualRegex = "^[a-z]+[._+-]{0,1}[a-z]+[@]{1}[a-z]+[.]{1}[a-z]{2,3}([.]{1}[a-z]{2}){0,1}$";
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
        public void UC4_Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc4_Regex_Optional);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation UnSuccessful");
        }
        public void UC5_Validate(string input)
        {
            bool result = Regex.IsMatch(input, actualRegex);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation UnSuccessful");
        }
    }
}
