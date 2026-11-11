class TestStrings
{
    static void Main()
    {
        var fullName = "Mark de Vries ";
        Console.WriteLine("Trim: '{0}'", fullName.Trim());
        Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());

        var index = fullName.IndexOf(' ');
        var firstName   = fullName.Substring(0, index);
        var lastName = fullName.Substring(index + 1);

        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);

        var names = fullName.Split(' ');
        Console.WriteLine("First Name: "+ names[0]);
        Console.WriteLine("Last Name: "+ names[1] + " " + names[2]);

        Console.WriteLine(fullName.Replace("Mark", "Marko"));
        Console.WriteLine(fullName.Replace('r', 'R'));

        if (String.IsNullOrWhiteSpace(" "))
        {
            Console.WriteLine("Invalid");
        }


        var str = "25";
        var age = Convert.ToByte(str);
        Console.WriteLine("Age: " + age);

        float price = 29.95f;
        Console.WriteLine(price.ToString("C")); 
        Console.WriteLine(price.ToString("C0")); 

    }
}
