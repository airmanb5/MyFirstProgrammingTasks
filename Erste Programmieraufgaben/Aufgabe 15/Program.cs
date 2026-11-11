// 15. Schreiben Sie ein Programm, das einen Text aus einer Datei einliest. Der Anwender wird aufgefordert einen Buchstaben einzugeben. Das Programm soll ermitteln, wie oft der Buchstabe in dem Text vorkommt und soll diesen Buchstaben aus dem Text löschen. Der Text soll in einer neuen Datei gespeichert werden
class Aufgabe14
{
    static void Main()
    {
        string? restart;
        do
        {
            string originalFile = "text.txt";
            string changedFile = "newText.txt";
            int hitLetterCount = 0;
            string text;

            StreamReader sr = new(originalFile);
            text = sr.ReadToEnd();
            sr.Close();

            using StreamWriter sw = new(changedFile);

            Console.Write("Gesuchter Buchstabe: ");
            string? input = Console.ReadLine();

            if (input?.Length != 1)
            {
                Console.WriteLine("Diese Eingabe ist ungültig.");
                sw.Write(text);
            }
            else
            {
                char inputLetter = Convert.ToChar(input);
                for (int currentPosition = 0; currentPosition < text.Length; currentPosition++)
                {
                    if (text[currentPosition] == inputLetter)
                    {
                        hitLetterCount++;
                    }
                    else
                    {
                        sw.Write(text[currentPosition]);
                    }
                }
                Console.WriteLine($"Der Buchstabe {inputLetter} kommt im Text {hitLetterCount} mal vor und wurde in der Datei {changedFile} gelöscht.");
            }

            sw.Close();

            Console.WriteLine($"Du kannst die Datei {changedFile} jetzt anschauen und bearbeiten. Vorm erneuten Ausführen die Datei wieder schliessen.");
            Console.Write("Zum erneuten Ausführen bitte c eingeben: ");
            restart = Console.ReadLine();
        } while (restart?.ToLower() == "c");




    }
}
