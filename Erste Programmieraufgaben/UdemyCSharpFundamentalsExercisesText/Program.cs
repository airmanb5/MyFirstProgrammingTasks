using System.ComponentModel.Design;

class UdemyCSharpFundamentalsExercisesText
{
    static void Main()
    {
        Exercise5();
    }

    static void Exercise1()
    {
        Console.Write("Enter a few Numbers, seperated by a hyphen: ");
        string enteredNumbers = Console.ReadLine();
        string[] numbers = enteredNumbers.Split('-');

        bool isConsecutive = true;
        int[] convertedNumbers = CopyStringArrayToIntArray(numbers);

        int numberToCheck = 0;

        for (int i = 0; i < convertedNumbers.Length; i++)
        {
            if (i == 0 || convertedNumbers[i] == numberToCheck + 1 || convertedNumbers[i] == numberToCheck - 1)
            {
                numberToCheck = convertedNumbers[i];
                continue;
            }

            isConsecutive = false;
            Console.WriteLine("Not consecutive.");
            break;
        }

        if (isConsecutive)

        {
            Console.WriteLine("Consecutive.");
        }
    }
    static void Exercise2()
    {
        Console.Write("Enter a few Numbers, seperated by a hyphen: ");
        string enteredNumbers = Console.ReadLine();
        string[] numbers = enteredNumbers.Split('-');

        var newNumbers = new List<string>();

        if (String.IsNullOrWhiteSpace(enteredNumbers))
        {
            Console.WriteLine("No Input");
        }
        else
        {
            foreach (string number in numbers)
            {
                if (newNumbers.Contains(number)) 
                {
                    Console.WriteLine("Duplicate: " + number);
                }
                else
                {
                    newNumbers.Add(number);
                }
            }
        }
    }
    static void Exercise3()
    {
        Console.Write("Enter a time: ");
        string inputTime = Console.ReadLine();

        if(TimeSpan.TryParse(inputTime, out TimeSpan time))
        {
            Console.WriteLine("Ok " + time);
        }
        else
        {
            Console.WriteLine("Invalid Time.");
        }
    }
    static void Exercise4()
    {
        Console.Write("Enter a few words, seperated by a space: ");
        string enteredWords = Console.ReadLine();
        string[] words = enteredWords.Split(' ');

        foreach (string word in words)
        {
            string ConvertedWord = word;
            ConvertedWord = char.ToUpper(ConvertedWord[0]) + ConvertedWord.Substring(1).ToLower();
            Console.Write(ConvertedWord);
        }
        Console.WriteLine();
    }
    static void Exercise5()
    {
        Console.Write("Enter an English word: ");
        string inputWord = Console.ReadLine();

        int hitVowelCount = 0;

        foreach (char letter in inputWord)
        { 
            if ("aeiou".Contains(char.ToLower(letter)))
            {
                hitVowelCount++;
            }
        }

        Console.WriteLine($"Amount of vowels in {inputWord}: {hitVowelCount}");
    }

    static int[] CopyStringArrayToIntArray(string[] numbers)
    {
        int[] convertedNumbers = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            convertedNumbers[i] = Convert.ToInt32(numbers[i]);
        }

        return convertedNumbers;
    }
}

