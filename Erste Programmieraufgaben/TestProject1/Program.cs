class TestProject1
{
    static void Main()
    {
        HelloWorld();

        Hello("Markus");

        int result = Add(3, 4);

        int result2 = Add(3, 4, 5);

        double result3 = Add(3.0, 4.0, 5.0);

        double result4 = Add(3.0, 4.0, 5.0, 6.0);

        Console.WriteLine(result);

        Console.WriteLine(result2);

        Console.WriteLine(result3);
    }

    static void HelloWorld()
    {
        Console.WriteLine("Hello World!");
    }

    static void Hello(string name)
    {
        Console.WriteLine($"Hello {name}");
    }

    static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    static int Add(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

    static double Add(double num1, double num2, double num3 = 0, double num4 = 0)
    {
        return num1 + num2 + num3 + num4;
    }
}
