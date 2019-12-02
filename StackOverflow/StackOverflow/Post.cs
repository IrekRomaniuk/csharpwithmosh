using System;
namespace StackOverflow
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _created;
        private int _votes { get; set; }
        public Post(string title, string desc)
        {
            _created = DateTime.Now;
            _title = title;
            _description = desc;
        }
        public void UpVote()
        {
            _votes++;
        }
        public void DownVote()
        {
            _votes--;
        }
        public void Show()
        {
            Console.WriteLine("Title: {0} Desc: {1} Votes: {2}",_title, _description, _votes);
        }
    }
}
