using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_collection_in_c_
{
    internal class FindLastIndex_RemoveAll_AppleTask
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                List<string> fruits = new List<string>
                {
                    "Mango", "Apple", "Banana", "Apple", "Guava", "Apple"
                };
                int lastindex = fruits.FindLastIndex(fruit => fruit =="Apple");

                Console.WriteLine($"Last index of 'Apple': {lastindex}");

                fruits.RemoveAll(fruit => fruit == "Apple");

                foreach(string fruit in fruits)
                {
                    Console.WriteLine(fruit);
                }

                Console.ReadLine();
            }
        }
    }
}
