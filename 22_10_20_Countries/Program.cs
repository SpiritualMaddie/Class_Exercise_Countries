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

            CountryCodesMethod();

            void CountryCodesMethod()
            {
                bool run = true;
                while (run)
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
                    TryAgain();
                }
            }
            void TryAgain()
            {
                bool runCheck = true;
                while (runCheck)
                {
                    Console.WriteLine("Do you want to check another country code? Y/N");
                    string cont = Console.ReadLine().ToUpper();
                    if (string.IsNullOrWhiteSpace(cont) == false)
                    {
                        switch (cont)
                        {
                            case "Y":
                                CountryCodesMethod();
                                Console.Clear();
                                break;
                            case "N":
                                Environment.Exit(0);
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid choice. Try again.");
                                TryAgain();
                                break;
                        }
                    }
                    else if (string.IsNullOrWhiteSpace(cont) == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid choice. Try again.");
                    }
                }
            }
        }
    }
}
