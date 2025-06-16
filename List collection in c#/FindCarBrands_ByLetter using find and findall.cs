using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_collection_in_c_
{
    internal class FindCarBrands_ByLetter_using_find_and_findall
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                List<string> car = new List<string>
                {
                    "Honda","Toyota","Hyundai","Ford","Chevrolet",
                    "Tata","Volkswagen","Nissan","Suzuki","Kia"
                };

                string result = car.Find(firstbrand => firstbrand.StartsWith("H"));
                Console.WriteLine($"First brand starting with 'H': {result}");

                List<string> filteredcars = car.FindAll(firstbrand => firstbrand.StartsWith("N"));

                Console.WriteLine("\nAll car brands starting with 'N':");

                foreach (string cars  in filteredcars)
                {
                    Console.WriteLine(cars);
                }

                Console.ReadLine();
            }
        }
    }
}
