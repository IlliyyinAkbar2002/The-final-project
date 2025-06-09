using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Windows_Form_Project.Models;
using Windows_Form_Project.Services;
using Windows_Form_Project.Utils;

namespace Windows_Form_Project.Forms
{
    public partial class MainMenuForm : Form
    {
        private readonly User currentUser;
        private readonly UserManager userManager;

        private Dictionary<Button, Action> actionMap;

        public MainMenuForm(User user, UserManager userManager)
        {
            InitializeComponent();
            this.currentUser = user;
            this.userManager = userManager;

            welcomeLabel.Text = $"Welcome, {user.Nama}! Role: {user.Role}";

            SetupRoleMenu();
        }

        private void SetupRoleMenu()
        {
            actionMap = new Dictionary<Button, Action>();

            // Hide all buttons first
            var allButtons = new List<Button>
            {
                viewProfileButton,
                createPostButton,
                searchUserButton,
                createUserButton,
                viewAllPostsButton,
                approveRejectButton,
                changeStatusButton,
                deletePostButton
            };

            foreach (var btn in allButtons)
            {
                btn.Visible = false;
            }

            if (currentUser.Role == Role.Admin)
            {
                AddAction(viewProfileButton, () => ViewProfile());
                AddAction(createPostButton, () => CreatePost());
                AddAction(searchUserButton, () => SearchUser());
                AddAction(createUserButton, () => CreateUser());
                AddAction(viewAllPostsButton, () => ViewAllPosts());
                AddAction(deletePostButton, () => DeletePost());
            }

            else if (currentUser.Role == Role.Lurah)
            {
                AddAction(viewProfileButton, () => ViewProfile());
                AddAction(approveRejectButton, () => ReviewPending());
                AddAction(changeStatusButton, () => ReviewApproved());
                AddAction(deletePostButton, () => DeletePost());
            }
            else // Masyarakat
            {
                AddAction(viewProfileButton, () => ViewProfile());
                AddAction(createPostButton, () => CreatePost());
                AddAction(viewAllPostsButton, () => ViewMyPosts());
                AddAction(deletePostButton, () => DeleteOwnPost());
            }

            //// Attach actions to buttons
            //foreach (var entry in actionMap)
            //{
            //    entry.Key.Click += (s, e) => entry.Value.Invoke();
            //}
        }
        private void AddAction(Button button, Action action)
        {
            actionMap[button] = action;
            button.Visible = true;
            button.Click += (s, e) => action.Invoke();
        }
        private void ViewProfile() => MessageBox.Show("View Profile Clicked");
        private void CreatePost() => MessageBox.Show("Create Post Clicked");
        private void SearchUser() => MessageBox.Show("Search User Clicked");
        private void CreateUser() => MessageBox.Show("Create User Clicked");
        private void ViewAllPosts() => MessageBox.Show("View All Posts Clicked");
        private void ReviewPending() => MessageBox.Show("Review Pending Posts Clicked");
        private void ReviewApproved() => MessageBox.Show("Review Approved Posts Clicked");
        private void ViewMyPosts() => MessageBox.Show("View My Posts Clicked");
        private void DeletePost() => MessageBox.Show("Delete Post Clicked");
        private void DeleteOwnPost() => MessageBox.Show("Delete Own Post Clicked");

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AppStateManager.ChangeState(State.Logout);
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
