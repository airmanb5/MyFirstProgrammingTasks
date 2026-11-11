// 20. Schreibe ein Programm, das einen Text daraufhin überprüft, ob es sich um ein Palindrom handelt
class Aufgabe20
{
    static void Main()
    {
        Console.Write("Gib das Wort ein, bei welchem du überprüfen willst, ob es ein Palindrom ist: ");
        string userInput = Console.ReadLine() ?? String.Empty;
        
        string lowercaseText = userInput.ToLower();

        char[] inputAsChar = lowercaseText.ToCharArray();
        Array.Reverse(inputAsChar);

        string reversed = new string(inputAsChar);

        if (reversed == lowercaseText)
        {
            Console.WriteLine($"Das Wort {userInput} ist ein Palindrom");
        }
        else
        {
            Console.WriteLine($"Das Wort {userInput} ist kein Palindrom.");
        }
    }
}
