using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_In_C_
{
    internal class Manage_Customer_Service_Queue
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Queue<string> customers = new Queue<string>();

                customers.Enqueue("Aarav");
                customers.Enqueue("Neha");
                customers.Enqueue("Rohan");
                customers.Enqueue("Sneha");
                customers.Enqueue("Vikram");

                customers.Dequeue();
                customers.Peek();

                foreach(var item in customers)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(customers.Count);
                Console.ReadLine();
            }
        }
    }
}
