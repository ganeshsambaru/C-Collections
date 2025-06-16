using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Collections
{
    public  class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

       



    }

    public class Programe
    {
        public static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList()
            {
                new Employee { Id = 1, Name = "DivyaKiran", Salary = 1000 },

                new Employee { Id = 2, Name = "ritwika", Salary = 2000 },

                new Employee { Id = 3, Name = "Deepanwitha", Salary = 3000 }
            };

            foreach (var item in arrayList)
            {
                Console.WriteLine(item); 
            }

            Console.WriteLine("enter employee name");

            string name = Console.ReadLine();

            bool isFound = false;

            foreach (Employee emp in arrayList)
            {
                if (emp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    isFound = true;
                    break;
                }
            }

            Console.WriteLine("Employee is: " + isFound);
        }
    }
}
