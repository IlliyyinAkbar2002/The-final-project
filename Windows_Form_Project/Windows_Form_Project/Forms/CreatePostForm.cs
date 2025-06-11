using System;
using System.Windows.Forms;
using Windows_Form_Project.Models;
using Windows_Form_Project.Services;
using Windows_Form_Project.Utils;

namespace Windows_Form_Project.Forms
{
    public partial class CreatePostForm : Form
    {
        private readonly User currentUser;

        public CreatePostForm(User user)
        {
            InitializeComponent();
            currentUser = user;

            button1.Click += ButtonBack_Click;
            button2.Click += ButtonClear_Click;
            button3.Click += ButtonSubmit_Click;
        }


        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text.Trim();
            string content = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Title and content cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var postManager = PostManager.GetInstance();
                postManager.AddPost(title, content, currentUser.Username);
                MessageBox.Show("Post submitted successfully and is now pending approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                AppStateManager.ChangeState(State.MainMenu, AppStateManager.GetCurrentUser());

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to submit post: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void CreatePostForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AppStateManager.ChangeState(State.MainMenu, currentUser);
        }
    }
}
