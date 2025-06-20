using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_In_C_
{
    internal class GenericStack_UndoHistory
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Stack<string> UndoHistory = new Stack<string>();
                UndoHistory.Push("Typed: Hello");
                UndoHistory.Push("Bold: Hello");
                UndoHistory.Push("Typed: World");
                UndoHistory.Push("Deleted: World");

                foreach(var item in UndoHistory)
                {
                    Console.WriteLine(item);
                }
                UndoHistory.Pop();
                UndoHistory.Pop();

                Console.WriteLine($"Remaining Undo Actions:");
                foreach(var item in UndoHistory)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"Next Undo Action:{UndoHistory.Peek()}");
                Console.WriteLine($"Total number of Actions:{UndoHistory.Count}");

                Console.ReadLine();
            }
        }
    }
}
