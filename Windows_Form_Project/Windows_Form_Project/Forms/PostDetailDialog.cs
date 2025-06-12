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

        private readonly Post _post;
        private readonly string _context;
        private readonly Role _role;

        public PostDetailDialog(Post post, string context, Role role)
        {
            InitializeComponent();
            _post = post;
            _context = context;
            _role = role;
            DisplayPostDetails();
            SetupButtons();
        }

        private void DisplayPostDetails()
        {
            textBoxDetails.Text =
                $"Title: {_post.Title}\r\n" +
                $"Author: {_post.Author}\r\n" +
                $"Created: {_post.CreatedAt:g}\r\n" +
                $"Status: {_post.Status}\r\n\r\n" +
                $"{_post.Content}";
        }

        private void SetupButtons()
        {
            if (_role == Role.Admin && _context == "Approved")
                AddActionButton("Delete", PostAction.Delete);
            else if (_role == Role.Lurah && _context == "Pending")
            {
                AddActionButton("Approve", PostAction.Approve);
                AddActionButton("Reject", PostAction.Reject);
            }
            else if (_role == Role.Lurah && _context == "Approved")
                AddActionButton("Finish", PostAction.Finish);
            else if (_role == Role.Masyarakat && _context == "MyPosts")
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
