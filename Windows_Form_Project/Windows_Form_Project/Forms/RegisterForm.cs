using System;
using System.Windows.Forms;
using Windows_Form_Project.Models;
using Windows_Form_Project.Services;
using Windows_Form_Project.Utils;

namespace Windows_Form_Project.Forms
{
    public partial class RegisterForm : Form
    {
        private UserManager userManager;
        private Form landingPage;

        public RegisterForm(UserManager userManager)
        {
            InitializeComponent();
            this.userManager = userManager;
            this.landingPage = landingPage;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string nama = namaTextBox.Text.Trim();
            string nik = nikTextBox.Text.Trim();
            string rt = rtTextBox.Text.Trim();
            string rw = rwTextBox.Text.Trim();

            Role role = Role.Masyarakat;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(nik))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (userManager.GetUserByUsername(username) != null)
            {
                MessageBox.Show("Username is already taken.");
                return;
            }

            if (userManager.GetUserByNIK(nik) != null)
            {
                MessageBox.Show("NIK is already registered.");
                return;
            }

            try
            {
                userManager.Register(username, password, role, nama, nik, rt, rw);
                MessageBox.Show("Registration successful!");
                this.Close();
                AppStateManager.ChangeState(State.Home);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during registration: " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AppStateManager.ChangeState(State.Home);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
