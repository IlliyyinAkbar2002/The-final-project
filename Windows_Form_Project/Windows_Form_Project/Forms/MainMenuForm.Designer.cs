namespace Windows_Form_Project.Forms
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

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
        private FlowLayoutPanel buttonPanel;

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
            buttonPanel = new FlowLayoutPanel();
            buttonPanel.SuspendLayout();
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
            viewProfileButton.Location = new Point(3, 3);
            viewProfileButton.Name = "viewProfileButton";
            viewProfileButton.Size = new Size(200, 30);
            viewProfileButton.TabIndex = 0;
            viewProfileButton.Text = "View Profile";
            viewProfileButton.UseVisualStyleBackColor = true;
            // 
            // createPostButton
            // 
            createPostButton.Location = new Point(3, 39);
            createPostButton.Name = "createPostButton";
            createPostButton.Size = new Size(200, 30);
            createPostButton.TabIndex = 1;
            createPostButton.Text = "Create Post";
            createPostButton.UseVisualStyleBackColor = true;
            // 
            // searchUserButton
            // 
            searchUserButton.Location = new Point(3, 75);
            searchUserButton.Name = "searchUserButton";
            searchUserButton.Size = new Size(200, 30);
            searchUserButton.TabIndex = 2;
            searchUserButton.Text = "Search User";
            searchUserButton.UseVisualStyleBackColor = true;
            // 
            // createUserButton
            // 
            createUserButton.Location = new Point(3, 111);
            createUserButton.Name = "createUserButton";
            createUserButton.Size = new Size(200, 30);
            createUserButton.TabIndex = 3;
            createUserButton.Text = "Create User";
            createUserButton.UseVisualStyleBackColor = true;
            // 
            // viewAllPostsButton
            // 
            viewAllPostsButton.Location = new Point(3, 147);
            viewAllPostsButton.Name = "viewAllPostsButton";
            viewAllPostsButton.Size = new Size(200, 30);
            viewAllPostsButton.TabIndex = 4;
            viewAllPostsButton.Text = "View All Posts";
            viewAllPostsButton.UseVisualStyleBackColor = true;
            viewAllPostsButton.Click += viewAllPostsButton_Click;
            // 
            // approveRejectButton
            // 
            approveRejectButton.Location = new Point(3, 183);
            approveRejectButton.Name = "approveRejectButton";
            approveRejectButton.Size = new Size(200, 30);
            approveRejectButton.TabIndex = 5;
            approveRejectButton.Text = "Approve/Reject";
            approveRejectButton.UseVisualStyleBackColor = true;
            // 
            // changeStatusButton
            // 
            changeStatusButton.Location = new Point(3, 219);
            changeStatusButton.Name = "changeStatusButton";
            changeStatusButton.Size = new Size(200, 30);
            changeStatusButton.TabIndex = 6;
            changeStatusButton.Text = "Change Status";
            changeStatusButton.UseVisualStyleBackColor = true;
            // 
            // deletePostButton
            // 
            deletePostButton.Location = new Point(3, 255);
            deletePostButton.Name = "deletePostButton";
            deletePostButton.Size = new Size(200, 30);
            deletePostButton.TabIndex = 7;
            deletePostButton.Text = "Delete Post";
            deletePostButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(30, 370);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(200, 30);
            logoutButton.TabIndex = 9;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // buttonPanel
            // 
            buttonPanel.AutoSize = true;
            buttonPanel.Controls.Add(viewProfileButton);
            buttonPanel.Controls.Add(createPostButton);
            buttonPanel.Controls.Add(searchUserButton);
            buttonPanel.Controls.Add(createUserButton);
            buttonPanel.Controls.Add(viewAllPostsButton);
            buttonPanel.Controls.Add(approveRejectButton);
            buttonPanel.Controls.Add(changeStatusButton);
            buttonPanel.Controls.Add(deletePostButton);
            buttonPanel.FlowDirection = FlowDirection.TopDown;
            buttonPanel.Location = new Point(30, 60);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(206, 300);
            buttonPanel.TabIndex = 1;
            buttonPanel.WrapContents = false;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 450);
            Controls.Add(welcomeLabel);
            Controls.Add(buttonPanel);
            Controls.Add(logoutButton);
            Name = "MainMenuForm";
            Text = "Main Menu";
            Load += MainMenuForm_Load;
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
