using System;
using System.Collections.Generic;
using System.Drawing;
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
                deletePostButton,
                viewFinishedPostsButton,
                viewApprovedPostsButton
            };

            foreach (var btn in allButtons)
            {
                btn.Visible = false;
            }

            // Table-driven configuration per role
            AddAction(viewProfileButton, ViewProfile); // shared by all roles
            AddAction(createPostButton, CreatePost);
            AddAction(viewApprovedPostsButton, ViewAllApprovedPosts); // Global approved posts
            AddAction(viewFinishedPostsButton, ViewFinishedPosts);

            if (currentUser.Role == Role.Admin)
            {
                AddAction(searchUserButton, SearchUser);
                AddAction(createUserButton, CreateUser);
                AddAction(viewApprovedPostsButton, ViewAllApprovedPosts);
            }
            else if (currentUser.Role == Role.Lurah)
            {
                AddAction(approveRejectButton, ReviewPending);
                AddAction(changeStatusButton, ReviewApproved);
                AddAction(viewApprovedPostsButton, ViewAllApprovedPosts);
                AddAction(viewFinishedPostsButton, ViewFinishedPosts);
            }
            else // Masyarakat
            {
                // Global finished posts
                AddAction(viewAllPostsButton, ViewMyPosts);                // Own posts
            }

            // Reposition logout below visible buttons
            logoutButton.Location = new Point(30, buttonPanel.Bottom + 10);
            this.Height = logoutButton.Bottom + 50; // gives 50px margin at the bottom

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

        private void SearchUser()
        {
            UserManager.GetInstance().Authenticate(currentUser.Username, currentUser.Password);
            AppStateManager.ChangeState(State.SearchUser, currentUser);
        }

        private void CreateUser()
        {
            UserManager.GetInstance().Authenticate(currentUser.Username, currentUser.Password);
            AppStateManager.ChangeState(State.Register, currentUser);
        }

        private void ViewAllApprovedPosts()
        {
            var form = new PostForm("Approved", currentUser);
            form.ShowDialog();
        }

        private void ViewFinishedPosts()
        {
            var form = new PostForm("Finished", currentUser);
            form.ShowDialog();
        }

        private void ReviewPending()
        {
            var form = new PostForm("Pending", currentUser);
            form.ShowDialog();
        }

        private void ReviewApproved()
        {
            var form = new PostForm("Approved", currentUser);
            form.ShowDialog();
        }

        private void ViewMyPosts()
        {
            var form = new PostForm("MyPosts", currentUser);
            form.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AppStateManager.ChangeState(State.Logout);
        }

        private void MainMenuForm_Load(object sender, EventArgs e) { }

        private void welcomeLabel_Click(object sender, EventArgs e) { }

        private void createPostButton_Click(object sender, EventArgs e) { }

        private void viewAllPostsButton_Click(object sender, EventArgs e)
        {

        }

        private void viewAllPostsButton_Click_1(object sender, EventArgs e)
        {

        }

        private void viewFinishedPostsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
