
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

class UdemyCSharpFundamentalsConditionalsExercises
{
    static void Main()
    {
        Exercise1();
        Exercise2();
        Exercise3();
        Exercise4();
    }

    static void Exercise1()

    {
        Console.Write("Enter a number between 1-10: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        if (inputNumber <= 10 && inputNumber >= 1)
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }

    public static void Exercise2()
    {
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("Number 1 is bigger: " + num1);
        }
        else if (num1 < num2)
        {
            Console.WriteLine("Number 2 is bigger: " + num2);
        }
        else
        {
            Console.WriteLine("The numbers are equally big.");
        }
    }
    static void Exercise3()
    {
        Console.Write("Enter the width of the image: ");
        int inputWidth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height of the image: ");
        int inputHeight = Convert.ToInt32(Console.ReadLine());

        if (inputHeight > inputWidth)
        {
            Console.WriteLine("The image is a Portrait.");
        }
        else if (inputHeight < inputWidth)
        {
            Console.WriteLine("The image is a Landscape.");
        }
        else
        {
            Console.WriteLine("The image is a square.");
        }
    }

    static void Exercise4()
    {
        Console.WriteLine("Enter the speed limit: ");
        int inputSpeedLimit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the speed of the car: ");
        int inputCarSpeed = Convert.ToInt32(Console.ReadLine());

        if (inputSpeedLimit > inputCarSpeed)
        {
            Console.WriteLine("Ok.");

        }
        else
        {
            int demeritPointsCount = (inputCarSpeed - inputSpeedLimit) / 5;

            Console.WriteLine("Number of Demerit Points: " + demeritPointsCount);

            if (demeritPointsCount > 12)
            {
                Console.WriteLine("License Suspended");
            }
        }
    }
}



