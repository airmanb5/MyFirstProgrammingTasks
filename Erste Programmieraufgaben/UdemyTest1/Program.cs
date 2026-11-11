using static System.Runtime.InteropServices.JavaScript.JSType;

class UdemyTest1
{
    static void Main()
    {
        var firstName = "John";
        var lastName = "Smith";
        var age = 25;
        float f = 23.5f;

        Console.WriteLine(string.Format("{0} {1} {2}", firstName, lastName, age));

        Console.WriteLine($"{firstName} {lastName} {age}");

        Console.WriteLine(firstName + " " + lastName + " " + age);

        var names = new string[3] { "Jack", "John", "Mary" };

        var FormattedNames = string.Join(", ", names);

        Console.WriteLine(FormattedNames);

        var text = @"Hi John
Look into the following paths:
C:\FilesForTesting\TargetFolder
C:\FilesForTesting\TestFolder";

        Console.WriteLine(text);

        //Enum
        var method = ShippingMethod.Express;

        Console.WriteLine((int)method);

        var methodId = 2;
        Console.WriteLine((ShippingMethod)methodId);

        Console.WriteLine(method.ToString());

        var methodName = "Express";
        var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

        int[] numbers = new[] { 4, 5, 6, 3, 7, 9, 3 };

        int[] hallo = new int[] { 1, 2, 3 };

        int[] tschüss = new int[3];

        tschüss = hallo;

        tschüss[1] = 7;

        Console.WriteLine(hallo[1]);
    }
}

public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3
}