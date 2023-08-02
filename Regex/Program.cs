using RegexProblems;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Regex Functionality");
        ValidatePincode validatePincode = new ValidatePincode();
        validatePincode.UC1_Validate("601201");
        validatePincode.UC2_Validate("601201");


    }
}