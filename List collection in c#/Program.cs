using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_collection_in_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("david");
            list.Add("John");
            list.Add("bob");
            list.Add("henry");
            list.Add("charles");

            Console.WriteLine("original list");

            Console.WriteLine("----------------------------------");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Insert(2, "jack");

            list.Remove("bob");

           bool result = list.Contains("henry");

            Console.WriteLine($"does henry exists in the list :{result}");

            list.Sort();

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Modified And Sorted List");

            Console.WriteLine("----------------------------------");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
