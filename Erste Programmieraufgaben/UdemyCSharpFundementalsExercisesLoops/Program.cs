class UdemyCSharpFundementalsExercisesLoops
{
    static void Main()
    {
        Exercise5();
    }

    static void Exercise1()
    {
        int startNumber = 1;
        int endNumber = 100;
        int divider = 3;
        int count = 0;

        for (int i = startNumber; i <= endNumber; i++)
        {
            if (i % divider == 0)
            {
                count++;
            }
        }
        
        Console.WriteLine(count);
    }

    static void Exercise2()
    {
        int addedNumbers = 0;

        while (true)
        {
            Console.Write("Enter a number: ");

            string input = Console.ReadLine();

            if (input == "ok")
            {
                break;
            }

            int inputNumber = Convert.ToInt32(input);
            addedNumbers += inputNumber;
        }

        Console.WriteLine(addedNumbers);
    }

    static void Exercise3()
    {
        int multipliedNumbers = 1;

        Console.Write("Enter a number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        for (int i = inputNumber; i >= 1; i--)
        {
            multipliedNumbers *= i;
        }

        Console.WriteLine($"{inputNumber}! = {multipliedNumbers}");
    }

    static void Exercise4()
    {
        bool wasNumberGuessed = false;
        var random = new Random();
        int amountOfGuesses = 10;
        int randomNumber = random.Next(1, 4);

        for (int i = 1; i <= amountOfGuesses; i++)
        {
            Console.WriteLine($"Try Nr. {i} of {amountOfGuesses}");
            Console.Write("Guess the number: ");   
            int guessedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (guessedNumber == randomNumber)
            {
                wasNumberGuessed = true;
                break;
            }
        }

        if (wasNumberGuessed)
        {
            Console.WriteLine("You won!");
        }
        else
        {
            Console.WriteLine("You lost!");
            Console.WriteLine($"The number was {randomNumber}!");
        }
    }

    static void Exercise5()
    {
        Console.WriteLine("Enter a few numbers: ");
        string inputNumbers = Console.ReadLine();

        string[] numbers = inputNumbers.Split(',');

        int max = 0;

        foreach ( var number in numbers)
        {
            int convertetNumber = Convert.ToInt32(number);

            if (convertetNumber > max)
            {
                max = convertetNumber;
            }
        }

        Console.WriteLine(max);
    }
}