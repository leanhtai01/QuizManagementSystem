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
            InitializeButtonSignup();
        }

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
