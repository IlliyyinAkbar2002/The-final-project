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
        private readonly User _currentUser;
        private readonly UserManager _userManager;
        private Dictionary<Button, Action> _actionMap;

        public MainMenuForm(User user, UserManager userManager)
        {
            InitializeComponent();
            _currentUser = user;
            _userManager = userManager;

            welcomeLabel.Text = $"Welcome, {user.Nama}! Role: {user.Role}";
            SetupRoleMenu();
        }

        private void SetupRoleMenu()
        {
            _actionMap = new Dictionary<Button, Action>();

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

            // Role-specific actions
            switch (_currentUser.Role)
            {
                case Role.Admin:
                    AddAction(searchUserButton, SearchUser);
                    AddAction(createUserButton, CreateUser);
                    break;

                case Role.Lurah:
                    AddAction(approveRejectButton, ReviewPending);
                    AddAction(changeStatusButton, ReviewApproved);
                    break;

                case Role.Masyarakat:
                    AddAction(viewAllPostsButton, ViewMyPosts);
                    break;
            }

            // Reposition logout below visible buttons
            logoutButton.Location = new Point(30, buttonPanel.Bottom + 10);
            this.Height = logoutButton.Bottom + 50; // gives 50px margin at the bottom

        }

        private void AddAction(Button button, Action action)
        {
            _actionMap[button] = action;
            button.Visible = true;
            button.Click += (s, e) => action.Invoke();
        }

        // =========================
        // === Button Logic Below ===
        // =========================
        // Navigation actions
        private void ViewProfile()
        {
            AppStateManager.ChangeState(State.ViewProfile, _currentUser);
        }

        private void CreatePost()
        {
            AppStateManager.ChangeState(State.CreatePost, _currentUser);
        }

        private void SearchUser()
        {
            AppStateManager.ChangeState(State.SearchUser, _currentUser);
        }

        private void CreateUser()
        {
            AppStateManager.ChangeState(State.Register, _currentUser);
        }

        // Post-related actions
        private void ViewAllApprovedPosts()
        {
            var form = new PostForm("Approved", _currentUser);
            form.ShowDialog();
        }

        private void ViewFinishedPosts()
        {
            var form = new PostForm("Finished", _currentUser);
            form.ShowDialog();
        }

        private void ReviewPending()
        {
            var form = new PostForm("Pending", _currentUser);
            form.ShowDialog();
        }

        private void ReviewApproved()
        {
            var form = new PostForm("Approved", _currentUser);
            form.ShowDialog();
        }

        private void ViewMyPosts()
        {
            var form = new PostForm("MyPosts", _currentUser);
            form.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AppStateManager.ChangeState(State.Logout);
        }

        private void viewFinishedPostsButton_Click(object sender, EventArgs e)
        {

        }

        private void buttonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
