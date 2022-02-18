using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.ConceptosGenerales
{
    public static class Country
    {
        public static void GreetCountries(string inputFile, string outputFile)
        {
            try
            {
                List<String> countryList = new List<String>();
                using (StreamReader reader = new StreamReader(inputFile))
                {
                    string text;
                    while ((text = reader.ReadLine()) != null)
                    {
                        countryList.Add(String.Format("Greetings to {0}!", text));
                    }
                }

                string[] formattedCountries = countryList.ToArray();

                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    foreach (String country in formattedCountries)
                    {
                        writer.WriteLine(country);
                    }
                }

                Console.WriteLine($"\n\tCountries successfuly greeted! File was created at: {outputFile}");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Source file is missing, exception message: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong, exception message: " + e.Message);
            }
        }
    }
}
