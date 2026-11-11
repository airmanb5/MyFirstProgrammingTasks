// 19.2 Verwende ein List
class Aufgabe19_2
{
    static void Main()
    {
        int inputNumber = -1;

        List<int> numbers = new List<Int32>();

        while (inputNumber != 0)
        {
            Console.WriteLine($"Zahl {numbers.Count + 1} eingeben: ");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        }

        numbers.Sort();

        Console.WriteLine("");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("");
        Console.WriteLine("Bei einem Array muss man die Anzahl der vorhandenen Plätze vorher definieren, während man bei einer List immer neue Plätze hinzufügen kann.");
    }
}
