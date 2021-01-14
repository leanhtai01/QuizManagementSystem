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
    public partial class ChangePasswordView : Form, IChangePasswordView
    {
        ErrorProvider errorProvider;
        public string Username { get; set; }
        public string Password { get; set; }
        public string ReEnterPassword { get; set; }
        public bool IsSuccess { get; set; }
        public string ResponseMessage { get; set; }

        public event EventHandler ChangePassword;

        public ChangePasswordView(string username)
        {
            InitializeComponent();

            ChangePasswordPresenter presenter = new ChangePasswordPresenter(this);
            
            errorProvider = new ErrorProvider();
            Username = username;
            AcceptButton = buttonChange;

            InitTextBoxPassword();
            InitTextBoxReEnterPassword();
            InitButtonChange();
            InitButtonCancel();
        }

        private void InitTextBoxReEnterPassword()
        {
            textBoxReEnterPassword.TextChanged += TextBox_TextChanged;
            textBoxReEnterPassword.Validating += TextBoxReEnterPassword_Validating;
        }

        private void TextBoxReEnterPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPassword.Text) && !string.IsNullOrEmpty(textBoxReEnterPassword.Text))
            {
                if (textBoxPassword.Text != textBoxReEnterPassword.Text)
                {
                    errorProvider.SetError(textBoxReEnterPassword, "Passwords didn't match. Try again.");
                }
            }
        }

        private void InitTextBoxPassword()
        {
            textBoxPassword.TextChanged += TextBox_TextChanged;
        }

        private void InitButtonChange()
        {
            buttonChange.Enabled = false;

            buttonChange.Click += (_, e) =>
            {
                CollectInputData();
                ChangePassword?.Invoke(this, e);

                if (IsSuccess)
                {
                    MessageBox.Show(ResponseMessage);
                }
            };
        }

        private void CollectInputData()
        {
            Password = textBoxPassword.Text;
            ReEnterPassword = textBoxReEnterPassword.Text;
        }

        private void InitButtonCancel()
        {
            buttonCancel.Click += (_, e) =>
            {
                this.Close();
            };
        }

        /// <summary>
        /// Disable Button Change if any TextBox is empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            buttonChange.Enabled = true;

            foreach (TextBox textBox in tableLayoutPanel1.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(textBox.Text.Trim()))
                {
                    buttonChange.Enabled = false;
                    break;
                }
            }
        }
    }
}
