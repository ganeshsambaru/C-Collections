using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_collection_in_c_
{
    internal class ManageStudentMarks_ListOperations
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                List<int> Studentmarks = new List<int>
                {
                    80,75,82,98,95,88
                };

                Studentmarks.Add(98);

                Console.WriteLine("enter the marks to remove");
                int mark = Convert.ToInt32(Console.ReadLine());

                Studentmarks.Remove(mark);

                int highestMark = Studentmarks.Max();
                int lowestMark = Studentmarks.Min();

                Console.WriteLine($"Highest Mark: {highestMark}");
                Console.WriteLine($"Lowest Mark: {lowestMark}");
                Console.WriteLine("\nSorted (Descending) Marks:");
                var marks = Studentmarks.OrderByDescending(x => x).ToList();

                foreach(var x in marks)
                {
                    Console.WriteLine(x);
                }

                double avg = Studentmarks.Average();

                Console.WriteLine($"\nAverage Marks: {avg:F2}");

                //manual version to find Average

                int sum = 0;

                foreach (int mark1 in Studentmarks)
                {
                    sum += mark;  // Add each mark to the sum
                }

                double avg1 = (double)sum / Studentmarks.Count;  // Divide by number of elements

                Console.WriteLine($"Average Marks: {avg}");

                Console.ReadLine();
            }
        }
    }
}
