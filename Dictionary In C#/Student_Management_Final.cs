using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_In_C_
{
    internal class Student_Management_Final
    {
        public class Program
        {
            public class Student
            {
                public string Name { get; set; }
                public int Age { get; set; }
                public int Marks { get; set; }

                public override string ToString()
                {
                    return $"Name: {Name}, Age: {Age}, Marks: {Marks}";
                }
            }

            public static void Main(string[] args)
            {
                Dictionary<int, Student> students = new Dictionary<int, Student>
                {
                     {101, new Student { Name = "Arjun", Age = 20, Marks = 85 }},
                     {102, new Student { Name = "Meena", Age = 21, Marks = 90 }},
                     {103, new Student { Name = "Ravi", Age = 19, Marks = 78 }},
                     {104, new Student { Name = "Divya", Age = 22, Marks = 88 }},
                     {105, new Student { Name = "Suresh", Age = 20, Marks = 73 }}
                };
                foreach(var Student in students)
                {
                    Console.WriteLine($"StudentId:{Student.Key},StudentName:{Student.Value.Name},StudentAge:{Student.Value.Age},StudentMarks:{Student.Value.Marks}");
                }
                Console.WriteLine("Enter studentId");
                int id = int.Parse(Console.ReadLine());

                if (students.ContainsKey(id))
                {
                    Console.WriteLine("Student with this ID already exists.");
                }
                else
                {
                    Console.WriteLine("Enter StudentName");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Enter StudentAge");
                    int Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter StudentMarks");
                    int Marks = int.Parse(Console.ReadLine());

                    students[id] = new Student { Name = Name, Age = Age, Marks = Marks };

                    Console.WriteLine(students[id]);
                }
                Console.WriteLine("Enter StudentId to search");
                int searchId = int.Parse(Console.ReadLine());

                if(students.TryGetValue(searchId,out Student studentinfo))
                {
                    Console.WriteLine($"StudentName:{studentinfo.Name},StudentAge:{studentinfo.Age},StudentMarks:{studentinfo.Marks}");
                }
                else
                {
                    Console.WriteLine("Student Not Found");
                }

                Console.WriteLine("Enter StudentId to Update Marks");
                int sid = int.Parse(Console.ReadLine());
                if (students.TryGetValue(sid, out Student student))
                {
                    Console.WriteLine("Enter Marks To Update");
                    int marks = int.Parse(Console.ReadLine());
                    var studentMark = students[sid];
                    studentMark.Marks = marks;
                    Console.WriteLine("Marks Updated");
                }
                else
                {
                    Console.WriteLine("Student Not Found");
                }

                Console.WriteLine("Enter StudentId to Delete");
                int DeleteId = int.Parse(Console.ReadLine());
                if(students.ContainsKey(DeleteId))
                {
                    students.Remove(DeleteId);
                    Console.WriteLine("Student Deleted");
                }
                else
                {
                    Console.WriteLine("Student Not Found");
                }
                foreach (var Student in students)
                {
                    Console.WriteLine($"StudentId:{Student.Key},StudentName:{Student.Value.Name},StudentAge:{Student.Value.Age},StudentMarks:{Student.Value.Marks}");
                }

                Console.WriteLine($"Total Students in the System: {students.Count}");
                Console.ReadLine();
            }
        }
    }
}
