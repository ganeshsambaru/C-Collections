using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_In_C_
{
    internal class Employee_Record_Management
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Dictionary<int, string> Employees = new Dictionary<int, string>
                {
                    {101, "Bob" },{102,"David"},{103,"Henry"},{104,"John"},{105,"Jack"}
                };

                Console.WriteLine("Enter Id to search");
                int EmployeeID = int.Parse(Console.ReadLine());

                if(Employees.ContainsKey(EmployeeID))
                {
                    Console.WriteLine($"Employee Found :{Employees[EmployeeID]}");
                }
                else
                {
                    Console.WriteLine("Employee Not Found");
                }

                Console.WriteLine("Enter Id To Update Employee");
                int EmpId = int.Parse(Console.ReadLine());

                

                if(Employees.ContainsKey(EmpId))
                {
                    Console.WriteLine("Enter The Name To Update");
                    string newName = Console.ReadLine();
                    Employees[EmpId] = newName;
                    Console.WriteLine("Employee name updated successfully.");
                }
                else
                {
                    Console.WriteLine("Employee Id Not Exists");
                }

                Console.WriteLine("Enter Id to delete");
                int EmplId = int.Parse(Console.ReadLine());

                if(Employees.ContainsKey(EmplId))
                {
                    Employees.Remove(EmplId);
                }
                else
                {
                    Console.WriteLine("Employee Not Found To Delete");
                }
                foreach (KeyValuePair<int, string> emp in Employees)
                {
                    Console.WriteLine($"Employee Id:{emp.Key},Name:{emp.Value}");
                }

                Console.ReadLine();
            }
        }
    }
}
