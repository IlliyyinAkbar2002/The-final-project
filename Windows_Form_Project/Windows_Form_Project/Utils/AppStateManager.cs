using System;
using System.Windows.Forms;
using Windows_Form_Project.Forms;
using Windows_Form_Project.Models;
using Windows_Form_Project.Services; // Adjust if your Form folder has a different name

namespace Windows_Form_Project.Utils
{
    public enum State
    {
        Home,
        Login,
        Register,
        MainMenu,
        Logout,

        ViewProfile,
        CreatePost,

    }

    public static class AppStateManager
    {
        public static State CurrentState { get; private set; } 
        public static Form CurrentForm { get; private set; }
        public static User currentUser { get; private set; }
        public static bool IsLoggedIn => currentUser != null;

        public static void ChangeState(State newState, User userContext = null)
        {
            CurrentState = newState;

            // Close current form (if needed)
            if (CurrentForm != null && !CurrentForm.IsDisposed)
            {
                CurrentForm.Hide();
            }

            // Load new form depending on state
            switch (newState)
            {
                case State.Home:
                    CurrentForm = new LandingPageForm();
                    break;

                case State.Login:
                    CurrentForm = new LoginForm(UserManager.GetInstance());
                    break;

                case State.Register:
                    CurrentForm = new RegisterForm(UserManager.GetInstance());
                    break;

                case State.MainMenu:

                    if (userContext == null)
                    {
                        MessageBox.Show("MainMenu requires a logged-in user.");
                        return;
                    }

                    currentUser = userContext;
                    CurrentForm = new MainMenuForm(userContext, UserManager.GetInstance());
                    break;

                case State.Logout:
                    currentUser = null;
                    ChangeState(State.Home); // Go back to Home screen on logout
                    return;

                case State.ViewProfile:
                    CurrentForm = new ViewProfileForm(currentUser, UserManager.GetInstance());
                    CurrentForm.Show();

                    return;

                case State.CreatePost:
                    if (currentUser == null)
                    {
                        MessageBox.Show("You must be logged in to create a post.");
                        return;
                    }
                    CurrentForm = new CreatePostForm(currentUser); // Pass username
                    break;


                default:
                    MessageBox.Show("Invalid state.");
                    return;
            }

            CurrentForm.Show();
        }
        public static User GetCurrentUser() => currentUser;

        public static void Logout()
        {
            currentUser = null;
        }

    }
}

