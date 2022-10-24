using System;
using System.Collections.Generic;
using System.Linq;

namespace _22_10_20_Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            Country C1 = new Country("Sweden", "swe", "Stockholm");
            Country C2 = new Country("Canada", "can", "Ottawa");
            Country C3 = new Country("Norge", "Nor", "Oslo");
            Country C4 = new Country("Syrien", "Syr", "Damascus");
            Country C5 = new Country("Algeriet", "DZA", "Alger");
            
            List<Country> countries = new List<Country>()
            {
                C1, C2, C3, C4, C5
            };

            string cont = "Y";
            while (cont != "N")
            {
                Console.WriteLine("Write a country code: ");
                string input = Console.ReadLine().ToUpper();
                foreach (var country in countries)
                {
                    Console.Clear();
                    if (input == country.Code)
                    {
                        Console.WriteLine(country.Name + " " + country.Capital);
                        break;
                    }
                    Console.WriteLine("Country code not valid!");
                }
                Console.WriteLine("Do you wanna try again? Y/N");
                cont = Console.ReadLine().ToUpper();
            }
        }
    }
}
