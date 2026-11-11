public class Person
{
    private DateTime _birthdate;

    public void SeBirthdate(DateTime birthdate)
    {
        _birthdate = birthdate;
    }

    public DateTime GetBirthdate()
    {
        return _birthdate;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var person = new Person();

        person.SeBirthdate(new DateTime(1982,1,1));

        Console.WriteLine(person.GetBirthdate());

    }
}