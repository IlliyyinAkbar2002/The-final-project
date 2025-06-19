using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using Windows_Form_Project.Services;
using Windows_Form_Project.Models;
using System.Collections.Generic;

namespace Windows_Form_Project.Tests
{
    [TestClass]
    public class PostManagerTests
    {
        private string testFile;
        private PostManager manager;

        [TestInitialize]
        public void Setup()
        {
            testFile = $"test_posts_{Guid.NewGuid()}.json";
            File.WriteAllText(testFile, "[]");

            // Reset singleton instance
            typeof(PostManager)
                .GetField("_instance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic)!
                .SetValue(null, null);

            manager = (PostManager)Activator.CreateInstance(
                typeof(PostManager),
                true
            )!;

            // Inject test file path
            typeof(PostManager)
                .GetField("_postsFilePath", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)!
                .SetValue(manager, testFile);

            // Reload posts
            typeof(PostManager)
                .GetMethod("LoadPosts", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)!
                .Invoke(manager, null);
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(testFile)) File.Delete(testFile);
        }

        [TestMethod]
        public void AddPost_ShouldAddNewPost()
        {
            manager.AddPost("TestTitle", "Test content", "author1");

            var posts = manager.GetAllPosts();
            Assert.AreEqual(1, posts.Count);
            Assert.AreEqual("TestTitle", posts[0].Title);
            Assert.AreEqual("author1", posts[0].Author);
            Assert.AreEqual(PostStatus.Pending, posts[0].Status);
        }

        [TestMethod]
        public void AddPost_DuplicateTitle_ShouldThrow()
        {
            manager.AddPost("UniqueTitle", "Some content", "authorX");

            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                manager.AddPost("UniqueTitle", "Other content", "authorY");
            });
        }

        [TestMethod]
        public void DeletePost_ShouldRemove()
        {
            manager.AddPost("DeleteMe", "Trash", "user");
            manager.DeletePost("DeleteMe");

            Assert.AreEqual(0, manager.GetAllPosts().Count);
        }

        [TestMethod]
        public void DeletePostByUser_ShouldRemoveIfOwner()
        {
            manager.AddPost("MyPost", "Owned", "me");
            manager.DeletePostByUser("MyPost", "me");

            Assert.AreEqual(0, manager.GetAllPosts().Count);
        }

        [TestMethod]
        public void DeletePostByUser_ShouldNotRemoveIfNotOwner()
        {
            manager.AddPost("TheirPost", "Owned", "them");
            manager.DeletePostByUser("TheirPost", "someoneElse");

            Assert.AreEqual(1, manager.GetAllPosts().Count);
        }

        [TestMethod]
        public void UpdatePostStatus_ShouldChangeStatus()
        {
            manager.AddPost("StatusTest", "Waiting...", "who");
            manager.UpdatePostStatus("StatusTest", PostStatus.Approved);

            var post = manager.GetAllPosts().First();
            Assert.AreEqual(PostStatus.Approved, post.Status);
        }

        [TestMethod]
        public void GetPostsByStatus_ShouldReturnCorrectPosts()
        {
            manager.AddPost("Post1", "A", "user");
            manager.AddPost("Post2", "B", "user");
            manager.UpdatePostStatus("Post2", PostStatus.Finished);

            var pending = manager.GetPostsByStatus(PostStatus.Pending);
            var finished = manager.GetPostsByStatus(PostStatus.Finished);

            Assert.AreEqual(1, pending.Count);
            Assert.AreEqual(1, finished.Count);
        }

        [TestMethod]
        public void GetPostsByAuthor_ShouldReturnOnlyOwnPosts()
        {
            manager.AddPost("A", "Hello", "alice");
            manager.AddPost("B", "Hi", "bob");

            var result = manager.GetPostsByAuthor("bob");

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("B", result[0].Title);
        }
    }
}
