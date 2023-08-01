using RegexProblems;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Regex Functionality");
        ValidatePincode validatePincode = new ValidatePincode();
        validatePincode.Validate("601201");
        
    }
}