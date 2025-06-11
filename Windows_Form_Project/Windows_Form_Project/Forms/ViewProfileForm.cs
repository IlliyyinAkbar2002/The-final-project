using System;
using System.Windows.Forms;
using Windows_Form_Project.Models;
using Windows_Form_Project.Services;
using Windows_Form_Project.Utils;

namespace Windows_Form_Project.Forms
{
    public partial class ViewProfileForm : Form
    {
        private readonly User userToEdit;
        private readonly UserManager userManager;
        private readonly User currentSessionUser;

        public ViewProfileForm(User userToEdit, UserManager userManager, User currentSessionUser = null)
        {
            this.userToEdit = userToEdit;
            this.userManager = userManager;
            this.currentSessionUser = currentSessionUser;

            InitializeComponent();
            PopulateProfileFields();
        }

        private void PopulateProfileFields()
        {
            textBox1.Text = userToEdit.Username;
            textBox2.Text = userToEdit.Password;
            textBox3.Text = userToEdit.Nama;

            // Populate the ComboBox with Role enum names
            comboBoxRole.Items.Clear(); // Optional: clear existing items to avoid duplicates
            comboBoxRole.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBoxRole.SelectedItem = userToEdit.Role.ToString(); // ✅ Use userToEdit here
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;


            textBox5.Text = userToEdit.NIK;
            textBox6.Text = userToEdit.RT;
            textBox7.Text = userToEdit.RW;

            // Optional: make role not manually editable
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Update user object from form inputs
            userToEdit.Username = textBox1.Text;
            userToEdit.Password = textBox2.Text;
            userToEdit.Nama = textBox3.Text;

            // ✅ Get role from ComboBox
            if (Enum.TryParse(comboBoxRole.SelectedItem.ToString(), out Role parsedRole))
            {
                userToEdit.Role = parsedRole;
            }

            userToEdit.NIK = textBox5.Text;
            userToEdit.RT = textBox6.Text;
            userToEdit.RW = textBox7.Text;

            MessageBox.Show("User profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            // Go back to main menu only if called from current user
            if (currentSessionUser != null)
            {
                AppStateManager.ChangeState(State.MainMenu, currentSessionUser);
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
