using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>
            {
                    { 1, "Rahul" },{ 2, "Anita" },{ 3, "Kiran" }
            };

            students.Add(4, "Meena");
            string name = students[2]; // "Anita"
            if (students.ContainsKey(2))
            {
                Console.WriteLine("Key exists");
            }
            foreach (KeyValuePair<int, string> entry in students)
            {
                Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
            }

            Console.ReadLine();
        }
    }
}
