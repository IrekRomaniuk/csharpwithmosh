using System;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var post = new Post("The Title", "The Description");
           
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.UpVote();
            post.Show();

        }
    }
}
