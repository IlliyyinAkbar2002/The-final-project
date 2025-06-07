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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.viewProfileButton = new System.Windows.Forms.Button();
            this.createPostButton = new System.Windows.Forms.Button();
            this.searchUserButton = new System.Windows.Forms.Button();
            this.createUserButton = new System.Windows.Forms.Button();
            this.viewAllPostsButton = new System.Windows.Forms.Button();
            this.approveRejectButton = new System.Windows.Forms.Button();
            this.changeStatusButton = new System.Windows.Forms.Button();
            this.deletePostButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.Location = new System.Drawing.Point(30, 20);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(150, 21);
            this.welcomeLabel.Text = "Welcome, [User]";
            // 
            // viewProfileButton
            // 
            this.viewProfileButton.Location = new System.Drawing.Point(30, 60);
            this.viewProfileButton.Name = "viewProfileButton";
            this.viewProfileButton.Size = new System.Drawing.Size(200, 30);
            this.viewProfileButton.Text = "View Profile";
            this.viewProfileButton.UseVisualStyleBackColor = true;
            // 
            // createPostButton
            // 
            this.createPostButton.Location = new System.Drawing.Point(30, 100);
            this.createPostButton.Name = "createPostButton";
            this.createPostButton.Size = new System.Drawing.Size(200, 30);
            this.createPostButton.Text = "Create Post";
            this.createPostButton.UseVisualStyleBackColor = true;
            // 
            // searchUserButton
            // 
            this.searchUserButton.Location = new System.Drawing.Point(30, 140);
            this.searchUserButton.Name = "searchUserButton";
            this.searchUserButton.Size = new System.Drawing.Size(200, 30);
            this.searchUserButton.Text = "Search User";
            this.searchUserButton.UseVisualStyleBackColor = true;
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(30, 180);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(200, 30);
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            // 
            // viewAllPostsButton
            // 
            this.viewAllPostsButton.Location = new System.Drawing.Point(30, 220);
            this.viewAllPostsButton.Name = "viewAllPostsButton";
            this.viewAllPostsButton.Size = new System.Drawing.Size(200, 30);
            this.viewAllPostsButton.Text = "View All Posts";
            this.viewAllPostsButton.UseVisualStyleBackColor = true;
            // 
            // approveRejectButton
            // 
            this.approveRejectButton.Location = new System.Drawing.Point(30, 260);
            this.approveRejectButton.Name = "approveRejectButton";
            this.approveRejectButton.Size = new System.Drawing.Size(200, 30);
            this.approveRejectButton.Text = "Approve/Reject";
            this.approveRejectButton.UseVisualStyleBackColor = true;
            // 
            // changeStatusButton
            // 
            this.changeStatusButton.Location = new System.Drawing.Point(30, 300);
            this.changeStatusButton.Name = "changeStatusButton";
            this.changeStatusButton.Size = new System.Drawing.Size(200, 30);
            this.changeStatusButton.Text = "Change Status";
            this.changeStatusButton.UseVisualStyleBackColor = true;
            // 
            // deletePostButton
            // 
            this.deletePostButton.Location = new System.Drawing.Point(30, 340);
            this.deletePostButton.Name = "deletePostButton";
            this.deletePostButton.Size = new System.Drawing.Size(200, 30);
            this.deletePostButton.Text = "Delete Post";
            this.deletePostButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(30, 390);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(200, 30);
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // MainMenuForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.viewProfileButton);
            this.Controls.Add(this.createPostButton);
            this.Controls.Add(this.searchUserButton);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.viewAllPostsButton);
            this.Controls.Add(this.approveRejectButton);
            this.Controls.Add(this.changeStatusButton);
            this.Controls.Add(this.deletePostButton);
            this.Controls.Add(this.logoutButton);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
