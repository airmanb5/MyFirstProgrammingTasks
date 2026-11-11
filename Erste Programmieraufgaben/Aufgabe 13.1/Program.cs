/* 13.	Schreibe ein Programm, das alle bisherigen Matheaufgaben bewältigen kann. Der Anwender soll zuerst gefragt werden, was er berechnen möchte.
z.B.: 	a -> Primzahlen Berechnung
		b -> Teiler einer Zahl ermitteln
		c -> Grundrechenarten.
		d -> Kapitalberechnung
Nach der Auswahl (a,b,c oder d) soll das Programm die entsprechende Aufgabe erledigen. Am Ende soll der Anwender gefragt werden, ob er weiterrechnen möchte.*/

using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Aufgabe13_1
{
    static void Main()
    {
        string? proceed = "p";
        do
        {
            Console.WriteLine("a) Primzahlen");
            Console.WriteLine("b) Teiler einer Zahl ermitteln");
            Console.WriteLine("c) Grundrechenarten");
            Console.WriteLine("d) Kapitalberechnung");
            Console.Write("Gib ein, was du berechnen möchtest: ");
            string? inputAnswer = Console.ReadLine();

            switch (inputAnswer.ToLower())
            {
                case "a":
                    PrimeNumber();
                    break;

                case "b":
                    Dividers();
                    break;

                case "c":
                    BasicOperations();
                    break;

                case "d":
                    Capital();
                    break;

                default:
                    Console.WriteLine("Dieser Input ist nicht erlaubt. Bitte versuche es erneut.");
                    break;
            }

            Console.Write("Tippe P, wenn du nochmal rechnen willst. Wenn nicht, drücke eine beliebige Taste: ");
            proceed = Console.ReadLine();
        } while ("p" == (proceed.ToLower()));
    }

    static void PrimeNumber()
    {
        Console.WriteLine("Du hast die Primzahlermittlung gewählt.");
        Console.Write("Gib ein, welche Zahl auf eine Primzahl überprüft werden soll: ");
        int inputPrimeNumber = Convert.ToInt32(Console.ReadLine());
        bool isPrimeNumber = true;
        for (int divider = 2; divider < inputPrimeNumber; divider++)
        {
            if (inputPrimeNumber % divider == 0)
            {
                isPrimeNumber = false;
                break;
            }
        }
        if (isPrimeNumber)
        {
            Console.WriteLine($"{inputPrimeNumber} ist eine Primzahl.");
        }
        else
        {
            Console.WriteLine($"{inputPrimeNumber} ist keine Primzahl.");
        }
    }

    static void Dividers()
    {
        Console.WriteLine("Du hast die Teilerermittlung einer Zahl gewählt.");
        Console.Write("Gib die Zahl ein, dessen Teiler du kennen willst: ");
        int inputDivision = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Die Teiler zu {inputDivision} lauten: ");
        for (int seperator = 1; seperator <= inputDivision; seperator++)
        {
            if (inputDivision % seperator == 0)
            {
                Console.WriteLine(seperator);
            }
        }
    }

    static void BasicOperations()
    {
        Console.WriteLine("Du hast die Grundoperationen gewählt.");
        Console.WriteLine("Gib die erste Zahl ein: ");
        double inputBasicOperations1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Gib die zweite Zahl ein");
        double inputBasicOperations2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{inputBasicOperations1} + {inputBasicOperations2} ergibt {inputBasicOperations1 + inputBasicOperations2}.");
        Console.WriteLine($"{inputBasicOperations1} - {inputBasicOperations2} ergibt {inputBasicOperations1 - inputBasicOperations2}.");
        Console.WriteLine($"{inputBasicOperations1} * {inputBasicOperations2} ergibt {inputBasicOperations1 * inputBasicOperations2}.");
        Console.WriteLine($"{inputBasicOperations1} / {inputBasicOperations2} ergibt {inputBasicOperations1 / inputBasicOperations2}.");
    }

    static void Capital()
    {
        Console.WriteLine("Du hast die Kapitalrechnung gewählt.");
        double interestRate = 5;
        double goal = 10000;
        int duration = 0;
        Console.Write("Gib das Startkapital an: ");
        double startKapital = Convert.ToDouble(Console.ReadLine());
        double aktuellesKapital = startKapital;
        while (aktuellesKapital < goal)
        {
            aktuellesKapital += aktuellesKapital * interestRate / 100;
            duration++;
        }
        Console.WriteLine($"Benötigte Laufzeit: {duration} Jahre");
    }
}

