using System;
namespace StackOverflow
{
    public class Post
    {
        private string Title { get; set; }
        private string Description { get; set; }
        private DateTime Created { get; set; }
        private int Votes { get; set; }
        public Post(string title, string desc)
        {
            Created = DateTime.Now;
            this.Title = title;
            this.Description = desc;
        }
        public void UpVote()
        {
            this.Votes++;
        }
        public void DownVote()
        {
            this.Votes--;
        }
        public void Show()
        {
            Console.WriteLine("Title: {0} Desc: {1} Votes: {2}",this.Title, this.Description, this.Votes);
        }
    }
}
