using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Form_Project.Services;
using Windows_Form_Project.Utils;

namespace Windows_Form_Project.Forms
{
    public partial class LandingPageForm : Form
    {
        public LandingPageForm()
        {
            InitializeComponent();
        }

        private void LandingPageForm_Load(object sender, EventArgs e)
        {

        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            AppStateManager.ChangeState(State.Login);
            //this.Hide(); // Optionally hide it until Login completes
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            AppStateManager.ChangeState(State.Register);
            //this.Hide();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
