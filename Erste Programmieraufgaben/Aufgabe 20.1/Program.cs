// 20.1 Benutze nun einen Algorithmus

class Aufgabe20_1
{
    static void Main()
    {
        bool isPalindrome = true;

        Console.Write("Gib das Wort ein, bei welchem du überprüfen willst, ob es ein Palindrom ist: ");
        string userInput = Console.ReadLine() ?? String.Empty;
        string lowercaseUserInput = userInput.ToLower();

        for (int i = 0; i < userInput.Length/2; i++)
        {
            int o = userInput.Length - i - 1;
            
            if (lowercaseUserInput[i] != (lowercaseUserInput[o]))
            {
                Console.WriteLine($"Das Wort {userInput} ist kein Palindrom.");

                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome) 
        { 
            Console.WriteLine($"Das Wort {userInput} ist ein Palindrom.");
        }
    }
}

