using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_collection_in_c_
{
    internal class RemoveCity_AtGivenIndex
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                List<string> cities = new List<string>
                {
                    "Mumbai", "Delhi", "Hyderabad", "Chennai", "Bangalore", "Pune"
                };

                Console.WriteLine("Cities List:");
                for (int i = 0; i < cities.Count; i++)
                {
                    Console.WriteLine($"{i}: {cities[i]}");
                }

                Console.WriteLine("\nEnter the index of the city to remove:");
                int index = Convert.ToInt32(Console.ReadLine());

                if (index >= 0 && index < cities.Count)
                {
                    cities.RemoveAt(index);
                    Console.WriteLine("Updated City List:");
                    foreach (string city in cities)
                    {
                        Console.WriteLine(city);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid index. No city removed.");
                }

                Console.ReadLine();
            }
        }
    }
}
