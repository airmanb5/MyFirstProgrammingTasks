// 2.Schreibe ein Programm, welches den Anwender nach seinem Namen fragt, und ihn dann begrüsst.
class Aufgabe2
{
    static void Main()
    {
        Console.Write("Bitte geben Sie Ihren Namen ein: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Hallo, dein Name ist " + name + "!");
        Console.WriteLine($"Hallo, {name}!");


    }
}
