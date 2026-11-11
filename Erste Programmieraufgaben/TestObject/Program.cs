class TestObject
{
    static void Main()
    {
        var name = "Mark";
        var age = 16;

        var name2 = "Markus";
        var age2 = 52;

        DateTime birthday1 = new DateTime(2010, 08, 16);
        DateTime birthday2 = new DateTime(1973, 10, 25);

        Console.WriteLine($"{name} ist {age} Jahre alt.");
        Console.WriteLine($"{name2} ist {age2} Jahre alt.");

        Person person1 = new Person(birthday1);
        Person person2 = new Person(birthday2, "Markus");
        Person person3 = new Person();

        person1.SetName("Mark");

        Console.WriteLine($"{person1.GetName()} ist {person1.GetAge()} Jahre alt.");
        Console.WriteLine($"{person2.GetName()} ist {person2.GetAge()} Jahre alt.");
    }
}

public class Person
{
    public Person()
    {
        this.name = string.Empty;
        this.birthDate = DateTime.Now;
    }

    public Person(DateTime birthday)
    {
        this.SetBirthDate(birthday);
        this.name = string.Empty;
    }
    public Person(DateTime birthday, string name)
    {
        this.SetBirthDate(birthday);
        this.name = name;
    }

    private string name;
    private DateTime birthDate;

    public void SetName(string name)
    {
        this.name = name;
    }

    private void SetBirthDate(DateTime birthDate)
    {
        this.birthDate = birthDate;
    }

    public string GetName()
    {
        return this.name;
    }

    public DateTime GetBirthDate()
    {
        return this.birthDate;
    }

    public int GetAge()
    {
        var age = DateTime.Now.Year - this.birthDate.Year;

        if (DateTime.Now.Date < birthDate.AddYears(age))
        {
            age--;
        }

        return age;
    }
}
