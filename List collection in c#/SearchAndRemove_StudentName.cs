using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_collection_in_c_
{
    internal class SearchAndRemove_StudentName
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                List<string> flavour = new List<string>
                {
                    "Vennela","Butterscotch","Grape","Strawberry","Watermelon","Orange"
                };

                Console.WriteLine("\nOriginal List");

                foreach(string f in flavour)
                {
                    Console.WriteLine(f);
                }

                Console.WriteLine("enter the flavour name to remove");

                string flavourname = Console.ReadLine();

                if(flavour.Contains(flavourname))
                {
                    flavour.Remove(flavourname);

                    Console.WriteLine("Updated List");
                    foreach (string f in flavour)
                    {
                        Console.WriteLine(f);
                    }
                }
                else
                {
                    Console.WriteLine("flavour not exist in the list");
                }

                Console.ReadLine();

            }
        }
    }
}
