using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_collection_in_c_
{
    internal class FindFirstAndLast_EvenNumberIndex
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                List<int> numbers = new List<int> { 5, 7, 12, 19, 24, 31, 42, 9,31, 13 };

                foreach(int number in numbers)
                {
                    Console.WriteLine(number);
                }

                Console.WriteLine("enter number");

                int num = int.Parse(Console.ReadLine());
                int firstindex = numbers.FindIndex(number => number == num);

                Console.WriteLine($"Index of {num} is {firstindex}");

                int lastindex = numbers.FindLastIndex(number => number == num);

                Console.WriteLine($"Last Index of {num} is {lastindex}");

                Console.ReadLine();
            }
        }
    }
}
