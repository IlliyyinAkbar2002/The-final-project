using System;

namespace Windows_Form_Project.Models
{
    public enum PostStatus
    {
        Pending,
        Approved,
        Rejected,
        Hidden,
        Finished
    }

    public class Post
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime CreatedAt { get; set; }
        public PostStatus Status { get; set; }

        public Post(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
            CreatedAt = DateTime.Now;
            Status = PostStatus.Pending;
        }
    }
}
