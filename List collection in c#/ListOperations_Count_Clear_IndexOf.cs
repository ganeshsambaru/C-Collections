using System;
using System.Collections.Generic;

namespace List_collection_in_c_
{
    internal class ListOperations_Count_Clear_IndexOf
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                List<string> cities = new List<string>();

                cities.Add("Mumbai");
                cities.Add("Delhi");
                cities.Add("Hyderabad");
                cities.Add("Chennai");
                cities.Add("Bangalore");

                Console.WriteLine("Cities List:");
                foreach (var city in cities)
                {
                    Console.WriteLine(city);
                }

                Console.WriteLine("--------------------------");
                Console.WriteLine($"Total number of cities: {cities.Count}");

                int index = cities.IndexOf("Hyderabad");
                Console.WriteLine($"Index of 'Hyderabad': {index}");

                Console.WriteLine("--------------------------");
                Console.WriteLine("Clearing the list...");
                cities.Clear();

                Console.WriteLine($"List count after Clear(): {cities.Count}");

                Console.ReadLine();
            }
        }
    }
}
