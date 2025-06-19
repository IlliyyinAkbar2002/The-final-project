using System;
using System.Windows.Forms;
using Windows_Form_Project.Utils;

namespace Windows_Form_Project.Forms
{
    public partial class LandingPageForm : Form
    {
        public LandingPageForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            AppStateManager.ChangeState(State.Login);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            AppStateManager.ChangeState(State.Register);
        }

        private void LandingPageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
