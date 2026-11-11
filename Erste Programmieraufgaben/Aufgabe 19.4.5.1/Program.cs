// 19.4.5.1. Alle Eingabe sollen auf ihre Gültigkeit überprüft und Ungültige Werte sollen verworfen werden. Wurden drei falsche Werte hintereinander eingeben werden, so beendet sich das Programm.

class Aufgabe19_4_5_1
{
    static void Main()
    {
        int invalidCharacterCount = 0;
        bool areAllNumbersEntered = false;
        const int minRange = 1;
        const int maxRange = 9;
        string? sortOption = string.Empty;

        Dictionary<int, string> numbers = new Dictionary<int, string>();

        while (!areAllNumbersEntered)
        {
            if (invalidCharacterCount == 3)
            {
                return;
            }
            else
            {
                Console.Write($"Gib Zahl Nr. {numbers.Count + 1} ein: ");
                if (!int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    Console.WriteLine("Bitte eine gültige Zahl eingeben.");
                    invalidCharacterCount++;
                    continue;
                }
                if (numbers.ContainsKey(inputNumber))
                {
                    Console.WriteLine("Diese Zahl wurde schon eingegeben.");
                }
                else if (inputNumber >= minRange && inputNumber <= maxRange)
                {
                    numbers.Add(inputNumber, GetNumberAsString(inputNumber));

                    areAllNumbersEntered = numbers.Count == maxRange;
                }
                else
                {
                    Console.WriteLine(GetNumberAsString(inputNumber));
                    invalidCharacterCount++;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine($"a) Die Zahlen von {minRange} bis {maxRange} sortieren.");
        Console.WriteLine($"b) Die Zahlen von {maxRange} bis {minRange} sortieren.");
        Console.WriteLine("c) Die Zahlen unsortiert lassen.");

        while (sortOption != "a" && sortOption != "b" && sortOption != "c")
        {
            Console.Write("Welche Option wählst du: ");

            sortOption = Console.ReadLine();
            sortOption = sortOption?.ToLower();

            if (sortOption == "a")
            {
                var sortedAscendingOrder = numbers.OrderBy(x => x.Key);

                foreach (var number in sortedAscendingOrder)
                {
                    Console.WriteLine($"{number.Key}: {number.Value}");
                }
            }

            else if (sortOption == "b")
            {
                var sortedDescendingOrder = numbers.OrderByDescending(x => x.Key);

                foreach (var number in sortedDescendingOrder)
                {
                    Console.WriteLine($"{number.Key}: {number.Value}");
                }
            }

            else if (sortOption == "c")
            {

                foreach (var number in numbers)
                {
                    Console.WriteLine($"{number.Key}: {number.Value}");
                }
            }
            else
            {
                Console.WriteLine("Dies ist keine Option.");
            }
        }
    }

    static string GetNumberAsString(int number)
    {
        return number switch
        {
            1 => "eins",

            2 => "zwei",

            3 => "drei",

            4 => "vier",

            5 => "fünf",

            6 => "sechs",

            7 => "sieben",

            8 => "acht",

            9 => "neun",

            _ => "Ungültige Eingabe!"

        };
    }
}