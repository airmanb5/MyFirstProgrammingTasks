using System.Text.Json;
using System.Xml.Serialization;

namespace Personenverwaltung
{
    public class Persistor
    {
        public string SaveAsXml(string fileName, Adressmanagement adressen)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Adressmanagement));

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, adressen);
            }
            return "Saved as XML-File";
        }

        public Adressmanagement LoadFromXml(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Adressmanagement));

            using (StreamReader reader = new StreamReader(fileName))
            {
                Adressmanagement loadedAdressmanagement = (Adressmanagement)serializer.Deserialize(reader);

                return loadedAdressmanagement;
            }
        }

        public string SaveAsTxt(string fileName, Adressmanagement adressen)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Person person in adressen.Personen)
                {
                    writer.WriteLine($"{person.FirstName},{person.LastName},{person.BirthDate},{person.Height},{person.HairColor}, {person.Adress.CountryOfResidence}, {person.Adress.Domicile}, {person.Adress.PostalCode}, {person.Adress.StreetName}, {person.Adress.HouseNumber}");
                }
            }

            return "Saved as Textfile";
        }

        public Adressmanagement LoadFromTxt(string fileName)
        {
            List<string> words = new List<string>();

            string line;

            Adressmanagement adresses = new Adressmanagement();

            using (StreamReader reader = new StreamReader(fileName))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');

                    string firstName = values[0];
                    string lastName = values[1];
                    DateTime birthDate = DateTime.Parse(values[2]);
                    double height = double.Parse(values[3]);
                    string hairColor = values[4];
                    Adress adress = new Adress(values[5], values[6], int.Parse(values[7]), values[8], int.Parse(values[9]));

                    Person loadedPerson = new Person(firstName, lastName, birthDate, height, hairColor, adress);

                    adresses.Add(loadedPerson);
                }
            }
            return adresses;
        }

        public string SaveAsJson(string fileName, Adressmanagement adressen)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(adressen, options);

            File.WriteAllText(fileName, json);

            return "Saved as JSON-File";
        }

        public Adressmanagement LoadFromJson(string fileName)
        {
            string json = File.ReadAllText(fileName);

            Adressmanagement adressen = JsonSerializer.Deserialize<Adressmanagement>(json);

            return adressen;
        }

        public string SaveAsBinary(string fileName, Adressmanagement adressen)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(adressen.Personen.Count);

                foreach (Person person in adressen.Personen)
                {
                    writer.Write(person.FirstName);
                    writer.Write(person.LastName);
                    writer.Write(person.BirthDate.ToBinary());
                    writer.Write(person.Height);
                    writer.Write(person.HairColor);
                    writer.Write(person.Adress.CountryOfResidence);
                    writer.Write(person.Adress.Domicile);
                    writer.Write(person.Adress.PostalCode);
                    writer.Write(person.Adress.StreetName);
                    writer.Write(person.Adress.HouseNumber);
                }
            }

            return "Saved as Binary";
        }

        public Adressmanagement LoadFromBinary(string fileName)
        {
            Adressmanagement adressen = new Adressmanagement();

            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                int count = reader.ReadInt32();

                for (int i = 0; i < count; i++)
                {
                    string firstName = reader.ReadString();
                    string lastName = reader.ReadString();
                    DateTime birthDate = DateTime.FromBinary(reader.ReadInt64());
                    double height = reader.ReadDouble();
                    string hairColor = reader.ReadString();
                    string countryOfResidence = reader.ReadString();
                    string domicile = reader.ReadString();
                    int postalCode = reader.ReadInt32();
                    string streetName = reader.ReadString();
                    int houseNumber = reader.ReadInt32();

                    Adress adress = new Adress(countryOfResidence, domicile, postalCode, streetName, houseNumber);

                    Person person = new Person(firstName, lastName, birthDate, height, hairColor, adress);

                    adressen.Add(person);
                }

                return adressen;
            }
        }
    }
}
