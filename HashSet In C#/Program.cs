using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> studentNames = new HashSet<string>();
            studentNames.Add("Ganesh");
            studentNames.Add("Suresh");
            studentNames.Add("Mahesh");
            studentNames.Add("Ganesh");
            studentNames.Add("Ramesh");

            foreach(var name in studentNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"Total number of Names:{studentNames.Count}");
            Console.WriteLine("Is Suresh in the list:");
            bool isname = studentNames.Contains("Suresh");
            Console.WriteLine("----------------------");
            Console.WriteLine($"Suresh is present:{isname}");

            studentNames.Remove("Mahesh");
            Console.WriteLine("After Removing Mahesh:");
            Console.WriteLine("----------------------");
            foreach(var name in studentNames)
            {
                Console.WriteLine(name);
                
            }
            Console.WriteLine($"Final set of students:{studentNames.Count}");
            Console.ReadLine();

               
        }
    }
}
