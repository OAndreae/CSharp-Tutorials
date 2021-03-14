using System;

namespace StackOverflowPost
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; private set; }
        public int Votes { get; private set; }

        public Post()
        {
            this.DateCreated = DateTime.Now;
            this.Votes = 0;
        }

        public void UpVote()
        {
            Votes++;
        }

        public void DownVote()
        {
            Votes--;
        }

    }
}
