// 12. Schreibe ein Programm, das 6 natürliche Zahlen (z.B. Schulnoten) einliest und deren Mittelwert (im Beispiel den Notendurchschnitt) berechnet.
// 12.1. Verwende ein Array
// 12.2. Verwende ein List. Der Anwender kann solange Schulnoten eingeben, bis er eine 0 eingibt. Es dürfen auch nur gültige Schulnoten eingegeben werden

class Aufgabe12
{
    static void Main()
    {
        int amount = 6;

        double[] numbers = new double[amount];
        for (int i = 0; i < amount; i++)
        {
            Console.WriteLine($"Zahl {i + 1} eingeben: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        double sum = 0;
        foreach (double number in numbers)
        {
            sum += number;
        }
        double quotient = sum / numbers.Length;
        Console.WriteLine($"Der Durchscnitt dieser {amount}  Zahlen lautet: {quotient}");

        

    }
}
