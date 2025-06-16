using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_collection_in_c_
{
    internal class FindIndex_OfMatchingCity
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                List<string> cities = new List<string>
                {
                    "Mumbai", "Delhi", "Hyderabad", "Chennai", "Bangalore", "Pune"
                };

                Console.WriteLine("Enter the starting letter of the city to search:");
                string letter = Console.ReadLine();

                int index = cities.FindIndex(city => city.StartsWith(letter, StringComparison.OrdinalIgnoreCase));

                if (index != -1)
                {
                    Console.WriteLine($"The first city starting with '{letter}' is {cities[index]} at index {index}");
                }
                else
                {
                    Console.WriteLine("No city found with that starting letter.");
                }
                Console.ReadLine();
            }
        }
    }
}
