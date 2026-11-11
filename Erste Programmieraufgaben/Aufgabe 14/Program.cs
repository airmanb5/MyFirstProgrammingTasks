// 14. Schreiben Sie ein Programm, das einen Text aus einer Datei einliest. Der Anwender wird aufgefordert einen Buchstaben einzugeben. Das Programm soll ermitteln, wie oft der Buchstabe in dem Text vorkommt.

using System.ComponentModel.Design;
using System.Runtime.InteropServices;

class Aufgabe14
{
    static void Main()
    {
        string? restart;

        do
        {
            int hitLetterCount = 0;

            StreamReader sr = new("text.txt");
            string text = sr.ReadToEnd();
            sr.Close();

            Console.Write("Gesuchter Buchstabe: ");
            string? input = Console.ReadLine();

            if (input?.Length != 1)
            {
                Console.WriteLine("Diese Eingabe ist ungültig.");
            }
            else
            {
                char inputLetter = Convert.ToChar(input);

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == inputLetter)
                    {
                        hitLetterCount++;
                    }
                }

                Console.WriteLine($"Der Buchstabe {inputLetter} kommt im Text {hitLetterCount} mal vor.");
            }

            Console.Write("Zum erneuten Ausführen bitte C eingeben: ");
            restart = Console.ReadLine();

        } while (restart?.ToLower() == "c");
    }
}