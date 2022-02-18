using System;
using Practica1.ConceptosGenerales;
using Practica1.POO;
using Practica1.Excepciones;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int userSelection = 0;

            while(userSelection != 4)
            {
                Console.WriteLine("Made by Jorge Soriano @ Atos - February the 18th, 2022." +
                "\n\n\t Choose an option:" +
                "\n\n\t\t 1. Country Greeting." +
                "\n\n\t\t 2. Abstract classes." +
                "\n\n\t\t 3. Custom Exception." +
                "\n\n\t\t 4. Exit.\n\n" +
                "---------------------------------------------\n\n\n");

                try
                {
                    userSelection = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("\n\n\tYou need to enter a valid integer number.");
                }

                switch (userSelection)
                {
                    case 1:

                        //Country greeting
                        //Output file name generation
                        string countryFileOutput = "..\\..\\ConceptosGenerales\\Countries ";
                        DateTime currentDateTime = DateTime.Now;
                        countryFileOutput += String.Format("{0}-{1}-{2}.txt", currentDateTime.Year, currentDateTime.ToString("MMMM"), currentDateTime.Day);

                        string countryFileInput = @"..\..\ConceptosGenerales\countries.txt";

                        Country.GreetCountries(countryFileInput, countryFileOutput);

                        Console.WriteLine("\n\tPRESS ANYTHING TO CONTINUE\n\n");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 2:

                        //Abstraction example
                        Cat c = new Cat(true, "Whiskers");

                        Console.WriteLine($"\n\t{c.Name}'s weight is: {c.GetWeight()}kg.");
                        c.Eat();
                        c.Sleep();
                        Console.WriteLine($"\n\t{c.Name}'s weight is: {c.GetWeight()}kg.");

                        Console.WriteLine("\n\tPRESS ANYTHING TO CONTINUE\n\n");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 3:

                        //TestException
                        TestException.Fail();
                        break;

                    case 4:
                        Console.WriteLine("\n\n\tExiting...\n\n");
                        break;

                    default:
                        Console.WriteLine("\n\t\tInvalid choice, choose from 1 to 4.");
                        break;

                }
            }
        }
    }
}
