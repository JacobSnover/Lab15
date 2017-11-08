using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class CountriesApp
    {
        public CountriesApp()
        {
            while (true)
            {

                Console.WriteLine("Welcome to the countries app.\n1. See current list of countries.\n2. Add a country.\n3. Exit.");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    CountriesTextFile.readFromFile();
                    foreach (string countries in CountriesTextFile.country)
                    {
                        Console.WriteLine(countries);
                    }
                    
                }
                else if (input == "2")
                {
                    CountriesTextFile.writeToFile();
                }
                else if (input == "3")
                {
                    Console.WriteLine("Bye");
                    Console.ReadLine();
                    Environment.Exit(1);
                }
                else
                {
                    Console.Write("That is not a valid input\n\n ");
                    
                }
                
            }
        }

    }
}
