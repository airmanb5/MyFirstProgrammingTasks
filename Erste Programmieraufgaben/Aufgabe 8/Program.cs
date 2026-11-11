// 8. Eine vom Benutzer eingegebene Zahl soll überprüft werden ob es eine Primzahl ist
// 8.1. Geben Sie alle Primzahlen zwischen 2 und einer vom Benutzer einzugebende Obergrenze aus. Bestimmen Sie die Primzahlen mittels Ganzzahldivision.
class Aufgabe8
{
    static void Main()
    {
        Console.Write("Gib eine Zahl ein, die von 2 aufwärts jede Zahl bis zu dieser Obergrenze auf eine Primzahl überprüft: ");
        int input = Convert.ToInt32(Console.ReadLine());


        for (int currentNumber = 2; currentNumber <= input; currentNumber++)
        {
            // Berechnung ob eine Zahl eine Primzahl ist
            bool isPrimeNumber = true;
            for (int divider = 2; divider < currentNumber; divider++)
            {
                if (currentNumber % divider == 0)
                {
                    isPrimeNumber = false;
                    break;
                }
            }
            if (isPrimeNumber)
            {
                Console.WriteLine(currentNumber);
            }
            // Ende der Berechnung ob es eine Primzahl ist
        }
    }
}
