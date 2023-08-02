using RegexProblems;

internal class Program
{
    private static void Main(string[] args)
    {
        int num = 2;
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
               // email.UC4_Validate("abc"); 
                break;
        }
      
    }
}