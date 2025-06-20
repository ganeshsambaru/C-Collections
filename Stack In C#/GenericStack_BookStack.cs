using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_In_C_
{
    internal class GenericStack_BookStack
    {
        public class Book
        {
            public string Title {  get; set; }
            public string Author { get; set; }

            public void Display()
            {
                Console.WriteLine($"{Title} by {Author}");
            }
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                Book book = new Book
                {
                    Title = "Rich Dad Poor Dad",
                    Author = "Robert Kiyosaki"
                };
                Book book1 = new Book
                {
                    Title = "Atomic Habits",
                    Author = "James Clear"
                };
                Book book2 = new Book
                {
                    Title = "The Alchemist",
                    Author = "Paulo Coelho"
                };

                Stack<Book> stack = new Stack<Book>();
                stack.Push(book);
                stack.Push(book1);
                stack.Push(book2);

                Console.WriteLine("Books Read History");
                foreach(var item in stack)
                {
                    item.Display();
                }

                Console.WriteLine("Last Read Book");
                Book lastread = stack.Pop();

                Console.WriteLine($"last read book :{lastread.Title} by {lastread.Author}");

                Console.WriteLine("Next Book To Read");

                Book next = stack.Peek();

                Console.WriteLine($"Next Book To Read:{next.Title} by {next.Author}");

                Console.WriteLine("Remaining Books");
                foreach(var item in stack)
                {
                    item.Display();
                }
                Console.WriteLine($"Total books:{stack.Count}");
                Console.ReadLine();
            }
        }
    }
}
