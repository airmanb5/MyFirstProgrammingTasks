
namespace Personenverwaltung
{
    public class Adress
    {
        public string CountryOfResidence { get; set; }

        public string Domicile { get; set; }

        public int PostalCode { get; set; }

        public string StreetName { get; set; }

        public int HouseNumber { get; set; }

        public Adress()
        {
            CountryOfResidence = string.Empty;
            Domicile = string.Empty;
            PostalCode = 0;
            StreetName = string.Empty;
            HouseNumber = 0;
        }

        public Adress(string countryOfResidence, string domicile, int postalcode, string streetName, int houseNumber)
        {
            CountryOfResidence = countryOfResidence;
            Domicile = domicile;
            PostalCode = postalcode;
            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        //public override string ToString()
        //{
        //    return $"{StreetName} {HouseNumber}, {PostalCode} {Domicile}, {CountryOfResidence}";
        //}
    }
}