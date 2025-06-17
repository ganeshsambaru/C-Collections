using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_In_C_
{
    internal class Product_Inventory_Management
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Dictionary<int, Tuple<string, int>> products = new Dictionary<int, Tuple<string, int>>
                {
                       { 201, Tuple.Create("Keyboard", 50) },
                       { 202, Tuple.Create("Mouse", 30) },
                       { 203, Tuple.Create("Monitor", 15) },
                       { 204, Tuple.Create("Printer", 10) },
                       { 205, Tuple.Create("Speaker", 25) },
                };

                foreach (KeyValuePair<int, Tuple<string, int>> product in products)
                {
                    Console.WriteLine($"ProductId:{product.Key},ProductName:{product.Value.Item1},ProductQuantity:{product.Value.Item2}");
                }

                Console.WriteLine("Enter Id to search for product");

                int productId = int.Parse(Console.ReadLine());

                if(products.ContainsKey(productId))
                {
                    Console.WriteLine("Enter the Quantity to Update");

                    int quantity = int.Parse(Console.ReadLine());
                    var product = products[productId];
                    products[productId]= Tuple.Create(product.Item1, quantity);
                    Console.WriteLine("Product Quantity Updated.");
                }
                else
                {
                    Console.WriteLine("\nProduct Not Found To Update");
                }

                Console.WriteLine("Enter Product Id to Delete");
                int DeleteById = int.Parse(Console.ReadLine());

                if(products.ContainsKey(DeleteById))
                {
                    products.Remove(DeleteById);
                    Console.WriteLine("Product deleted.");
                }
                else
                {
                    Console.WriteLine("Product Not Found to Delete");
                }

                Console.WriteLine("\nAll Products:");
                foreach (var item in products)
                {
                    Console.WriteLine($"ID: {item.Key}, Name: {item.Value.Item1}, Quantity: {item.Value.Item2}");
                }

                Console.ReadLine();
            }               
        }
    }
}

