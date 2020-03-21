using System;

namespace _015_Exercises_02_Classes
{
    public class Post
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime TimeCreated { get; private set; }

        public int Upvotes { get; private set; }
        public int Downvotes { get; private set; }

        public Post()
        {
            this.TimeCreated = DateTime.Now;
            this.Upvotes = 0;
            this.Downvotes = 0;
        }

        public Post(string title, string description) 
            : this()
        {
            this.Title = title;
            this.Description = description;
        }

    
        public int Upvote()
        {
            this.Upvotes += 1;
            return Upvotes;
        }

        public int Downvote()
        {
            this.Downvotes += 1;
            return Downvotes;
        }
    }
}
