using System;
using System.Collections.Generic;

namespace Queue_In_C_
{
    internal class Manage_Print_Queue
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Queue<string> printQueue = new Queue<string>();

                // Add 5 initial dummy jobs
                printQueue.Enqueue("Print Report.pdf");
                printQueue.Enqueue("Print Invoice.docx");
                printQueue.Enqueue("Print Presentation.pptx");
                printQueue.Enqueue("Print Timesheet.xlsx");
                printQueue.Enqueue("Print Brochure.pub");

                while (true)
                {
                    Console.WriteLine("\n--- Print Queue Menu ---");
                    Console.WriteLine("1. Print a Job (Dequeue)");
                    Console.WriteLine("2. Peek at Next Job");
                    Console.WriteLine("3. Add New Job");
                    Console.WriteLine("4. View All Jobs");
                    Console.WriteLine("5. Exit");
                    Console.Write("Choose an option: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            if (printQueue.Count > 0)
                            {
                                string job = printQueue.Dequeue();
                                Console.WriteLine($"Printing: {job}");
                            }
                            else
                            {
                                Console.WriteLine("No print jobs available.");
                            }
                            break;

                        case "2":
                            if (printQueue.Count > 0)
                            {
                                Console.WriteLine($"Next job: {printQueue.Peek()}");
                            }
                            else
                            {
                                Console.WriteLine("Queue is empty.");
                            }
                            break;

                        case "3":
                            Console.Write("Enter job name to add: ");
                            string newJob = Console.ReadLine();
                            printQueue.Enqueue(newJob);
                            Console.WriteLine("Job added successfully.");
                            break;

                        case "4":
                            Console.WriteLine("\nCurrent Print Jobs:");
                            if (printQueue.Count > 0)
                            {
                                foreach (var job in printQueue)
                                {
                                    Console.WriteLine(job);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No jobs in the queue.");
                            }
                            break;

                        case "5":
                            Console.WriteLine("Exiting program...");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
        }
    }
}
