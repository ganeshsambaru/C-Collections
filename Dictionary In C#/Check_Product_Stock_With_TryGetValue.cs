using System;
using System.Collections.Generic;

namespace Dictionary_In_C_
{
    internal class Check_Product_Stock_With_TryGetValue
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Dictionary<int, Tuple<string, int>> inventory = new Dictionary<int, Tuple<string, int>>
                {
                    {101, Tuple.Create("Mobile", 25)},
                    {102, Tuple.Create("Headphones", 15)},
                    {103, Tuple.Create("Laptop", 10)},
                    {104, Tuple.Create("Tablet", 8)},
                    {105, Tuple.Create("Smartwatch", 5)}
                };

                Console.WriteLine("Enter Product Id to check stock:");
                int prodId = int.Parse(Console.ReadLine());

                if (inventory.TryGetValue(prodId, out Tuple<string, int> product))
                {
                    Console.WriteLine($"Product: {product.Item1}, Available Stock: {product.Item2}");
                }
                else
                {
                    Console.WriteLine("Product Not Found in Inventory.");
                }

                Console.ReadLine();
            }
        }
    }
}
