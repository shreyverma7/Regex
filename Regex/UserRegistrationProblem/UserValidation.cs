using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblems.UserRegistrationProblem
{
    internal class UserValidation
    {
        string uc1_FirstName = "^[A-Z]{1}[a-z]{2,}$";
        string uc2_LastName = "^[A-Z]{1}[a-z]{2,}$";
        string uc4_Mobile = "^[0-9]{2}[ ]{1}[0-9]{10}$ || ^[0-9]{10}$";

        public void UC1_FirstName(string input)
        {
            bool result = Regex.IsMatch(input, uc1_FirstName);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation UnSuccessful");
        }
        public void UC2_LastName(string input)
        {
            bool result = Regex.IsMatch(input, uc2_LastName);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation UnSuccessful");
        }
        public void UC4_Mobile(string input)
        {
            bool result = Regex.IsMatch(input, uc4_Mobile);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation UnSuccessful");
        }
    }
}
