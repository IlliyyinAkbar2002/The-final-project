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
            AddAction(createPostButton, CreatePost);

            if (currentUser.Role == Role.Admin)
            {
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

        private void ViewAllPosts()
        {
            var form = new PostForm("Approved", currentUser); // Admin: view/delete approved posts
            form.ShowDialog();
        }

        private void ReviewPending()
        {
            var form = new PostForm("Pending", currentUser); // Lurah: approve/reject
            form.ShowDialog();
        }

        private void ReviewApproved()
        {
            var form = new PostForm("Approved", currentUser); // Lurah: finish approved posts
            form.ShowDialog();
        }

        private void ViewMyPosts()
        {
            var form = new PostForm("MyPosts", currentUser); // Masyarakat: view/delete own posts
            form.ShowDialog();
        }

        private void DeletePost()
        {
            var form = new PostForm("Approved", currentUser); // Admin: same form, delete on click
            form.ShowDialog();
        }

        private void DeleteOwnPost()
        {
            var form = new PostForm("MyPosts", currentUser); // Masyarakat: same form, delete on click
            form.ShowDialog();
        }

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

        private void viewAllPostsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
