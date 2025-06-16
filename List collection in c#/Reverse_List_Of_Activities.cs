using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_collection_in_c_
{
    internal class Reverse_List_Of_Activities
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                List<string> DailyRoutines = new List<string>
                {
                    "Wakeup","Brush","Breakfast","Study slot1","Lunch","Study slot2","Dinner","Sleep"
                };

                Console.WriteLine("Original List");
                Console.WriteLine("----------------");

                foreach(string DailyRoutine in DailyRoutines)
                {
                    Console.WriteLine(DailyRoutine);
                }

                Console.WriteLine("Reversed List");
                Console.WriteLine("----------------");

                DailyRoutines.Reverse();

                foreach(string DailyRoutine in DailyRoutines)
                {
                    Console.WriteLine(DailyRoutine);
                }
                Console.ReadLine();
            }
        }
    }
}
