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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
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
    }
}
