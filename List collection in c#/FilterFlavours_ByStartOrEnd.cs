using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_collection_in_c_
{
    internal class FilterFlavours_ByStartOrEnd
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                List<string> icecream = new List<string>
                {
                    "Butterscotch","Strawberry","Vanilla","Rocky road","Corn ice cream","Black rasberry"
                };

                Console.WriteLine("\nOriginal List");
                foreach(string ice in icecream)
                {
                    Console.WriteLine(ice);
                }

                Console.WriteLine("Enter the first letter of ice cream");

                string firstletter = Console.ReadLine();

                foreach(string ice in icecream)
                {
                    if(ice.StartsWith(firstletter,StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(ice);
                    }
                }

                Console.WriteLine("enter the lastletter of ice cream");

                string lastletter = Console.ReadLine();

                foreach (string ice in icecream)
                {
                    if(ice.EndsWith(lastletter,StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(ice);
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
