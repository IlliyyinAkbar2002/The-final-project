using System;
using System.Windows.Forms;
using Windows_Form_Project.Models;
using Windows_Form_Project.Services;
using Windows_Form_Project.Utils;

namespace Windows_Form_Project.Forms
{
    public partial class ViewProfileForm : Form
    {
        private readonly User _userToEdit;
        private readonly UserManager _userManager;
        private readonly User _currentSessionUser;

        public ViewProfileForm(User userToEdit, UserManager userManager, User currentSessionUser = null)
        {
            _userToEdit = userToEdit;
            _userManager = userManager;
            _currentSessionUser = currentSessionUser;

            InitializeComponent();
            PopulateProfileFields();
        }

        private void PopulateProfileFields()
        {
            textBox1.Text = _userToEdit.Username;
            textBox2.Text = _userToEdit.Password;
            textBox3.Text = _userToEdit.Nama;

            // Populate the ComboBox with Role enum names
            comboBoxRole.Items.Clear();
            comboBoxRole.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBoxRole.SelectedItem = _userToEdit.Role.ToString();
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;

            textBox5.Text = _userToEdit.NIK;
            textBox6.Text = _userToEdit.RT;
            textBox7.Text = _userToEdit.RW;

            // 🔐 Disable role dropdown if the current user is not admin
            if (_currentSessionUser.Role != Role.Admin)
            {
                comboBoxRole.Enabled = false;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _userToEdit.Username = textBox1.Text;
            _userToEdit.Password = textBox2.Text;
            _userToEdit.Nama = textBox3.Text;

            if (_currentSessionUser.Role == Role.Admin && comboBoxRole.SelectedItem != null)
            {
                if (Enum.TryParse(comboBoxRole.SelectedItem.ToString(), out Role parsedRole))
                {
                    _userToEdit.Role = parsedRole;
                }
            }

            _userToEdit.NIK = textBox5.Text;
            _userToEdit.RT = textBox6.Text;
            _userToEdit.RW = textBox7.Text;

            // ✅ Save updated user list to file
            _userManager.SaveChanges();

            MessageBox.Show("User profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            // Go back to main menu only if called from current user
            if (_currentSessionUser != null)
            {
                AppStateManager.ChangeState(State.MainMenu, _currentSessionUser);
            }
        }

        private void ViewProfileForm_Load(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
