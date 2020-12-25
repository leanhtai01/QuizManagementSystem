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
            InitTextBoxUsername();
            InitTextBoxPassword();
            InitButtonLogin();
        }

        private void InitButtonLogin()
        {
            buttonLogin.Enabled = false;

            buttonLogin.Click += (_, e) =>
            {
                // pass data to presenter
                Password = textBoxPassword.Text;
                Username = textBoxUsername.Text;

                LoginUser?.Invoke(this, e);

                MessageBox.Show(ResponseMessage);
            };
        }

        private void InitTextBoxPassword()
        {
            textBoxPassword.TextChanged += TextBox_TextChanged;
        }     
        private void InitTextBoxUsername()
        {
            textBoxUsername.TextChanged += TextBox_TextChanged;
        }
        /// <summary>
        /// Disable Button Login if any TextBox is empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
           buttonLogin.Enabled = true;

            foreach (TextBox textBox in tableLayoutPanel1.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(textBox.Text.Trim()))
                {
                    buttonLogin.Enabled = false;
                    break;
                }
            }
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
