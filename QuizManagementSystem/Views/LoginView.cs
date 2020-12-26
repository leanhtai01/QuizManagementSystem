using QuizManagementSystem.Models;
using QuizManagementSystem.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizManagementSystem.Views
{
    public partial class LoginView : Form, ILoginView 
    {
        public LoginView()
        {
            InitializeComponent();
            InitializeButtonSignup();

            LoginPresenter  presenter = new LoginPresenter(this);

            AcceptButton = buttonLogin;

            InitControls();
        }

        private void InitControls()
        {
            InitButtonLogin();
        }

        private void InitButtonLogin()
        {
            buttonLogin.Enabled = true;

            buttonLogin.Click += (_, e) =>
            {
                // pass data to presenter
                Password = textBoxPassword.Text;
                Username = textBoxUsername.Text;

                LoginUser?.Invoke(this, e);

                MessageBox.Show(ResponseMessage);
            };
        }     

        public User Login { get; set ; }
        public string Username { get; set ; }
        public string Password { get ; set ; }
        public string ResponseMessage { get ; set; }

        public event EventHandler LoginUser;

        /// <summary>
        /// Initialize buttonSignup
        /// </summary>
        private void InitializeButtonSignup()
        {
            buttonSignup.Click += (_, e) =>
            {
                SignupView signupView = new SignupView();

                signupView.ShowDialog();
            };
        }
    }
}
