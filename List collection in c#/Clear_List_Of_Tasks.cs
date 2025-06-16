using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_collection_in_c_
{
    internal class Clear_List_Of_Tasks
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                List<string> DailyRoutines = new List<string>
                {
                    "Wakeup","Brush","Breakfast","Study slot1","Lunch","Study slot2","Dinner","Sleep"
                };

                Console.WriteLine("Daily Routines");
                Console.WriteLine("-------------------");
                foreach(string DailyRoutine in DailyRoutines)
                {
                    Console.WriteLine(DailyRoutine);
                }

                Console.WriteLine("Do you want to clear all tasks?,yes/no");

                string response = Console.ReadLine();

                if(response.ToLower() == "yes")
                {
                    Console.WriteLine("\nAll tasks cleared.Updated List:");
                    DailyRoutines.Clear();

                    if (DailyRoutines.Count == 0)
                    {
                        Console.WriteLine("[No tasks remaining]");
                    }

                    foreach (string DailyRoutine in DailyRoutines)
                    {
                        Console.WriteLine(DailyRoutine);
                    }

                }
                else
                {
                    Console.WriteLine("\nTasks are not cleared. Current List:");
                    foreach (string DailyRoutine in DailyRoutines)
                    {
                        Console.WriteLine(DailyRoutine);
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
