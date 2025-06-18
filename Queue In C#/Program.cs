using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Queue_In_C_
{
    internal class Program
    {
        //A Queue is a FIFO(First In, First Out) data structure.

        //The first element added is the first one to be removed.

        //It's useful for scheduling, buffering, and task management.
        static void Main(string[] args)
        {
            Queue<string> line = new Queue<string>();

            line.Enqueue("Alice");   // Alice is added
            line.Enqueue("Bob");     // Bob is added
            line.Enqueue("Charlie"); // Charlie is added

            Console.WriteLine(line.Dequeue()); // Output: Alice
            Console.WriteLine(line.Peek());    // Output: Bob

            line.Enqueue("Apple");
            string front = line.Dequeue();
            Console.WriteLine(front);
            string front1 = line.Peek();
            Console.WriteLine(front1);
            int total = line.Count;
            bool exists = line.Contains("Apple");
            line.Clear();
            string[] arr = line.ToArray();








        }
    }
}
