using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L149___Classes_and_Objects
{
    class Country
    {
        // Properties
        public string name;
        public int population;

        // Methods
        public void GiveDisease(int diseaseStrength)
        {
            Console.WriteLine($"{name} got disease of strength {diseaseStrength}!!");
            population = population / diseaseStrength;
        }
        public string GetDetails()
        {
            return $"{name}, pop: {population}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Country myCountry;

            myCountry = new Country();

            myCountry.name = "Mattland";
            myCountry.population = 10;


            myCountry.GiveDisease(5);



            Country yourCountry = new Country();
            yourCountry.name = "Adriiland";
            yourCountry.population = 21;

            List<Country> theCountries = new List<Country>();
            theCountries.Add(myCountry);
            theCountries.Add(yourCountry);
            foreach (Country country in theCountries)
            {
                Console.WriteLine(country.GetDetails());
            }

        }
    }
}
