using RegexProblems;
using RegexProblems.UserRegistrationProblem;

internal class Program
{
    static string EmailArrayFilePath = @"D:\Bridgelabz Problem statement\Regex\Regex\EmailArray.txt"; 

    private static void Main(string[] args)
    {
        ValidateEmail check = new ValidateEmail();
        ValidateEmail email = new ValidateEmail();
        ValidatePincode validatePincode = new ValidatePincode();
        ValidateArrayEmail array = new ValidateArrayEmail();
        bool flag = true;

        while(flag)
        {
            Console.WriteLine("\n1.1.PINCODE \n2.Email Validate\n3.List of Email array\n4.User Registration \n5.Exit");
            Console.WriteLine("Enter input :");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Regex Functionality");
                    validatePincode.UC1_Validate("601201");
                    validatePincode.UC2_Validate("H601201");
                    validatePincode.UC3_Validate("601201H");
                    validatePincode.UC4_Validate("601 201");
                    validatePincode.UC4_Validate("601201");
                    break;
                case 2:
                    email.UC1_Validate("abc");
                    email.UC2_Validate("@bridgelabz");
                    email.UC3_Validate(".co");
                    email.UC4_Validate("abc.xyz");
                    email.UC5_Validate("abc.xyz@bridgelabz.co.in");
                    break;
                case 3:
                    array.read(EmailArrayFilePath);
                    break;
                case 4:
                    UserValidation registration = new UserValidation();
                    Console.WriteLine("Enter First Name :");
                    string Name = Console.ReadLine();
                    registration.UC1_FirstName(Name);
                    Console.WriteLine("Enter Last Name :");
                    string Last = Console.ReadLine();
                    registration.UC2_LastName(Last);
                    Console.WriteLine("Enter Email :");
                    string emailadd = Console.ReadLine();
                    check.UC5_Validate(emailadd);
                    Console.WriteLine("Enter Mobile :");//1234567890 or 91 1234567890
                    string mobiles = Console.ReadLine();
                    registration.UC4_Mobile(mobiles);
                    Console.WriteLine("Enter Password of Minimum 8 digit");
                    string pass = Console.ReadLine();
                    registration.UC5_Password(pass);
                    break;
                case 5:
                    Console.WriteLine("Bye tata !!");
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Enter valid input ");
                    break;
            }

        }
    }
}