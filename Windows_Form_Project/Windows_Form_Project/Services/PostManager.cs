using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows_Form_Project.Models;

namespace Windows_Form_Project.Services
{
    public class PostManager
    {
        private static PostManager _instance;
        private static readonly object _lock = new object();

        private List<Post> _posts;
        private readonly string _postsFilePath = "posts.json";

        // Private constructor to enforce singleton
        private PostManager()
        {
            LoadPosts();
        }

        // Public method to access the singleton instance
        public static PostManager GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new PostManager();
                    }
                }
            }
            return _instance;
        }

        private void LoadPosts()
        {
            if (File.Exists(_postsFilePath))
            {
                string json = File.ReadAllText(_postsFilePath);
                _posts = JsonConvert.DeserializeObject<List<Post>>(json) ?? new List<Post>();
            }
            else
            {
                _posts = new List<Post>();
            }
        }

        private void SavePosts()
        {
            string json = JsonConvert.SerializeObject(_posts, Formatting.Indented);
            File.WriteAllText(_postsFilePath, json);
        }

        public void AddPost(string title, string content, string author)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content) || string.IsNullOrWhiteSpace(author))
                throw new ArgumentException("All fields must be filled.");

            if (_posts.Any(p => p.Title == title))
                throw new InvalidOperationException("Post title must be unique.");

            var newPost = new Post(title, content, author);
            _posts.Add(newPost);
            SavePosts();
        }

        public void DeletePost(string title)
        {
            var post = _posts.FirstOrDefault(p => p.Title == title);
            if (post != null)
            {
                _posts.Remove(post);
                SavePosts();
            }
        }

        public void DeletePostByUser(string title, string username)
        {
            var post = _posts.FirstOrDefault(p => p.Title == title && p.Author == username);
            if (post != null)
            {
                _posts.Remove(post);
                SavePosts();
            }
        }

        public List<Post> GetAllPosts() => _posts;

        public List<Post> GetPostsByStatus(PostStatus status) =>
            _posts.Where(p => p.Status == status).ToList();

        public List<Post> GetPostsByAuthor(string author) =>
            _posts.Where(p => p.Author == author).ToList();

        public void UpdatePostStatus(string title, PostStatus status)
        {
            var post = _posts.FirstOrDefault(p => p.Title == title);
            if (post != null)
            {
                post.Status = status;
                SavePosts();
            }
        }
    }
}
