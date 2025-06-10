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

            // Table-driven configuration per role
            AddAction(viewProfileButton, ViewProfile); // shared by all roles

            if (currentUser.Role == Role.Admin)
            {
                AddAction(createPostButton, CreatePost);
                AddAction(searchUserButton, SearchUser);
                AddAction(createUserButton, CreateUser);
                AddAction(viewAllPostsButton, ViewAllPosts);
                AddAction(deletePostButton, DeletePost);
            }
            else if (currentUser.Role == Role.Lurah)
            {
                AddAction(approveRejectButton, ReviewPending);
                AddAction(changeStatusButton, ReviewApproved);
                AddAction(deletePostButton, DeletePost);
            }
            else // Masyarakat
            {
                AddAction(createPostButton, CreatePost);
                AddAction(viewAllPostsButton, ViewMyPosts);
                AddAction(deletePostButton, DeleteOwnPost);
            }

            // Reposition logout below visible buttons
            logoutButton.Location = new Point(30, buttonPanel.Bottom + 10);
        }

        private void AddAction(Button button, Action action)
        {
            actionMap[button] = action;
            button.Visible = true;
            button.Click += (s, e) => action.Invoke();
        }

        // =========================
        // === Button Logic Below ===
        // =========================
        private void ViewProfile()
        {
            UserManager.GetInstance().Authenticate(currentUser.Username, currentUser.Password);
            AppStateManager.ChangeState(State.ViewProfile, currentUser);
        }

        private void CreatePost()
        {
            UserManager.GetInstance().Authenticate(currentUser.Username, currentUser.Password);
            AppStateManager.ChangeState(State.CreatePost, currentUser);
        }

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

        private void MainMenuForm_Load(object sender, EventArgs e) { }

        private void welcomeLabel_Click(object sender, EventArgs e) { }

        private void createPostButton_Click(object sender, EventArgs e)
        {

        }
    }
}
