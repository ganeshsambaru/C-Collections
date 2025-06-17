using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dictionary_In_C_.Manage_Student_Profiles_With_Class;

namespace Dictionary_In_C_
{
    internal class Manage_Student_Profiles_With_Class
    {
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int Marks
            {
                get; set;

            }
            public class Program
            {
                public static void Main(string[] args)
                {
                    Dictionary<int, Student> students = new Dictionary<int, Student>
                    {
                         { 101, new Student { Name = "Arjun", Age = 20, Marks = 85 } },
                         { 102, new Student { Name = "Meena", Age = 21, Marks = 90 } },
                         { 103, new Student { Name = "Ravi", Age = 19, Marks = 78 } },
                         { 104, new Student { Name = "Divya", Age = 22, Marks = 88 } },
                         { 105, new Student { Name = "Suresh", Age = 20, Marks = 73 } }
                    };
                    foreach (var student in students)
                    {
                        Console.WriteLine($"StudentId:{student.Key},StudentName:{student.Value.Name},StudentAge:{student.Value.Age},StudentMarks:{student.Value.Marks}");
                    }

                    Console.WriteLine("Enter studentId to search");
                    int sid = int.Parse(Console.ReadLine());

                    if(students.ContainsKey(sid))
                    {
                        Console.WriteLine($"StudentName:{students[sid].Name},StudentAge:{students[sid].Age},StudentMarks:{students[sid].Marks}");
                    }
                    else
                    {
                        Console.WriteLine("Student Not Found");
                    }

                    Console.WriteLine("Enter studentId to Update Marks");
                    int StdId = int.Parse(Console.ReadLine());

                    if (students.ContainsKey(StdId))
                    {
                        Console.WriteLine("Enter Marks to Update");
                        int stdMarks = int.Parse(Console.ReadLine());

                        var marksupdated = students[StdId];
                        marksupdated.Marks = stdMarks;

                        Console.WriteLine("Marks Updated.");

                    }
                    else
                    {
                        Console.WriteLine("Student Not Found");
                    }

                    foreach(var student in students)
                    {
                        Console.WriteLine($"StudentName:{student.Value.Name},StudentAge:{student.Value.Age},StudentMarks:{student.Value.Marks}");
                    }
                    Console.WriteLine($"Total Students in the System: {students.Count}");
                    Console.ReadLine();
                }
            }
        }
    }
}
