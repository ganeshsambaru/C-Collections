using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_In_C_
{
    internal class GenericStack_BrowserHistory
    {
        public class WebPage
        {
            public string Url { get; set; }
            public DateTime VisitedAt { get; set; }

            public WebPage(string url,DateTime time) 
            {
                Url = url;
                VisitedAt = time;

            }

            public void Display()
            {
                Console.WriteLine($"Visited:{Url} at {VisitedAt.ToString("dd-MM-yyyy hh:mm tt")}");
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                 
                Stack<WebPage> browserHistory = new Stack<WebPage>();
                WebPage page1 = new WebPage("https://youtube.com", new DateTime(2025, 6, 18, 19, 28, 0));
                WebPage page2 = new WebPage("https://chat.openai.com", new DateTime(2025, 6, 18, 19, 29, 0));
                WebPage page3 = new WebPage("https://dotnet.microsoft.com", new DateTime(2025, 6, 18, 19, 30, 0));

                browserHistory.Push(page1);
                browserHistory.Push(page2);
                browserHistory.Push(page3);

                Console.WriteLine("Browser History");
                foreach(var page in browserHistory)
                {
                    page.Display();
                }

                Console.WriteLine($"Last Visited Page:");

                WebPage last = browserHistory.Pop();
                last.Display();
                Console.WriteLine($"current page:");
                WebPage currentpage = browserHistory.Peek();
                currentpage.Display();

                Console.WriteLine("Remaining webpages history");
                foreach(var page in browserHistory)
                {
                    page.Display();
                }
                Console.WriteLine($"Total pages history:{browserHistory.Count}");
                Console.ReadLine();
                
            }
        }
    }
}
