class UdemyCSharpFundamentalsExercisesFilesAndDirectories
{
    static void Main()
    {
        Exercise2();
    }

    static void Exercise1()
    {
        var path = @"C:\FilesForTesting\testtext.txt";

        var fullText = File.ReadAllText(path);

        var separatedWords = fullText.Split(' ');

        Console.WriteLine("Amount of Words: " + separatedWords.Length);

    }

    static void Exercise2()
    {
        var path = @"C:\FilesForTesting\testtext.txt";

        var fullText = File.ReadAllText(path);

        var separatedWords = fullText.Split(' ');   

        Console.WriteLine($"The longest word has {GetLongestWord(separatedWords)} letters");
    }

    static public int GetLongestWord(string[] separatedWords)
    {
        var wordLetterCount = 0;

        foreach (var word in separatedWords)
        {
            if (word.Length > wordLetterCount)
            {
                wordLetterCount = word.Length;
            }
        }

        return wordLetterCount;
    }
}
