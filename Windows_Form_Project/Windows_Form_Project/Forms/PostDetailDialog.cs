using System;
using System.Drawing;
using System.Windows.Forms;
using Windows_Form_Project.Models;

namespace Windows_Form_Project.Forms
{
    public partial class PostDetailDialog : Form
    {
        public enum PostAction { None, Delete, Approve, Reject, Finish }
        public PostAction SelectedAction { get; private set; } = PostAction.None;

        private readonly Post post;
        private readonly string context;
        private readonly Role role;

        public PostDetailDialog(Post post, string context, Role role)
        {
            InitializeComponent();
            this.post = post;
            this.context = context;
            this.role = role;
            DisplayPostDetails();
            SetupButtons();
        }

        private void DisplayPostDetails()
        {
            textBoxDetails.Text =
                $"Title: {post.Title}\r\n" +
                $"Author: {post.Author}\r\n" +
                $"Created: {post.CreatedAt:g}\r\n" +
                $"Status: {post.Status}\r\n\r\n" +
                $"{post.Content}";
        }

        private void SetupButtons()
        {
            if (role == Role.Admin && context == "Approved")
                AddActionButton("Delete", PostAction.Delete);
            else if (role == Role.Lurah && context == "Pending")
            {
                AddActionButton("Approve", PostAction.Approve);
                AddActionButton("Reject", PostAction.Reject);
            }
            else if (role == Role.Lurah && context == "Approved")
                AddActionButton("Finish", PostAction.Finish);
            else if (role == Role.Masyarakat && context == "MyPosts")
                AddActionButton("Delete", PostAction.Delete);
        }

        private void AddActionButton(string text, PostAction action)
        {
            var button = new Button
            {
                Text = text,
                AutoSize = true,
                DialogResult = DialogResult.OK
            };
            button.Click += (s, e) => SelectedAction = action;
            flowLayoutPanelButtons.Controls.Add(button);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
