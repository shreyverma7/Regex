using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblems.UserRegistrationProblem
{
    public class UserValidation
    {
        string uc1_FirstName = "^[A-Z]{1}[a-z]{2,}$";
        string uc2_LastName = "^[A-Z]{1}[a-z]{2,}$";
        string uc5_Password = "^[A-Za-z]{8,}$";  
        string uc6_PasswordCap = "^(?=.*[A-Z]).{8,}$"; 
        string uc7_PasswordNum = "^(?=.*\\d)(?=.*[A-Z]).{8,}$"; 
        string uc7_PasswordCapNumSym = "^(?=.*\\d)(?=.*[A-Z])(?=.*[!@#$%^&*]).{8,}$"; 
        string uc8_PasswordCapNumSym = "^(?=.*\\d)(?=.*[A-Z])(?=.*[!@#$%^&*]).{8,}$";
        string actualRegex = "^[a-z]+[._+-]{0,1}[a-z0-9]+[@]{1}[a-z0-9]+[.]{1}[a-z]{2,3}([.]{1}[a-z]{2,}){0,1}$";
        string uc4_Mobile = "^[0-9]{2}[ ]{1}[0-9]{10}$";

        public bool UC1_FirstName(string input)
        {
            if( Regex.IsMatch(input, uc1_FirstName)){
                Console.WriteLine("Validation Successful");
                return true;

            }
            else
            {
                Console.WriteLine("Validation UnSuccessful");
                return false;
            }
        }
        public bool UC2_LastName(string input)
        {
            if (Regex.IsMatch(input, uc2_LastName)){
                Console.WriteLine("Validation Successful");
                return true;

            }
            else
            {
                Console.WriteLine("Validation UnSuccessful");
                return false;
            }
        }
        public bool UC4_Mobile(string input)
        {
            if (Regex.IsMatch(input, uc4_Mobile)){
                Console.WriteLine("Validation Successful");
                return true;

            }
            else
            {
                Console.WriteLine("Validation UnSuccessful");
                return false;
            }
        }
        public bool UC5_Password(string input)
        {
            if (Regex.IsMatch(input, uc8_PasswordCapNumSym)){
                Console.WriteLine("Validation Successful");
                return true;

            }
            else
            {
                Console.WriteLine("Validation UnSuccessful");
                return false;
            }
        }
        public bool UC6_Email(string input)
        {
            if (Regex.IsMatch(input, actualRegex))
            {
                Console.WriteLine("Validation Successful");
                return true;

            }
            else
            {
                Console.WriteLine("Validation UnSuccessful");
                return false;
            }
        }
    }
}
