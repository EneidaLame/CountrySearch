using System;
using System.Collections.Generic;

namespace Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Country country1 = new Country() { Code = "AUS", Name = "Australia", Capital = "Canberra" };
            Country country2 = new Country() { Code = "USA", Name = "United States", Capital = "Washington D.C" };
            Country country3 = new Country() { Code = "GBR", Name = "United Kingtom", Capital = "London" };
            Country country4 = new Country() { Code = "CAN", Name = "Canada", Capital = "Ottawa" };
            Country country5 = new Country() { Code = "GRE", Name = "Greece", Capital = "Athens" };
            Country country6 = new Country() { Code = "ALB", Name = "Albania", Capital = "Tirana" };

            List<Country> listCountries = new List<Country>();
            listCountries.Add(country1);
            listCountries.Add(country2);
            listCountries.Add(country3);
            listCountries.Add(country4);
            listCountries.Add(country5);
            listCountries.Add(country6);

            string strUserChoice = string.Empty;

            do
            {
                Console.WriteLine("Please enter country code: ");
                string strCountryCode = Console.ReadLine().ToUpper();

                Country resultCountry = listCountries.Find(country => country.Code == strCountryCode);

                if (resultCountry == null)
                {
                    Console.WriteLine("Country code is not valid");
                }
                else
                {
                    Console.WriteLine("Name = {0}, Capital =  {1}", resultCountry.Name, resultCountry.Capital);
                }
                do
                {
                    Console.WriteLine("Do you want to continue - Yes or No?");
                    strUserChoice = Console.ReadLine().ToUpper();
                }
                while (strUserChoice != "NO" && strUserChoice != "YES");
            }
            while (strUserChoice == "YES");
        }
    }

    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }
}
