using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a Dictionary variable and add key value pairs to its
            Dictionary<string, int> cohortCount =
                new Dictionary<string, int>();

            //Add to Dictionary
            cohortCount.Add("Cohort 34", 20);
            cohortCount.Add("Cohort 35", 14);
            cohortCount.Add("Cohort 36", 28);
            cohortCount.Add("Cohort 37", 29);

            //Iterating over key value pairs
            foreach (KeyValuePair<string, int> item in cohortCount)
            {
                Console.WriteLine($"{item.Key} has {item.Value} students.");
            }

            //Another way to declare a dictionary
            Dictionary<string, double> productListing =
                new Dictionary<string, double>()
                { { "Deodorant", 8.50 }, { "Hairbrush", 8 }, { "Heidi Hair Brush", 5.4 }, { "Shampoo", 4 }, { "Tooth Brush", 14 },
                };

            //Iterating over key value pairs
            foreach (KeyValuePair<string, double> products in productListing)
            {
                Console.WriteLine($"{products.Key} costs ${products.Value}");
            }
        }
    }
}