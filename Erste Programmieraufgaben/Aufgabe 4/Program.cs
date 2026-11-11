//4.	Lesen Sie zwei ganze Zahlen ein und geben Sie deren Summe, Produkt, Differenz und Quotienten aus.

class Aufgabe5
{
    static void Main()
    {
        Console.WriteLine("Gib die erste Zahl ein: ");
        double Nummer1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Gib die zweite Zahl ein");
        double Nummer2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Die Summe der beiden Zahlen beträgt: " + (Nummer1 + Nummer2)); 

        Console.WriteLine("Die Differenz der beiden Zahlen beträgt: " + (Nummer1 - Nummer2));

        Console.WriteLine("Das Produkt der beiden Zahlen beträgt: " + (Nummer1 * Nummer2));

        Console.WriteLine("Der Quotient der beiden Zahlen beträgt: " + (Nummer1 / Nummer2));

    }
}