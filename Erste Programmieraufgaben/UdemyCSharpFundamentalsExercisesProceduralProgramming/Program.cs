class UdemyCSharpFundamentalsProceduralProgramming
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

        int[] convertedNumbers = CopyStringArrayToIntArray(numbers);

        int numberToCheck = 0;

        if (CheckIfConsecutive(convertedNumbers, numberToCheck))
        {
            Console.WriteLine("Consecutive.");
        }
        else
        {
            Console.WriteLine("Not consecutive.");
        }
    }
    static void Exercise2()
    {
        Console.Write("Enter a few Numbers, seperated by a hyphen: ");
        string enteredNumbers = Console.ReadLine();
        string[] numbers = enteredNumbers.Split('-');

        Console.WriteLine(GetDuplicates(numbers, enteredNumbers));
    }
    static void Exercise3()
    {
        Console.Write("Enter a time: ");
        string inputTime = Console.ReadLine();

        if (GetInputValidation(inputTime))
        {
            Console.WriteLine("Ok");
        }
        else
        {
            Console.WriteLine("Invalid");
        }


    }
    static void Exercise4()
    {
        Console.Write("Enter a few words, seperated by a space: ");
        string enteredWords = Console.ReadLine();
        string[] words = enteredWords.Split(' ');

        List<string> convertedWords = ConvertToPascalCase(words);

        foreach (string convertedWord in convertedWords)
        {
            Console.Write(convertedWord);
        }

        Console.WriteLine();
    }
    static void Exercise5()
    {
        Console.Write("Enter an English word: ");
        string inputWord = Console.ReadLine();

        Console.WriteLine($"Amount of vowels in {inputWord}: {CountVowels(inputWord)}");
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

    public static bool CheckIfConsecutive(int[] convertedNumbers, int numberToCheck)
    {
        for (int i = 0; i < convertedNumbers.Length; i++)
        {
            if (i == 0 || convertedNumbers[i] == numberToCheck + 1 || convertedNumbers[i] == numberToCheck - 1)
            {
                numberToCheck = convertedNumbers[i];
                continue;
            }

            return false;
        }

        return true;
    }

    static public string GetDuplicates(string[] numbers, string enteredNumbers)
    {
        if (String.IsNullOrWhiteSpace(enteredNumbers))
        {
            return "No Input";
        }
        else
        {
            var newNumbers = new List<string>();

            foreach (string number in numbers)
            {
                if (newNumbers.Contains(number))
                {
                    return "1 or more duplicates";
                }
                newNumbers.Add(number);
            }

            return "No duplicates";
        }
    }

    static public bool GetInputValidation(string inputTime)
    {
        if (TimeSpan.TryParse(inputTime, out TimeSpan time))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static public List<string> ConvertToPascalCase(string[] words)
    {
        var convertedWords = new List<string>();

        foreach (string word in words)
        {
            string convertedWord = word;
            convertedWord = char.ToUpper(convertedWord[0]) + convertedWord.Substring(1).ToLower();

            convertedWords.Add(convertedWord);
        }

        return convertedWords;
    }

    static public int CountVowels(string inputWord)
    {
        int hitVowelCount = 0;

        foreach (char letter in inputWord)
        {
            if ("aeiou".Contains(char.ToLower(letter)))
            {
                hitVowelCount++;
            }
        }

        return hitVowelCount;
    }
}

