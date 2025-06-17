using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_In_C_
{
    internal class Manage_Movie_Tickets_Using_Dictionary_Tuple
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Dictionary<int, Tuple<string, int>> movies = new Dictionary<int, Tuple<string, int>>
                {
                  { 301, Tuple.Create("Inception", 20) },
                  { 302, Tuple.Create("Interstellar", 15) },
                  { 303, Tuple.Create("The Matrix", 10) },
                  { 304, Tuple.Create("Avatar", 18) },
                  { 305, Tuple.Create("Dune", 12) }
                };
                foreach (var movie in movies)
                {
                    Console.WriteLine($"Movie Id:{movie.Key},Movie Name:{movie.Value.Item1},Available Tickets:{movie.Value.Item2}");
                }

                Console.WriteLine("Enter Id To Search Movie");
                int movieId = int.Parse(Console.ReadLine());

                if(movies.ContainsKey(movieId))
                {
                    Console.WriteLine("Enter the tickets to Update");
                    int count = int.Parse(Console.ReadLine());

                    var movie = movies[movieId];
                    movies[movieId] = Tuple.Create(movie.Item1, count);
                    Console.WriteLine("No Of Tickets Updated");
                }
                else
                {
                    Console.WriteLine("Movie Not Found To Update");
                }

                Console.WriteLine("Enter Movie Id To Delete");
                int DeleteId = int.Parse(Console.ReadLine());

                if (movies.ContainsKey(DeleteId))
                {
                    movies.Remove(DeleteId);
                    Console.WriteLine("Movie Deleted.");
                }
                else
                {
                    Console.WriteLine("Movie Not Found To Delete.");
                }

                foreach(var movie in movies)
                {
                    Console.WriteLine($"Movie Id:{movie.Key},Movie Name:{movie.Value.Item1},Available Tickets:{movie.Value.Item2}");
                }
                Console.ReadLine();
            }
        }
    }
}
