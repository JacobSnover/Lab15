using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    public class CountriesTextFile
    {
        public static StreamReader sr = new StreamReader(@"C:\Users\ShaKy\Documents\Visual Studio 2017\Projects\Lab15\Lab15\countries.txt");
        public static ArrayList country = new ArrayList();
        public static string newCountry;
        public static ArrayList readFromFile()
        {

            while (true)
            {
                string line = sr.ReadLine();
                if (line == null || line == "")
                {
                    break;
                }
                else
                {
                    country.Add(line);
                }
            }
            
            return country;
        }
        public static ArrayList writeToFile()
        {
            Console.Write("Add country: ");
            newCountry = Validator.InputValidator();
            country.Add(newCountry);
            
            return country;

        }
        




    }
}
