using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Exercises_02_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            StackPostProgram();
        }

        static void StackPostProgram()
        {
            var post = new Post();
            Console.WriteLine("Upvotes: {0}, Downvotes: {1}",post.Upvote(),
                                post.Downvote());
            List<Post> posts = new List<Post>();
            posts.Add(new Post("Procedural programmming", "This is quite fun, this is pretty easy, thinks the average Joe"));
            posts.Add(new Post("Wow, this is amazing", "This might be the post of your life"));
            posts.Add(post);

            foreach (var postocska in posts)
            {
                Console.WriteLine(postocska.TimeCreated + " " + postocska.Title);
                Console.WriteLine(postocska.Upvotes + " upvotes and " + postocska.Downvotes + " downvotes");
            }

            Console.WriteLine(posts.Count);
            

        }
        static void StopWatchProgram()
        {
            var stopwatch = new StopWatch();
            int choice;

            do
            {
                Console.Write("1-Start Timer\n2-Stop Timer\n3-Read Timer\n0-Quit\n");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: stopwatch.Start(); break;
                    case 2: stopwatch.Stop(); break;
                    case 3: Console.WriteLine(stopwatch.Duration()); break;
                }
            } while (choice != 0);
        }
    }
}
