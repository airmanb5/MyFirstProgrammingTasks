namespace Personenverwaltung
{
    [Serializable]
    public class Person
    {
        public Person(string firstName, string lastName, DateTime birthday, double height, string hairColor, Adress adress)
        {
            this.FirstName = firstName;

            this.LastName = lastName;

            this.BirthDate = birthday;

            this.Height = height;

            this.HairColor = hairColor;

            this.PhoneNumber = string.Empty;

            this.Adress = adress;


        }


        public Person()
        {
            this.FirstName = string.Empty;

            this.LastName = string.Empty;

            this.BirthDate = DateTime.MinValue;

            this.Height = 0;

            this.HairColor = string.Empty;

            this.PhoneNumber = string.Empty;

            Adress = new Adress();
        }

        public Person(DateTime birthday)
        {
            this.FirstName = string.Empty;

            this.LastName = string.Empty;

            this.BirthDate = birthday;

            this.Height = 0;

            this.HairColor = string.Empty;

            this.PhoneNumber = string.Empty;
        }
        public Person(DateTime birthday, string firstName, string lastName)
        {
            this.FirstName = firstName;

            this.LastName = lastName;

            this.BirthDate = birthday;

            this.Height = 0;

            this.HairColor = string.Empty;

            this.PhoneNumber = string.Empty;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get { return GetFullName(); } }

        public DateTime BirthDate { get; set; }

        public int Age { get { return GetAge(); } }

        public double Height { get; set; }

        public string HairColor { get; set; }

        public string PhoneNumber { get; set; }

        public Adress Adress { get; set; }

        private int GetAge()
        {
            var age = DateTime.Now.Year - this.BirthDate.Year;

            if (DateTime.Now.Date < BirthDate.AddYears(age))
            {
                age--;
            }

            return age;
        }

        private string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
