namespace Personenverwaltung
{

    [Serializable]
    public class Adressmanagement
    {
        public Adressmanagement()
        {
            this.Personen = new List<Person>();
        }

        public List<Person> Personen { get; set; }

        public string Add(Person person)
        {
            if (Personen.Any(p => p.FullName == person.FullName && p.BirthDate == person.BirthDate && p.Height == person.Height && p.HairColor == person.HairColor && p.Adress.CountryOfResidence == person.Adress.CountryOfResidence && p.Adress.Domicile == person.Adress.Domicile && p.Adress.PostalCode == person.Adress.PostalCode && p.Adress.StreetName == person.Adress.StreetName && p.Adress.HouseNumber == person.Adress.HouseNumber))
            {
                return "This person already exists";
            }
            Personen.Add(person);
            return "Person added";
        }

        public string Delete(Person person)
        {
            Person foundPerson = FindPerson(person);

            if (foundPerson == null)
            {
                return "The entered Person does not exist";
            }

            Personen.Remove(foundPerson);
            return "The entered Person has been removed";
        }

        public string Edit(Person person, string inputProperty, string newValue)
        {
            Person foundPerson = FindPerson(person);

            while (true)
            {
                if (foundPerson == null)
                {
                    return "The entered Person does not exist";
                }

                if (inputProperty == "fn")
                {
                    foundPerson.FirstName = newValue;
                    return "The First Name of the Person has been changed.";
                }

                if (inputProperty == "ln")
                {
                    foundPerson.LastName = newValue;
                    return "The Last Name of the Person has been changed.";
                }
                if (inputProperty == "he")
                {
                    while (true)
                    {

                        if (double.TryParse(newValue, out double height))
                        {
                            foundPerson.Height = height;

                            return "The Height of the Person has been changed.";
                        }

                        return "Invalid input";
                    }
                }

                if (inputProperty == "hc")
                {
                    foundPerson.HairColor = newValue;
                    return "The Haircolor of the Person has been changed.";
                }

                 if (inputProperty == "cr")
                {
                    foundPerson.Adress.CountryOfResidence = newValue;
                    return "Country changed.";
                }

                 if (inputProperty == "do")
                {
                    foundPerson.Adress.Domicile = newValue;
                    return "Domicile changed.";
                }

                 if (inputProperty == "pc")
                {
                    if (int.TryParse(newValue, out int postalCode))
                    {
                        foundPerson.Adress.PostalCode = postalCode;
                        return "Postal code changed.";
                    }

                    return "Invalid postal code.";
                }

                 if (inputProperty == "sn")
                {
                    foundPerson.Adress.StreetName = newValue;
                    return "Street name changed.";
                }

                 if (inputProperty == "hn")
                {
                    if (int.TryParse(newValue, out int houseNumber))
                    {
                        foundPerson.Adress.HouseNumber = houseNumber;
                        return "House number changed.";
                    }

                    return "Invalid Input";
                }
            }
        }

        private Person FindPerson(Person person)
        {
            return Personen.FirstOrDefault(p => p.FullName == person.FullName && p.BirthDate == person.BirthDate && p.Height == person.Height && p.HairColor == person.HairColor && p.Adress.CountryOfResidence == person.Adress.CountryOfResidence && p.Adress.Domicile == person.Adress.Domicile && p.Adress.PostalCode == person.Adress.PostalCode && p.Adress.StreetName == person.Adress.StreetName && p.Adress.HouseNumber == person.Adress.HouseNumber);
        }
    }
}
