//19.4.1. Bei dieser Übung können nur Zahlen von 1-9 in einer nicht definierten Reihenfolge eingegeben werden. Mit jeder Zahl wird ein neues Dictionary Element wie folgt erzeugt 1 = (1, eins) 2 = (2,zwei) u.s.w.
// Wurden alle Zahlen eingegeben, so ist die Eingabe beendet und die Zahlen werden sortiert nach Usereingabe

using System.Runtime.InteropServices;
class Aufgabe19_4_1_1
{
    static void Main()
    {
        int inputNumber = -1;
        bool allEntered = false;
        int minRange = 1;
        int maxRange = 9;

        Dictionary<int, string> numbers = new Dictionary<int, string>();

        while (allEntered == false)
        {
            Console.Write($"Gib Zahl Nr. {numbers.Count + 1} ein: ");
            inputNumber = Convert.ToInt32(Console.ReadLine());

            if (numbers.ContainsKey(inputNumber))
            {
                Console.WriteLine("Diese Zahl wurde schon eingegeben");
            }
            else if (inputNumber >= minRange && inputNumber <= maxRange)
            {
                numbers.Add(inputNumber, GetNumberAsString(inputNumber));

                for (int i = 1; i <= maxRange; i++)
                {
                    if (numbers.ContainsKey(i))
                    {
                        allEntered = true;
                    }
                    else
                    {
                        allEntered = false;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine(GetNumberAsString(inputNumber));
            }
        }

        foreach (var number in numbers)
        {
            Console.WriteLine($"{number.Key}: {number.Value}");
        }
    }

    static string GetNumberAsString(int getInputNumber)
    {
        switch (getInputNumber)
        {
            case 1:
                return "eins";

            case 2:
                return "zwei";

            case 3:
                return "drei";

            case 4:
                return "vier";

            case 5:
                return "fünf";

            case 6:
                return "sechs";

            case 7:
                return "sieben";

            case 8:
                return "acht";

            case 9:
                return "neun";

            default:
                return "Ungültige Eingabe!";

        }
    }

}