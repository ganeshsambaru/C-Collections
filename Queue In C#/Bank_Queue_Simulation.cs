using System;
using System.Collections.Generic;

namespace Queue_In_C_
{
    internal class Bank_Queue_Simulation
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                // Step 1: Create a queue of customer names
                Queue<string> bankQueue = new Queue<string>();

                // Step 2: Add 5 dummy customers using Enqueue
                bankQueue.Enqueue("Aarav");
                bankQueue.Enqueue("Neha");
                bankQueue.Enqueue("Rohan");
                bankQueue.Enqueue("Sneha");
                bankQueue.Enqueue("Vikram");

                // Step 3: Display current queue
                Console.WriteLine("\n🏦 Current Queue in Bank:");
                foreach (var customer in bankQueue)
                {
                    Console.WriteLine(customer);
                }

                // Step 4: Start a loop to serve customers
                while (true)
                {
                    if (bankQueue.Count == 0)
                    {
                        Console.WriteLine("\n✅ All customers have been served!");
                        break;
                    }

                    Console.WriteLine("\n➡️ Do you want to serve the next customer? (yes/no)");
                    string choice = Console.ReadLine().ToLower();

                    if (choice == "yes")
                    {
                        // Serve the next customer
                        string servedCustomer = bankQueue.Dequeue();
                        Console.WriteLine($"👤 Served: {servedCustomer}");

                        // Show next in line (if any)
                        if (bankQueue.Count > 0)
                        {
                            Console.WriteLine($"🔜 Next in line: {bankQueue.Peek()}");
                        }
                        else
                        {
                            Console.WriteLine("📭 No more customers in queue.");
                        }

                        // Show remaining count
                        Console.WriteLine($"🧮 Remaining in queue: {bankQueue.Count}");
                    }
                    else
                    {
                        Console.WriteLine("⏹️ Exiting without serving anyone.");
                        break;
                    }
                }

                Console.WriteLine("\nThank you for using the Bank Queue System!");
                Console.ReadLine();
            }
        }
    }
}
