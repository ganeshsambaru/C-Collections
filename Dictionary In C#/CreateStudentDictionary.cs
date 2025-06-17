using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_In_C_
{
    internal class CreateStudentDictionary
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>
            {
                {101,"Arjun"},{102,"Meena"},{103,"Ravi"},{104,"Divya"},{105,"Suresh"}
            };

            Console.WriteLine("Original Dictionary");
            Console.WriteLine("-------------------------");
            foreach(KeyValuePair<int,string> student in students)
            {
                Console.WriteLine($"Student Id:{student.Key},Name:{student.Value}");
            }

            students.Add(106, "Sneha");
            Console.WriteLine("After Updation Of Dictionary");
            Console.WriteLine("-------------------------");

            foreach(KeyValuePair<int ,string> student in students)
            {
                Console.WriteLine($"Student Id:{student.Key},Name:{student.Value}");
            }

            Console.WriteLine("Enter student Id to search");

            int stdId = int.Parse(Console.ReadLine());

            if(students.ContainsKey(stdId))
            {
                Console.WriteLine($"Student Exists:{students[stdId]}");
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
            Console.ReadLine();
        }
    }
}
