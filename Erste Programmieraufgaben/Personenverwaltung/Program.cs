using Personenverwaltung;

class PersonenverwaltungMain
{
    static void Main()
    {
        Adressmanagement adresses = new Adressmanagement();

        // Die Methode Add soll die Person nur hinzufügen, wenn sie nicht schon in der Liste drinnen ist.

        //Konstruktor anpassen
        //Save und Load in den Persistor
        //Json Format anschauen und Save as Json und Load from Json implementieren
        //Vorteil von Json?
        //Binary Format anschauen und Save as Binary und Load from Binary implementieren
        //Wenn Markus nicht da ist: Udemy Intermediate beginnen
        //Optionale Adresse hinzufügen

        adresses.Add(new Person("Max", "Mustermann", new DateTime(2008, 09, 21), 234, "red", new Adress("Germany", "Munich", 80331, "Maximilianstrasse", 19)));

        Persistor persistor = new Persistor();

        string textFile = @"C:\FilesForTesting\myAdresses.txt";

        string xmlFile = @"C:\FilesForTesting\myAdresses.xml";

        string jsonFile = @"C:\FilesForTesting\myAdresses.json";

        string binaryFile = @"C:\FilesForTesting\myAdresses.bin";

        while (true)
        {
            Console.WriteLine("a) Add Person");
            Console.WriteLine("d) Delete person");
            Console.WriteLine("e) Edit person");
            Console.WriteLine("p) Print all people");
            Console.WriteLine("st) Save as Textfile");
            Console.WriteLine("lt) Load from Textfile");
            Console.WriteLine("sx) Save as XML-File");
            Console.WriteLine("lx) Load from XML-File");
            Console.WriteLine("sj) Save as JSON-File");
            Console.WriteLine("lj) Load from JSON-File");
            Console.WriteLine("sb) Save as Binary File");
            Console.WriteLine("lb) Load from Binary File");
            Console.WriteLine("q) Quit");
            Console.Write("Which one do you choose: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            if (input.ToLower() == "a")
            {
                Console.WriteLine("Adding a Person");
                Console.WriteLine();
                Console.WriteLine(adresses.Add(EnterPerson()));
                Console.WriteLine();
            }

            else if (input.ToLower() == "p")
            {
                Console.WriteLine("Printing all people:");
                Console.WriteLine();

                foreach (Person person in adresses.Personen)
                {
                    Console.WriteLine("Name: " + person.FullName);
                    Console.WriteLine("Age: " + person.Age + " years");
                    Console.WriteLine("Height: " + person.Height + "cm");
                    Console.WriteLine("Hair Color: " + person.HairColor);
                    Console.WriteLine($"Address:  {person.Adress.StreetName} {person.Adress.HouseNumber}, {person.Adress.PostalCode} {person.Adress.Domicile}, {person.Adress.CountryOfResidence}"); 
                    Console.WriteLine();
                }
            }

            else if (input.ToLower() == "d")
            {
                Console.WriteLine("Deleting a Person");
                Console.WriteLine();
                Console.WriteLine(adresses.Delete(EnterPerson()));
                Console.WriteLine();
            }

            else if (input.ToLower() == "e")
            {
                Console.WriteLine("Editing a Person");
                Console.WriteLine();

                Person personToEdit = EnterPerson();

                Console.WriteLine("fn) First Name");
                Console.WriteLine("ln) Last Name");
                Console.WriteLine("he) Height");
                Console.WriteLine("hc) Haircolor");
                Console.WriteLine("cr) Country of residence");
                Console.WriteLine("do) Domicile");
                Console.WriteLine("pc) Postal Code");
                Console.WriteLine("sn) Street Name");
                Console.WriteLine("hn) House Number");
                Console.WriteLine();

                Console.Write("Enter the property you want to change: ");
                string inputProperty = (Console.ReadLine().ToLower());

                Console.WriteLine();
                Console.Write("New Value: ");
                string value = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine(adresses.Edit(personToEdit, inputProperty, value));
                Console.WriteLine();
            }

            else if (input.ToLower() == "st")
            {
                Console.WriteLine(persistor.SaveAsTxt(textFile, adresses));
                Console.WriteLine();
            }

            else if (input.ToLower() == "lt")
            {
                adresses = persistor.LoadFromTxt(textFile);
                Console.WriteLine("Loaded from Textfile");
                Console.WriteLine();
            }

            else if (input.ToLower() == "sx")
            {
                Console.WriteLine(persistor.SaveAsXml(xmlFile, adresses));
                Console.WriteLine();
            }

            else if (input.ToLower() == "lx")
            {
                adresses = persistor.LoadFromXml(xmlFile);
                Console.WriteLine("Loaded from XML-File");
                Console.WriteLine();
            }
            
            else if (input.ToLower() == "sj")
            {
                Console.WriteLine(persistor.SaveAsJson(jsonFile, adresses));
                Console.WriteLine();
            }

            else if (input.ToLower() == "lj")
            {
                adresses = persistor.LoadFromJson(jsonFile);
                Console.WriteLine("Loaded from JSON-File");
                Console.WriteLine();
            }
           
            else if (input.ToLower() == "sb")
            {
                Console.WriteLine(persistor.SaveAsBinary(binaryFile, adresses));
                Console.WriteLine();
            }

            else if (input.ToLower() == "lb")
            {
                adresses = persistor.LoadFromBinary(binaryFile);
                Console.WriteLine("Loaded from binary File");
                Console.WriteLine();
            }

            else if (input.ToLower() == "q")
            {
                break;
            }

            else
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine();
            }
        }

        var name = "Mark";
        var age = 16;

        var name2 = "Markus";
        var age2 = 52;

        DateTime birthday1 = new DateTime(2010, 08, 16);
        DateTime birthday2 = new DateTime(1973, 10, 25);

        Console.WriteLine($"{name} ist {age} Jahre alt.");
        Console.WriteLine($"{name2} ist {age2} Jahre alt.");

        Person person1 = new Person(birthday1);
        Person person2 = new Person(birthday2, "Markus", "Strittmatter");
        Person person3 = new Person();

        person1.FirstName = "Mark";

        Console.WriteLine($"{person1.FirstName} ist {person1.Age} Jahre alt.");
        Console.WriteLine($"{person2.FirstName} ist {person2.Age} Jahre alt.");
    }

