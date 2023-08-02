using RegexProblems;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Regex Functionality");
        ValidatePincode validatePincode = new ValidatePincode();
        validatePincode.UC1_Validate("601201");
        validatePincode.UC2_Validate("H601201");
        validatePincode.UC3_Validate("601201H");
        validatePincode.UC4_Validate("601 201");
        validatePincode.UC4_Validate("601201");





    }
}