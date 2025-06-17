using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_In_C_
{
    internal class Manage_Library_Book_Inventory_By_Using_Tuple
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Dictionary<int, Tuple<string, int>> Books = new Dictionary<int, Tuple<string, int>>
                {
                    {201, Tuple.Create("The Alchemist", 5)},
                    {202, Tuple.Create("Clean Code", 3)},
                    {203, Tuple.Create("Atomic Habits", 7)},
                    {204, Tuple.Create("The Pragmatic Programmer", 4)},
                    {205, Tuple.Create("Introduction to Algorithms", 2)}
                };

                foreach (KeyValuePair<int, Tuple<string, int>> book in Books)
                {
                    Console.WriteLine($"BookId:{book.Key},BookName:{book.Value.Item1},Copies:{book.Value.Item2}");
                }

                Console.WriteLine("Enter Book Id");
                int bookId = int.Parse(Console.ReadLine());

                if (Books.ContainsKey(bookId))
                {
                    var book = Books[bookId];
                    Console.WriteLine($"BookName:{book.Item1},Copies Available:{book.Item2}");
                }
                else
                {
                    Console.WriteLine("Book Not Found");
                }

                Console.WriteLine("Enter Book Id To Update");
                int BooksId = int.Parse(Console.ReadLine());

                if (Books.ContainsKey(BooksId))
                {
                    Console.WriteLine("Enter the no of copies to update");
                    int copies = int.Parse(Console.ReadLine());
                    var Book = Books[BooksId];
                    Books[BooksId] = Tuple.Create(Book.Item1, copies);
                    Console.WriteLine("No of copies updated");
                }
                else
                {
                    Console.WriteLine("Book Not Found To Update");
                }

                Console.WriteLine("Enter Id To Delete Book");
                int deleteBook = int.Parse(Console.ReadLine());

                if(Books.ContainsKey(deleteBook))
                {
                    Books.Remove(deleteBook);

                    Console.WriteLine("Book Deleted.");
                }
                else
                {
                    Console.WriteLine("Book Not Found To Delete");
                }

                foreach(var book in Books)
                {
                    Console.WriteLine($"BookId:{book.Key},BookName:{book.Value.Item1},Copies:{book.Value.Item2}");
                }
                Console.ReadLine();
            }
        }
    }
}
