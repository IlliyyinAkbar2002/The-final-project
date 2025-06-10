using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Windows_Form_Project.Models;

namespace Windows_Form_Project.Services
{
    public class PostManager
    {
        private static PostManager instance;
        private List<Post> posts;
        private readonly string postsFilePath = "posts.json";

        // Private constructor to enforce singleton
        private PostManager()
        {
            LoadPosts();
        }

        // ✅ Public method to access the singleton instance
        public static PostManager GetInstance()
        {
            if (instance == null)
            {
                instance = new PostManager();
            }
            return instance;
        }

        private void LoadPosts()
        {
            if (File.Exists(postsFilePath))
            {
                string json = File.ReadAllText(postsFilePath);
                posts = JsonConvert.DeserializeObject<List<Post>>(json) ?? new List<Post>();
            }
            else
            {
                posts = new List<Post>();
            }
        }

        private void SavePosts()
        {
            string json = JsonConvert.SerializeObject(posts, Formatting.Indented);
            File.WriteAllText(postsFilePath, json);
        }

        public void AddPost(string title, string content, string author)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content) || string.IsNullOrWhiteSpace(author))
                throw new ArgumentException("All fields must be filled.");

            if (posts.Any(p => p.Title == title))
                throw new InvalidOperationException("Post title must be unique.");

            var newPost = new Post(title, content, author);
            posts.Add(newPost);
            SavePosts();
        }

        public void DeletePost(string title)
        {
            var post = posts.FirstOrDefault(p => p.Title == title);
            if (post != null)
            {
                posts.Remove(post);
                SavePosts();
            }
        }

        public void DeletePostByUser(string title, string username)
        {
            var post = posts.FirstOrDefault(p => p.Title == title && p.Author == username);
            if (post != null)
            {
                posts.Remove(post);
                SavePosts();
            }
        }

        public List<Post> GetAllPosts() => posts;

        public List<Post> GetPostsByStatus(PostStatus status) =>
            posts.Where(p => p.Status == status).ToList();

        public List<Post> GetPostsByAuthor(string author) =>
            posts.Where(p => p.Author == author).ToList();

        public void UpdatePostStatus(string title, PostStatus status)
        {
            var post = posts.FirstOrDefault(p => p.Title == title);
            if (post != null)
            {
                post.Status = status;
                SavePosts();
            }
        }
    }
}
