using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Form_Project.Models;
using Windows_Form_Project.Services;

namespace Windows_Form_Project.Forms
{
    public partial class ViewProfileForm : Form
    {
        private readonly User currentUser;
        private readonly UserManager userManager;
        public ViewProfileForm(User user, UserManager userManager)
        {
            this.currentUser = user;
            this.userManager = userManager;

            InitializeComponent(); // Always call this first!

            // Now set the data
            PopulateProfileFields();
        }


        private void PopulateProfileFields()
        {
            textBox1.Text = currentUser.Username;
            textBox2.Text = currentUser.Password;
            textBox3.Text = currentUser.Nama;
            textBox4.Text = currentUser.Role.ToString();
            textBox5.Text = currentUser.NIK;
            textBox6.Text = currentUser.RT;
            textBox7.Text = currentUser.RW;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
