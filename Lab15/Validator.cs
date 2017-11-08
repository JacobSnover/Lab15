using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Lab15
{
    public class Validator
    {

        public static string InputValidator()
        {

            string input = Console.ReadLine();
            
            while (true)
            {
                if (!input.All(Char.IsLetter))
                {
                    Console.Write("Only actual country names please: ");
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    return input;
                }
  
            }
        }
        public static string Confirm()
        {

            while (true)
            {

                Console.Write("\n\tWould you like to by this vehicle? Y or N ");
                string test = Console.ReadLine().ToLower();

                if (test == "y" || test == "yes")
                {
                    return "ok";
                }
                else if (test == "n" || test == "no")
                {
                    Continue();
                    return "NotOk";
                }

            }

        }

        public static string Continue()
        {

            while (true)
            {
                Console.Write("\n\tWould you like to purchase a vehicle? Y or N ");
                string test = Console.ReadLine().ToLower();

                if (test == "y" || test == "yes")
                {
                    return "\n\tExcellent! Let me show you what we have in stock.";
                }
                else if (test == "n" || test == "no")
                {

                    Console.WriteLine($"Bye! ");
                    Console.ReadLine();
                    Environment.Exit(1);
                }
            }
        }
    }
}