using RegexProblems;
using RegexProblems.UserRegistrationProblem;

internal class Program
{
    static string EmailArrayFilePath = @"D:\Bridgelabz Problem statement\Regex\Regex\EmailArray.txt"; 

    private static void Main(string[] args)
    {
        
        int num = 5;
        switch (num)
        {
            case 1:
                Console.WriteLine("Regex Functionality");
                ValidatePincode validatePincode = new ValidatePincode();
                validatePincode.UC1_Validate("601201");
                validatePincode.UC2_Validate("H601201");
                validatePincode.UC3_Validate("601201H");
                validatePincode.UC4_Validate("601 201");
                validatePincode.UC4_Validate("601201");
                break;
            case 2:
                ValidateEmail email = new ValidateEmail();
                email.UC1_Validate("abc"); 
                email.UC2_Validate("@bridgelabz"); 
                email.UC3_Validate(".co"); 
                email.UC4_Validate("abc.xyz"); 
                email.UC5_Validate("abc.xyz@bridgelabz.co.in"); 
                break;
            case 3:
                ValidateEmail check = new ValidateEmail();
                check.UC5_Validate("abc@yahoo.com");
                check.UC5_Validate("abc-100@yahoo.com");
                check.UC5_Validate("abc.100@yahoo.com");
                check.UC5_Validate("abc111@abc.com");
                check.UC5_Validate("abc-100@abc.net");
                check.UC5_Validate("abc.100@abc.com.au");
                check.UC5_Validate("abc@1.com");
                check.UC5_Validate("abc@gmail.com.com");
                check.UC5_Validate("abc+100@gmail.com");
                break;
            case 4:
                ValidateArrayEmail array = new ValidateArrayEmail();
                array.read(EmailArrayFilePath);
                break;
            case 5:
                UserValidation registration = new UserValidation();
                registration.UC1_FirstName("Shrey");
                registration.UC2_LastName("Verma");
                break;
        }
      
    }
}