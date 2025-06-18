using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_In_C_
{
    internal class Manage_Bank_Queue
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Queue<string> customers = new Queue<string>();

                customers.Enqueue("Ravi");
                customers.Enqueue("Anjali");
                customers.Enqueue("Suresh");
                customers.Enqueue("Meena");
                customers.Enqueue("Karthik");
                Console.WriteLine("Customers in Queue Currently");
                foreach(var item in customers)
                {
                    Console.WriteLine(item);
                }

                while(true)
                {
                    if(customers.Count == 0)
                    {
                        Console.WriteLine("All customers have been served!");
                        break;
                    }
                    Console.WriteLine("✅ Do you want to serve the next customer");
                    string choice = Console.ReadLine().ToLower();

                    if(choice == "yes")
                    {
                        string serve = customers.Dequeue();
                        Console.WriteLine($"Served:{serve}");

                        if(customers.Count > 0)
                        {
                            Console.WriteLine($"Next In Line:{customers.Peek()}");
                        }
                        else
                        {
                            Console.WriteLine("No more customers waiting");
                        }

                        Console.WriteLine("Do you want to add new customer");
                        string response = Console.ReadLine().ToLower();

                        if(response == "yes")
                        {
                            Console.WriteLine("Enter customer Name");
                            string name = Console.ReadLine();
                            customers.Enqueue(name);
                            Console.WriteLine("Customer Added Successfully");
                        }
                        else
                        {
                            Console.WriteLine("No response");
                        }

                    }
                    else
                    {
                        Console.WriteLine("exit without serving anyone");
                        break;
                    }
                    Console.WriteLine($"Total number of customers in bank:{customers.Count}");
                    
                }
                Console.WriteLine("Thank you for using Bank Management System");
                Console.ReadLine();
            }
        }
    }
}
