using System;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var post = new Post();
            post.Title = "The Title";
            Console.WriteLine(post.Title);
            Console.WriteLine(post.Votes);
            Console.WriteLine(post.Created);
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.UpVote();
            Console.WriteLine(post.Votes);

        }
    }
}
