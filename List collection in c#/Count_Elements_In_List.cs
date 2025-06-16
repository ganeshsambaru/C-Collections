using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_collection_in_c_
{
    internal class Count_Elements_In_List
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>
            {
                "Apple", "Banana", "Mango", "Grapes"
            };

            Console.WriteLine("Number of fruits in the list: " + fruits.Count);

            fruits.Add("Orange");

            Console.WriteLine("After adding one fruit, count is: " + fruits.Count);

            fruits.Remove("Banana");

            Console.WriteLine("After removing one fruit, count is: " + fruits.Count);

            Console.ReadLine();
        }
    }
}

