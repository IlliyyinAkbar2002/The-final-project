namespace Windows_Form_Project.Forms
{
    partial class PostForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewPosts;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnAuthor;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.Button buttonBack;
        // Search TextBox
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostForm));
            listViewPosts = new ListView();
            columnTitle = new ColumnHeader();
            columnAuthor = new ColumnHeader();
            columnDate = new ColumnHeader();
            columnStatus = new ColumnHeader();
            buttonBack = new Button();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            SuspendLayout();
            // 
            // listViewPosts
            // 
            listViewPosts.Columns.AddRange(new ColumnHeader[] { columnTitle, columnAuthor, columnDate, columnStatus });
            listViewPosts.FullRowSelect = true;
            listViewPosts.GridLines = true;
            listViewPosts.Location = new Point(10, 48);
            listViewPosts.MultiSelect = false;
            listViewPosts.Name = "listViewPosts";
            listViewPosts.Size = new Size(504, 336);
            listViewPosts.TabIndex = 0;
            listViewPosts.UseCompatibleStateImageBehavior = false;
            listViewPosts.View = View.Details;
            listViewPosts.ItemActivate += listViewPosts_ItemActivate;
            // 
            // columnTitle
            // 
            columnTitle.Text = "Title";
            columnTitle.Width = 150;
            // 
            // columnAuthor
            // 
            columnAuthor.Text = "Author";
            columnAuthor.Width = 100;
            // 
            // columnDate
            // 
            columnDate.Text = "Created At";
            columnDate.Width = 150;
            // 
            // columnStatus
            // 
            columnStatus.Text = "Status";
            columnStatus.Width = 100;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(10, 390);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(66, 28);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(12, 12);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(393, 23);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(437, 12);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 26);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Search";
            buttonSearch.Click += buttonSearch_Click;
            // 
            // PostForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(524, 430);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonSearch);
            Controls.Add(buttonBack);
            Controls.Add(listViewPosts);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "PostForm";
            Text = "Posts";
            Load += PostForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
