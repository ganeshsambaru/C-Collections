using System;
using System.Collections.Generic;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> tasks = new Stack<string>();

            // Push - Add elements
            tasks.Push("Wake up");
            tasks.Push("Brush");
            tasks.Push("Exercise");

            Console.WriteLine("Current stack:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task); // LIFO order
            }

            // Peek - See top element
            Console.WriteLine("\nTop Task: " + tasks.Peek());

            // Pop - Remove top element
            Console.WriteLine("Completed: " + tasks.Pop());

            // After popping
            Console.WriteLine("\nStack after Pop:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }

            // Contains
            Console.WriteLine("\nContains 'Brush'? " + tasks.Contains("Brush"));
            Console.WriteLine("Contains 'Exercise'? " + tasks.Contains("Exercise"));

            // Count
            Console.WriteLine("Number of tasks: " + tasks.Count);

            // Clear
            tasks.Clear();
            Console.WriteLine("Stack cleared. Count: " + tasks.Count);
        }
    }
}
