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
        public User LoginUser { get; set; }
        public int RoleID { get; set; }

        public event EventHandler Authenticate;

        public LoginView()
        {
            InitializeComponent();

            LoginPresenter presenter = new LoginPresenter(this);

            AcceptButton = buttonLogin;

            InitControls();
        }

        private void InitControls()
        {
            InitTextBoxUsername();
            InitButtonLogin();
            InitButtonSignup();
        }

        private void InitTextBoxUsername()
        {
            textBoxUsername.TextChanged += TextBoxUsername_TextChanged;
        }

        /// <summary>
        /// Disable buttonLogin if textBoxUsername is empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {
            buttonLogin.Enabled = true;

            if (string.IsNullOrEmpty(textBoxUsername.Text.Trim()))
            {
                buttonLogin.Enabled = false;
            }
        }

        private void InitButtonLogin()
        {
            buttonLogin.Enabled = false;

            buttonLogin.Click += (_, e) =>
            {
                LoginUser = GetUserFromUI();

                Authenticate?.Invoke(this, e);

                if (RoleID != -1)
                {
                    MessageBox.Show("Login success!");
                }
                else
                {
                    MessageBox.Show("Login failed!");
                }
            };
        }

        /// <summary>
        /// Initialize buttonSignup
        /// </summary>
        private void InitButtonSignup()
        {
            buttonSignup.Click += (_, e) =>
            {
                SignupView signupView = new SignupView();

                signupView.ShowDialog();
            };
        }

        private User GetUserFromUI()
        {
            return new User
            {
                username = textBoxUsername.Text,
                password = textBoxPassword.Text
            };
        }
    }
}
