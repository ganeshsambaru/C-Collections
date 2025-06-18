using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_In_C_
{
    internal class Supermarket_Billing_Queue
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Queue<string> billingQueue = new Queue<string>();

                billingQueue.Enqueue("Anil");
                billingQueue.Enqueue("Bhavna");
                billingQueue.Enqueue("Charan");
                billingQueue.Enqueue("Divya");
                billingQueue.Enqueue("Esha");
                Console.WriteLine("current billing in queue");
                foreach (var item in billingQueue)
                {
                    Console.WriteLine(item);
                }
                while (true)
                {
                    if (billingQueue.Count == 0)
                    {
                        Console.WriteLine("All customers billed. Closing counter!");
                        break;
                    }

                    Console.WriteLine("Do you want to bill next customer");
                    string choice = Console.ReadLine().ToLower();
                    if (choice == "yes")
                    {
                        string user = billingQueue.Dequeue();
                        Console.WriteLine($"customer billed:{user}");

                        if (billingQueue.Count > 0)
                        {
                            Console.WriteLine($"Next customer:{billingQueue.Peek()}");
                        }
                        else
                        {
                            Console.WriteLine("No more customers to bill");
                        }
                        Console.WriteLine("Do you want to add new customers");
                        string response = Console.ReadLine().ToLower();

                        if (response == "yes")
                        {
                            Console.WriteLine("Enter customer name to Add");
                            string name = Console.ReadLine();

                            billingQueue.Enqueue(name);

                            Console.WriteLine("customer added successfully");
                        }
                        else
                        {
                            Console.WriteLine("no response from user");
                        }


                    }
                    else
                    {
                        Console.WriteLine("Do you want to clear the queue? (yes/no)");
                        string clearChoice = Console.ReadLine().ToLower();

                        if (clearChoice == "yes")
                        {
                            billingQueue.Clear();
                            Console.WriteLine("Queue cleared.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Exiting without clearing.");
                            break;
                        }
                    }
                    Console.WriteLine($"Billing Queue closed. Total customers remaining: {billingQueue.Count}");
                }
                Console.ReadLine();
            }
        }
    }
}