    static Person EnterPerson()
    {
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();

        DateTime birthday3 = new DateTime();

        while (true)
        {
            Console.Write("Birth Date (dd.mm.yyyyy): ");

            if (DateTime.TryParse(Console.ReadLine(), out birthday3))
            {
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Input is not in correct Format. Please try again");
            Console.WriteLine();
        }

        double height;

        while (true)
        {
            Console.Write("Height (in cm): ");

            if (double.TryParse(Console.ReadLine(), out height))
            {
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Input is not in correct Format. Please try again");
            Console.WriteLine();
        }

        Console.Write("Hair Color: ");
        string hairColor = Console.ReadLine();
        Console.WriteLine();

        Adress adress = EnterAdress();

        return new Person(firstName, lastName, birthday3, height, hairColor, adress);
    }

    static Adress EnterAdress()
    {
        Console.Write("Country of residence: ");
        string countryOfResidence = Console.ReadLine();

        Console.Write("Domicile: ");
        string domicile = Console.ReadLine();

        int postalCode;

        while (true)
        {
            Console.Write("Postal Code: ");

            if (int.TryParse(Console.ReadLine(), out postalCode))
            {
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Input is not in correct Format. Please try again");
            Console.WriteLine();
        }

        Console.Write("Street Name: ");
        string streetName = Console.ReadLine();

        int houseNumber;

        while (true)
        {
            Console.Write("House Number: ");

            if (int.TryParse(Console.ReadLine(), out houseNumber))
            {
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Input is not in correct Format. Please try again");
            Console.WriteLine();
        }

        return new Adress(countryOfResidence, domicile, postalCode, streetName, houseNumber);
    }
 
}
