using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Windows_Form_Project.Models;
using Windows_Form_Project.Services;

namespace Windows_Form_Project.Forms
{
    public partial class PostForm : Form
    {
        private readonly PostManager postManager = PostManager.GetInstance();
        private readonly string context;
        private readonly User currentUser;

        public PostForm(string context, User currentUser)
        {
            InitializeComponent();
            this.context = context;
            this.currentUser = currentUser;
            LoadPostData();
        }

        private void LoadPostData()
        {
            List<Post> filteredPosts = new();

            switch (context)
            {
                case "Approved":
                    filteredPosts = postManager.GetPostsByStatus(PostStatus.Approved);
                    break;
                case "Finished":
                    filteredPosts = postManager.GetPostsByStatus(PostStatus.Finished);
                    break;
                case "Pending":
                    filteredPosts = postManager.GetPostsByStatus(PostStatus.Pending);
                    break;
                case "MyPosts":
                    filteredPosts = postManager.GetPostsByAuthor(currentUser.Username);
                    break;

            }

            PopulateListView(filteredPosts);
        }

        private void PopulateListView(List<Post> posts)
        {
            listViewPosts.Items.Clear();
            foreach (var post in posts)
            {
                var item = new ListViewItem(post.Title);
                item.SubItems.Add(post.Author);
                item.SubItems.Add(post.CreatedAt.ToString("g"));
                item.SubItems.Add(post.Status.ToString());
                item.Tag = post;
                listViewPosts.Items.Add(item);
            }
        }

        private void listViewPosts_ItemActivate(object sender, EventArgs e)
        {
            if (listViewPosts.SelectedItems.Count == 0) return;

            var selectedPost = listViewPosts.SelectedItems[0].Tag as Post;
            if (selectedPost == null) return;

            var dialog = new PostDetailDialog(selectedPost, context, currentUser.Role);
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                switch (dialog.SelectedAction)
                {
                    case PostDetailDialog.PostAction.Delete:
                        if (currentUser.Role == Role.Admin)
                            postManager.DeletePost(selectedPost.Title);
                        else if (currentUser.Role == Role.Masyarakat)
                            postManager.DeletePostByUser(selectedPost.Title, currentUser.Username);
                        break;
                    case PostDetailDialog.PostAction.Approve:
                        postManager.UpdatePostStatus(selectedPost.Title, PostStatus.Approved);
                        break;
                    case PostDetailDialog.PostAction.Reject:
                        postManager.UpdatePostStatus(selectedPost.Title, PostStatus.Rejected);
                        break;
                    case PostDetailDialog.PostAction.Finish:
                        postManager.UpdatePostStatus(selectedPost.Title, PostStatus.Finished);
                        break;
                }

                LoadPostData();
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text.Trim().ToLower();
            var allPosts = context switch
            {
                "Approved" => postManager.GetPostsByStatus(PostStatus.Approved),
                "Pending" => postManager.GetPostsByStatus(PostStatus.Pending),
                "MyPosts" => postManager.GetPostsByAuthor(currentUser.Username),
                _ => new List<Post>()
            };

            var filtered = allPosts.FindAll(p => p.Title.ToLower().Contains(keyword) || p.Content.ToLower().Contains(keyword));
            PopulateListView(filtered);
        }

        private void PostForm_Load(object sender, EventArgs e) { }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void listViewPosts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
