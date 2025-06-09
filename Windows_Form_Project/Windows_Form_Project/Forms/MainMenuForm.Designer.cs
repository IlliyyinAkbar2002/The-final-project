namespace Windows_Form_Project.Forms
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        // 👇 Controls
        private Label welcomeLabel;
        private Button viewProfileButton;
        private Button createPostButton;
        private Button searchUserButton;
        private Button createUserButton;
        private Button viewAllPostsButton;
        private Button approveRejectButton;
        private Button changeStatusButton;
        private Button deletePostButton;
        private Button logoutButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            welcomeLabel = new Label();
            viewProfileButton = new Button();
            createPostButton = new Button();
            searchUserButton = new Button();
            createUserButton = new Button();
            viewAllPostsButton = new Button();
            approveRejectButton = new Button();
            changeStatusButton = new Button();
            deletePostButton = new Button();
            logoutButton = new Button();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            welcomeLabel.Location = new Point(30, 20);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(136, 21);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome, [User]";
            welcomeLabel.Click += welcomeLabel_Click;
            // 
            // viewProfileButton
            // 
            viewProfileButton.Location = new Point(30, 60);
            viewProfileButton.Name = "viewProfileButton";
            viewProfileButton.Size = new Size(200, 30);
            viewProfileButton.TabIndex = 1;
            viewProfileButton.Text = "View Profile";
            viewProfileButton.UseVisualStyleBackColor = true;
            // 
            // createPostButton
            // 
            createPostButton.Location = new Point(30, 100);
            createPostButton.Name = "createPostButton";
            createPostButton.Size = new Size(200, 30);
            createPostButton.TabIndex = 2;
            createPostButton.Text = "Create Post";
            createPostButton.UseVisualStyleBackColor = true;
            // 
            // searchUserButton
            // 
            searchUserButton.Location = new Point(30, 140);
            searchUserButton.Name = "searchUserButton";
            searchUserButton.Size = new Size(200, 30);
            searchUserButton.TabIndex = 3;
            searchUserButton.Text = "Search User";
            searchUserButton.UseVisualStyleBackColor = true;
            // 
            // createUserButton
            // 
            createUserButton.Location = new Point(30, 180);
            createUserButton.Name = "createUserButton";
            createUserButton.Size = new Size(200, 30);
            createUserButton.TabIndex = 4;
            createUserButton.Text = "Create User";
            createUserButton.UseVisualStyleBackColor = true;
            // 
            // viewAllPostsButton
            // 
            viewAllPostsButton.Location = new Point(30, 220);
            viewAllPostsButton.Name = "viewAllPostsButton";
            viewAllPostsButton.Size = new Size(200, 30);
            viewAllPostsButton.TabIndex = 5;
            viewAllPostsButton.Text = "View All Posts";
            viewAllPostsButton.UseVisualStyleBackColor = true;
            // 
            // approveRejectButton
            // 
            approveRejectButton.Location = new Point(30, 260);
            approveRejectButton.Name = "approveRejectButton";
            approveRejectButton.Size = new Size(200, 30);
            approveRejectButton.TabIndex = 6;
            approveRejectButton.Text = "Approve/Reject";
            approveRejectButton.UseVisualStyleBackColor = true;
            // 
            // changeStatusButton
            // 
            changeStatusButton.Location = new Point(30, 300);
            changeStatusButton.Name = "changeStatusButton";
            changeStatusButton.Size = new Size(200, 30);
            changeStatusButton.TabIndex = 7;
            changeStatusButton.Text = "Change Status";
            changeStatusButton.UseVisualStyleBackColor = true;
            // 
            // deletePostButton
            // 
            deletePostButton.Location = new Point(30, 340);
            deletePostButton.Name = "deletePostButton";
            deletePostButton.Size = new Size(200, 30);
            deletePostButton.TabIndex = 8;
            deletePostButton.Text = "Delete Post";
            deletePostButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(30, 390);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(200, 30);
            logoutButton.TabIndex = 9;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // MainMenuForm
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(welcomeLabel);
            Controls.Add(viewProfileButton);
            Controls.Add(createPostButton);
            Controls.Add(searchUserButton);
            Controls.Add(createUserButton);
            Controls.Add(viewAllPostsButton);
            Controls.Add(approveRejectButton);
            Controls.Add(changeStatusButton);
            Controls.Add(deletePostButton);
            Controls.Add(logoutButton);
            Name = "MainMenuForm";
            Text = "Main Menu";
            Load += MainMenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
