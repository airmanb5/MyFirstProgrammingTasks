using System.Transactions;

class UdemyCSharpFundamentalsExercisesArraysAndLists
{
    static void Main()
    {
        Exercise5();
    }

    static void Exercise1()
    {
        List<string> names = new List<string> { };

        while (true)
        {
            Console.Write("Enter a Name: ");
            string inputName = Console.ReadLine();

            if (String.IsNullOrEmpty(inputName))
            {
                break;
            }

            names.Add(inputName);
        }

        if (names.Count == 1)
        {
            Console.WriteLine($"{names[0]} likes your post.");
        }

        if (names.Count == 2)
        {
            Console.WriteLine($"{names[0]} and {names[1]} like your post.");
        }

        if (names.Count > 2)
        {
            Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post.");
        }
    }

    static void Exercise2()
    {
        Console.Write("Enter your Name: ");
        string inputName = Console.ReadLine();

        char[] inputAsChar = inputName.ToCharArray();

        Array.Reverse(inputAsChar);

        string reversedName = new string(inputAsChar);

        Console.WriteLine("Reversed Name: " + reversedName);

    }

    static void Exercise3()
    {
        const int amountOfNumbers = 5;

        List<int> numbers = new List<int>();

        while (numbers.Count != amountOfNumbers)
        {
            Console.Write("Enter a number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            if (numbers.Contains(inputNumber))
            {
                Console.WriteLine($"The number {inputNumber} has already been entered. Please try again.");
            }

            else
            {
                numbers.Add(inputNumber);
            }
        }

        numbers.Sort();

        Console.WriteLine("Sorted Numbers:");

        foreach (int number in numbers)

            Console.WriteLine(number);
    }

    static void Exercise4()
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter a number (or type Quit to exit): ");
            var userInput = Console.ReadLine();

            if (userInput == "Quit")
            {
                break;
            }

            int inputNumber = Convert.ToInt32(userInput);

            numbers.Add(inputNumber);
        }

        Console.WriteLine();
        Console.WriteLine("Enterd Numbers:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    static void Exercise5()
    {
        int leastAmountOfNumbers = 5;

        while (true)
        {
            Console.Write("Enter at least 5 numbers, seperated by commas: ");
            string inputNumbers = Console.ReadLine();

            string[] numbers = inputNumbers.Split(',');


            if (numbers.Length < leastAmountOfNumbers)
            {
                Console.WriteLine("Invalid List. Try again.");

                Array.Clear(numbers);
            }
            else
            {
                Array.Sort(numbers);

                Array.Sort (numbers);

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(numbers[i]);

                }
                break;

            }
        }






    }
}

