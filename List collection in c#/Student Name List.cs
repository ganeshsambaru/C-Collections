using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_collection_in_c_
{
    internal class Student_Name_List
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                List<string> list = new List<string>();

                list.Add("Anitha");
                list.Add("Rahul");
                list.Add("Karan");
                list.Add("Sneha");
                list.Add("Meena");

                Console.WriteLine("Original list");
                Console.WriteLine("----------------------");

                foreach(string student in list)
                {
                    Console.WriteLine(student);
                }

                list.Insert(3, "Jack");
                Console.WriteLine("After Insert");
                Console.WriteLine("----------------------");

                foreach (string student in list)
                {
                    Console.WriteLine(student);
                }

                list.Remove("Meena");

                bool result =list.Contains("Rahul");

                Console.WriteLine($"Does the list contains Rahul:{result}");

                list.Sort();

                Console.WriteLine("After Remove And Sort");
                Console.WriteLine("----------------------");

                foreach(string student in list)
                {
                    Console.WriteLine(student);
                }
                Console.WriteLine($"Total number of students: {list.Count}");
                Console.ReadLine();


            }
        }
    }
}
