using System;
using System.Collections.Generic;

namespace Dictionary_In_C_
{
    internal class Use_TryGetValue_To_Check_Product
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Dictionary<int, string> products = new Dictionary<int, string>
                {
                    {1001, "Laptop"},
                    {1002, "Keyboard"},
                    {1003, "Mouse"},
                    {1004, "Monitor"},
                    {1005, "Printer"}
                };

                Console.WriteLine("Enter Product Id to search:");
                int productId = int.Parse(Console.ReadLine());

                if (products.TryGetValue(productId, out string productName))
                {
                    Console.WriteLine($"Product Found: {productName}");
                }
                else
                {
                    Console.WriteLine("Product Not Found");
                }

                Console.ReadLine();
            }
        }
    }
}
