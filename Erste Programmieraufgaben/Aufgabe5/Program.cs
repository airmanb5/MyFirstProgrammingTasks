// 5. Eine eingegebene Zahl soll überprüft werden, ob sie gerade oder ungerade ist. Via Ganzzahl Division.
class Aufgabe5
{
    static void Main()
    {
        Console.Write("Welche Zahl willst du überprüfen? ");
        Int32 number = Convert.ToInt32 (Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Gerade");
        }
        else
        { 
            Console.WriteLine("Ungerade");
        }

    }
}
