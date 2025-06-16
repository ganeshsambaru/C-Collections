using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_collection_in_c_
{
    internal class Search_and_Update_a_Student_Name_in_the_List
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                List<string> students = new List<string>
                {
                    "Anitha","Eswar","Harini","Saketh","Neha"
                };

                Console.WriteLine("enter the name to search");

                string searchname = Console.ReadLine();

                if (students.Contains(searchname))
                {
                    Console.WriteLine("enter new name to update");

                    string newname = Console.ReadLine();

                    int index = students.IndexOf(searchname);
                    students[index] = newname;

                    Console.WriteLine("\nUpdated Students List");

                    foreach (string student in students)
                    {
                        Console.WriteLine(student);
                    }
                }

                else
                {
                    Console.WriteLine("Name is not found");
                }
                Console.ReadLine();
            }
            
        }
    }
}
