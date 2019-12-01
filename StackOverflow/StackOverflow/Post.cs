using System;
namespace StackOverflow
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int Votes { get; private set; }
        public Post()
        {
            Created = DateTime.Now;
        }
        public int UpVote()
        {
            return Votes++;
        }
        public int DownVote()
        {
            return Votes--;
        }
    }
}
