// 9. Schreibe ein Programm, das zu einer eingegebenen natürlichen Zahl alle Teiler ausgibt.
class Aufgabe9
{
    static void Main()
    {
        Console.Write("Gib eine Zahl ein, zu der du alle Teiler wissen willst: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Die Teiler zu " + number + " lauten: ");
        for (int divider = 1; divider <= number; divider++)
        {
            if (number % divider == 0)
            {
                Console.WriteLine(divider);
            }
        }
    }
}
