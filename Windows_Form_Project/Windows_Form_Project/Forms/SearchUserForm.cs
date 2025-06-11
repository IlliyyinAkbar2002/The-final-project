using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Windows_Form_Project.Models;
using Windows_Form_Project.Services;


namespace Windows_Form_Project.Forms
{
    public partial class SearchUserForm : Form
    {
        private List<User> allUsers = new();
        private readonly User currentUser;
        private readonly UserManager userManager;
        private readonly User currentSessionUser;

        public SearchUserForm(User currentUser, UserManager userManager, User currentSessionUser = null)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.userManager = userManager;
            this.currentSessionUser = currentSessionUser;

            // load user list, setup event handlers, etc.
        }





        private void SearchUser_Load(object sender, EventArgs e)
        {
            allUsers = userManager.GetAllUsers();
            comboBoxSearchBy.SelectedIndex = 0; // Default search category
            LoadDataGrid(allUsers);
        }

        private void LoadDataGrid(List<User> users)
        {
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = users
                .Select(u => new
                {
                    u.Username,
                    u.Nama,
                    u.NIK,
                    u.RT,
                    u.RW,
                    Role = u.Role.ToString()
                })
                .ToList();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text.Trim().ToLower();
            string filter = comboBoxSearchBy.SelectedItem?.ToString() ?? "Username";

            var filtered = allUsers.Where(u =>
            {
                return filter switch
                {
                    "Username" => u.Username.ToLower().Contains(keyword),
                    "Nama" => u.Nama.ToLower().Contains(keyword),
                    "RT" => u.RT.ToLower().Contains(keyword),
                    "RW" => u.RW.ToLower().Contains(keyword),
                    "NIK" => u.NIK.ToLower().Contains(keyword),
                    _ => false,
                };
            }).ToList();

            LoadDataGrid(filtered);
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewUsers.Rows.Count)
            {
                string selectedUsername = dataGridViewUsers.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                var selectedUser = userManager.GetUserByUsername(selectedUsername);

                if (selectedUser != null)
                {
                    MessageBox.Show(
                        $"👤 Username: {selectedUser.Username}\n" +
                        $"🧑 Nama: {selectedUser.Nama}\n" +
                        $"🆔 NIK: {selectedUser.NIK}\n" +
                        $"🏘️ RT: {selectedUser.RT} | RW: {selectedUser.RW}\n" +
                        $"🔑 Role: {selectedUser.Role}",
                        "User Details",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void buttonEditSelected_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow != null)
            {
                string selectedUsername = dataGridViewUsers.CurrentRow.Cells["Username"].Value.ToString();
                var selectedUser = userManager.GetUserByUsername(selectedUsername);

                if (selectedUser != null)
                {
                    // Optional: Pass in logged-in user if needed
                    var viewProfileForm = new ViewProfileForm(selectedUser, userManager, currentUser);
                    viewProfileForm.ShowDialog(); // or .Show() if you prefer non-blocking
                }
            }
            else
            {
                MessageBox.Show("Please select a user from the table first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();


        }
    }
}
