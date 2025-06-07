using System;
using System.Windows.Forms;
using Windows_Form_Project.Services;
using Windows_Form_Project.Models;
using Windows_Form_Project.Utils;

namespace Windows_Form_Project.Forms
{
    public partial class LoginForm : Form
    {
        private UserManager userManager;
        private LandingPageForm landingPageForm;

        public LoginForm(UserManager userManager, LandingPageForm landingPageForm)
        {
            InitializeComponent();
            this.userManager = userManager;
            this.landingPageForm = landingPageForm;
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
                var user = userManager.Authenticate(username, password);
                MessageBox.Show($"Selamat datang, {user.Nama}!");

                // ✅ Automata-based transition
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
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
