/* 23.	Schreibe eine Klasse, um einen (Mini)Zoo zu repräsentieren:
23.1.1.	Entwerfe eine Basisklasse “Tier” mit wichtigen Eigenschaften, die jedes Tier in einem Zoo hat.
23.1.2.	Leite die Klassen für Vögel, Löwe und Pferde mit speziellen Eigenschaften ab.-
23.1.3.	Jede spezielle Klasse bekommt die Methode sing(singen). 
// Console.WriteLine(Tiergeräusche);
23.1.4.	Liste von Tier erstellen. In der Klasse Tiere hinzufügen und in einer Schleife das Sprechen der Tiere ausgeben.
23.1.5.	Entwerfe eine Klasse “Zoo”, die alle Tiere in einem Zoo enthält

Initialisiere alle Tiere im Konstruktor der Klasse Zoo und gebe alle Tiere mit ihren Eigenschaften, die sich im Zoo befinden über die Kommandozeile aus. */

class Aufgabe23
{
    static void Main()
    {
        Zoo zoo = new Zoo();


        Console.WriteLine(zoo.animals[2].Age);    
    }
}

class Zoo
{
    public List<Animal> animals = new List<Animal>();
    public Zoo()
    {
        animals.Add(new Bird("Bird", 2, 3, "Pippo", "female", 4.2, 2));
        animals.Add(new Horse("Horse", 4, 12, "Nevio", "female", 500, "good"));
        animals.Add(new Lion("Lion", 4, 5, "Simba", "male", 190, "gold"));

        foreach (Animal animal in animals)
        {
            Console.WriteLine($"{animal} Species: {animal.Species}");
            Console.WriteLine($"{animal} Aumount of Legs: {animal.LegsCount}");
            Console.WriteLine($"{animal} Age: {animal.Age} years");
            Console.WriteLine($"{animal} Name: {animal.Name}");
            Console.WriteLine($"{animal} Gender: {animal.Gender}");
            Console.WriteLine($"{animal} weight: {animal.Weight}kg");

            animal.Sing();
        }
    }   
}

abstract class Animal
{
    public Animal(string species, int legsCount, int age, string name, string gender, double weight)
    {
        Species = species;
        LegsCount = legsCount;
        Age = age;
        Name = name;
        Gender = gender;
        Weight = weight;
    }

    public abstract void Sing();


    public string Species { get; set; }

    public int LegsCount { get; set; }

    public int Age { get; set; }

    public string Name { get; set; }

    public string Gender { get; set; }

    public double Weight { get; set; }
}

class Bird : Animal
{
    public Bird(string species, int legsCount, int age, string name, string gender, double weight, double wingSpan) : base(species, legsCount, age, name, gender, weight)
    {
        WingSpan = wingSpan;
    }

    public override void Sing()
    {
        Console.WriteLine("zwitscher");
    }

    public double WingSpan { get; set; }
}

class Horse : Animal
{
    public Horse(string species, int legsCount, int age, string name, string gender, double weight, string hoovesQuality) : base(species, legsCount, age, name, gender, weight)
    {
        HoovesQuality = hoovesQuality;
    }

    public override void Sing()
    {
        Console.WriteLine("wieher");
    }

    public string HoovesQuality { get; set; }
}

class Lion : Animal
{
    public Lion(string species, int legsCount, int age, string name, string gender, double weight, string maneColour) : base(species, legsCount, age, name, gender, weight)
    {
        ManeColour = maneColour;
    }

    public override void Sing()
    {
        Console.WriteLine("roar");
    }

    public string ManeColour { get; set; }
}