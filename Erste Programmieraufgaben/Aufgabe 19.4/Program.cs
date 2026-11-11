// 19.4. Benutze ein Dictionary
class Aufgabe19_4
{
    static void Main()
    {
        int inputNumber = -1;
        Dictionary<string, Int32> numbers = new Dictionary<string, int>();

        while (inputNumber != 0)
        {
            Console.WriteLine($"Zahl {numbers.Count + 1} eingeben: ");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber != 0)
            {
               numbers.Add("Zahl" + numbers.Count, inputNumber);
            }
        }
        var sorted = numbers.OrderBy(x => x.Value);

        foreach (var number in sorted)
        {
            Console.WriteLine(number.Value);
        }
    }
}
