// 18.2. Erstelle ein Programm, das einen Text aus einer Datei einliesst, den Anwender fragt, wie oft eine Zeichenfolge(Wort) vorkommt.
class Aufgabe18_2
{
    static void Main()
    {
        string? restart;

        do
        {
            int hitWordCount = 0;

            StreamReader sr = new("text.txt");
            string textFromFile = sr.ReadToEnd();
            sr.Close();

            textFromFile = textFromFile.ToLower();

            Console.Write("Gesuchtes Wort: ");
            string? inputWord = Console.ReadLine();
            inputWord = inputWord.ToLower();

            string[] splitText = textFromFile.Split(inputWord);
            hitWordCount = splitText.Length - 1;
            
            Console.WriteLine($"Das Wort {inputWord} kommt im Text {hitWordCount} mal vor.");

            Console.Write("Zum erneuten Ausführen bitte C eingeben: ");
            restart = Console.ReadLine();

        } while (restart?.ToLower() == "c");
    }
}