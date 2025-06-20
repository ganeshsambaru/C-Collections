using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_In_C_
{
    internal class HashSet_UniqueBooks
    {
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public Book(string title, string author)
            {
                Title = title;
                Author = author;
            }

            public void Display()
            {
                Console.WriteLine($"{Title} by {Author}");
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Book other = (Book)obj;
                return this.Title == other.Title && this.Author == other.Author;
            }

            public override int GetHashCode()
            {
                return (Title + Author).GetHashCode();
            }
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                HashSet<Book> library = new HashSet<Book>();

                library.Add(new Book("Rich Dad Poor Dad", "Robert Kiyosaki"));
                library.Add(new Book("Atomic Habits", "James Clear"));
                library.Add(new Book("The Alchemist", "Paulo Coelho"));
                library.Add(new Book("Rich Dad Poor Dad", "Robert Kiyosaki")); // Duplicate
                library.Add(new Book("The Secret", "Rhonda Byrne"));

                Console.WriteLine("📚 Unique Books in Library:");
                Console.WriteLine("---------------------------");

                foreach (var book in library)
                {
                    book.Display();
                }

                Console.WriteLine($"\nTotal Unique Books: {library.Count}");

                Console.ReadLine();
            }
        }
    }
}
