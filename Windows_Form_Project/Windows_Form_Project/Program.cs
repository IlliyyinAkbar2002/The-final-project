using System;
using System.Windows.Forms;
using Windows_Form_Project.Utils;

namespace Windows_Form_Project
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start with LandingForm using AppStateManager
            AppStateManager.ChangeState(State.Home);
            
            AppStateManager.Logout(); // optional safety net

            Application.Run(AppStateManager.CurrentForm);
        }
    }
}
