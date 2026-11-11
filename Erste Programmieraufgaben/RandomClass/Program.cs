class RandomClass
{
    static void Main()
    {
        var random = new Random();

        Console.Write("How long do you want your random password to be: ");
        int passwordLength = Convert.ToInt32(Console.ReadLine());

        char[] buffer = new char[passwordLength];

        for (var i = 0; i < passwordLength; i++)
        {
            buffer[i] = ((char)('a' + random.Next(0, 26)));
        }
        var password = new string(buffer);

        Console.WriteLine(password);

        Console.WriteLine();
    }
}
