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
        public void UC1_FirstName(string input)
        {
            bool result = Regex.IsMatch(input, uc1_FirstName);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation UnSuccessful");
        }
    }
}
