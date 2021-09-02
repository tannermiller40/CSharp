using System;

namespace CovidHelper
{
    class Program
    {
        static void Main(string[] args)
        {

            // create a greet to the user at the beginning of the program.

            Helper name1 = new Helper();

            decimal temp = name1.Temperature;

            Console.WriteLine(temp);


            Console.WriteLine("What is your name?");
            name1.Name = Console.ReadLine();
            Console.WriteLine("Hello, " + name1.Name);

            // Asking user for last reported temperature

            Console.WriteLine("What is your last recorded body temperature?");
            name1.Temperature = decimal.Parse(Console.ReadLine());
            
            if (name1.Temperature > 110m)
            {
                Console.WriteLine("Please enter a valid temperature");
            } 

            // Creating a function to check for Celsius or Fahrenheit

            Console.WriteLine("C or F?");
            name1.choice = Console.ReadLine();
            if (name1.Temperature > 98.6m)
            {
                Console.WriteLine($"Your temperature is: " + name1.Temperature + " " + name1.choice + ", you are experiencing a fever.");
            }
            else
            {
                Console.WriteLine($"Your temperature is: " + name1.Temperature + " " + name1.choice + ".");

            }

            // calling function converting C to F
            // calling function as string so that I can return the opposite value with either C or F following the returned temp.

            string test = name1.CToF((name1.Temperature), name1.choice);
            Console.WriteLine(test);


            /* have you been in contact with covid Y OR N
               are you expeierncing any coughing Y OR N
               are you experiencing any bodyaches Y OR N
            */


            /* Implementing a counter to determine if the user should contact the health department or are most likely fine.
             * Also placing ("Y" or "N") in the question because the user needs to enter either value Y or N.
            */

            int counter = 0;
            Console.WriteLine("Have you been in contact with anyone who has experienced symptoms or tested positive for Covid-19? (Y or N)");
            string S = Console.ReadLine();
            if (S == "Y" || S == "y")
            {
                counter++;
            }
            Console.WriteLine("Are you Exhibiting any symptoms of Covid-19? (Y or N)");
            string V = Console.ReadLine();
            if (V == "Y" || V == "y")
            {
                counter++;
            }
            Console.WriteLine("Are you experiencing any body aches or cough? (Y or N)");
            string M = Console.ReadLine();
            if (M == "Y" || M == "y")
            {
                counter++;
            }

            if (counter >= 1)
            {
                Console.WriteLine("You are exhibiting some signs of indication that you may have Covid-19, you should contact the health department.");
            }
            else
            {
                Console.WriteLine("No signs of Covid-19, however if you begin to feel any of these symptoms stay home and contact the health department.");

            }

        }

    }
}
