using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();

            arraylist.Add(10);

            arraylist.Add(20);
                
            arraylist.Add("DivyaKiran");

            arraylist.Add(4000);

            arraylist.Add("Rithwika");

            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }



            //arraylist.Remove("DivyaKiran");

            arraylist.RemoveAt(4);

            arraylist.Insert(2, "Deepanwitha");



            bool istrue =arraylist.Contains( "DivyaKiran");

            Console.WriteLine("Contains DivyaKiran:"+istrue);

            arraylist.Clear();

            for(int i = 0; i < arraylist.Count; i++)
            {
                Console.WriteLine(arraylist[i]);
            }

            Console.WriteLine("List after clearing"+ arraylist.Count);

            
        }
    }
}
