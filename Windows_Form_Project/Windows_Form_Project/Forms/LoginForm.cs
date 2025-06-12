using System;
using System.Windows.Forms;
using Windows_Form_Project.Services;
using Windows_Form_Project.Models;
using Windows_Form_Project.Utils;

namespace Windows_Form_Project.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserManager _userManager;

        public LoginForm(UserManager userManager)
        {
            InitializeComponent();
            _userManager = userManager;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong.");
                return;
            }

            try
            {
                var user = _userManager.Authenticate(username, password);
                MessageBox.Show($"Selamat datang, {user.Nama}!");

                AppStateManager.ChangeState(State.MainMenu, user);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AppStateManager.ChangeState(State.Home);
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
