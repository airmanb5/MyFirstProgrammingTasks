// 18. Erstelle ein Programm, das einen Text aus einer Datei einliesst, den Anwender fragt, welches Zeichen durch welches ersetzt werden soll.
class Aufgabe18
{
    static void Main()
    {
        string originalFile = "text.txt";
        string changedFile = "newText.txt";
        string text;

        char character1 = GetUserInput("Gib ein, welches Zeichen du ersetzen willst: ");

        char character2 = GetUserInput($"Gib ein, durch welches Zeichen {character1} ersetzt werden soll: ");

        StreamReader sr = new(originalFile);
        text = sr.ReadToEnd();
        sr.Close();

        using StreamWriter sw = new(changedFile);

        foreach (char letter in text)
        {
            sw.Write(GetReplacedLetter(letter, character1, character2));
        }
        
        sw.Close();
    }

    static char GetUserInput(string requestText)
    {
        
        string? input;
        
        while (true)
        {
            Console.Write(requestText);
            input = Console.ReadLine();

            if (input?.Length != 1)
            {
                Console.WriteLine("Diese Eingabe ist ungültig.");
            }
            else
            {
                return Convert.ToChar(input);
            }
        }

    }
    
    static char GetReplacedLetter(char letter, char toBeReplaced, char replacement)
    {
        if (letter == toBeReplaced)
        {
            return replacement;
        }
        else
        {
            return letter;
        }
    }


}
