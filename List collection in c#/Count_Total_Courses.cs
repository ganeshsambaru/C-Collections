using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_collection_in_c_
{
    internal class Count_Total_Courses
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                List<string> courses = new List<string>
                {
                    "C#","Asp.net mvc",".Netcore web api","sql server","angular","react"
                };

                Console.WriteLine("Available Courses:");
                Console.WriteLine("-------------------");

                foreach (string course in courses)
                {
                    Console.WriteLine(course);
                }

                Console.WriteLine($"\nTotal number of courses: {courses.Count}");

                Console.WriteLine("\nDo you want to add a new course? (yes/no)");
                string response = Console.ReadLine().ToLower();

                if (response == "yes")
                {
                    Console.WriteLine("Enter the course name:");
                    string newCourse = Console.ReadLine();

                    if (courses.Contains(newCourse))
                    {
                        Console.WriteLine("Course already exists in the list.");
                    }
                    else
                    {
                        courses.Add(newCourse);
                        Console.WriteLine("Course added successfully!");

                        Console.WriteLine("\nUpdated Course List:");
                        foreach (string course in courses)
                        {
                            Console.WriteLine(course);
                        }

                        Console.WriteLine($"\nUpdated total number of courses: {courses.Count}");
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
