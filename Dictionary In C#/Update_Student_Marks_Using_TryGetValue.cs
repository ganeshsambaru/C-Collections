using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_In_C_
{
    internal class Update_Student_Marks_Using_TryGetValue
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Dictionary<int, Tuple<string, int>> students = new Dictionary<int, Tuple<string, int>>
                {
                    { 501, Tuple.Create("Rahul", 78) },
                    { 502, Tuple.Create("Sneha", 85) },
                    { 503, Tuple.Create("Amit", 92) },
                    { 504, Tuple.Create("Pooja", 66) },
                    { 505, Tuple.Create("Karan", 74) }
                };

                foreach (var student in students)
                {
                    Console.WriteLine($"StudentId:{student.Key},StudentName:{student.Value.Item1},StudentMarks:{student.Value.Item2}");
                }
                Console.WriteLine("Enter StudentId to search");
                int stdId = int.Parse(Console.ReadLine());

                if (students.TryGetValue(stdId, out Tuple<string, int> studentInfo))
                {
                    Console.WriteLine($"Student Found - Name: {studentInfo.Item1}, Marks: {studentInfo.Item2}");

                    Console.WriteLine("Enter the Marks to Update");
                    int mark = int.Parse(Console.ReadLine());

                    var marks = students[stdId];
                    students[stdId] = Tuple.Create(marks.Item1, mark);

                    Console.WriteLine("Marks are Updated.");

                }
                else
                {
                    Console.WriteLine("Student Not Found.");
                }

                foreach (var student in students)
                {
                    Console.WriteLine($"StudentId:{student.Key},StudentName:{student.Value.Item1},StudentMarks:{student.Value.Item2}");
                }

                Console.ReadLine();
            }    
        }
    }
}
