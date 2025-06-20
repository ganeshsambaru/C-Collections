using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_In_C_
{
    internal class HashSet_StudentComparison
    {
        public class Public
        {
            public static void Main(string[] args)
            {
                HashSet<string> csharpStudents = new HashSet<string>
                {
                    "Ganesh", "Suresh", "Mahesh", "Rakesh", "Praveen"
                };

                HashSet<string> sqlStudents = new HashSet<string>
                {
                    "Mahesh", "Rakesh", "Naresh", "Lokesh", "Ganesh"
                };

                Console.WriteLine("All Unique Students:");
                Console.WriteLine("--------------------");

                HashSet<string> uniqueSet = new HashSet<string>(csharpStudents);
                uniqueSet.UnionWith(sqlStudents);

                foreach(var student in uniqueSet)
                {
                    Console.WriteLine(student);
                }

                Console.WriteLine("Common Students");
                Console.WriteLine("--------------------");

                HashSet<string> commonSet = new HashSet<string>(csharpStudents);
                commonSet.IntersectWith(sqlStudents);
                foreach(var student in commonSet)
                {
                    Console.WriteLine(student);
                }

                Console.WriteLine("Only In C# Course (Difference)");
                Console.WriteLine("------------------------------");
                HashSet<string> onlyCsharp = new HashSet<string>(csharpStudents);
                onlyCsharp.ExceptWith(sqlStudents);
                foreach(var student in onlyCsharp)
                {
                    Console.WriteLine(student);
                }
                Console.ReadLine();
            }
        }
    }
}
