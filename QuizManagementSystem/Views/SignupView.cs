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
    public partial class SignupView : Form, ISignupView
    {
        public User AddedUser { get; set; }
        public string Password { get; set; }
        public string ReEnterPassword { get; set; }
        public string ID { get; set; }
        public List<RoleForSignup> ListRole { get; set; }
        public int DefaultRole { get; set; }
        public string ResponseMessage { get; set; }

        public event EventHandler GetRole;
        public event EventHandler CreateUser;

        public SignupView()
        {
            InitializeComponent();

            SignupPresenter presenter = new SignupPresenter(this);

            AcceptButton = buttonCreate;

            Load += (_, e) =>
            {
                GetRole?.Invoke(this, e);
                LoadComboBoxRole();
            };

            InitControls();
        }

        private void InitControls()
        {
            InitTextBoxUsername();
            InitTextBoxPassword();
            InitTextBoxReEnterPassword();
            InitTextBoxID();
            InitButtonCreate();
            InitButtonCancel();
        }

        private void InitTextBoxUsername()
        {
            textBoxUsername.TextChanged += TextBox_TextChanged;
        }

        private void InitTextBoxPassword()
        {
            textBoxPassword.TextChanged += TextBox_TextChanged;
        }

        private void InitTextBoxReEnterPassword()
        {
            textBoxReEnterPassword.TextChanged += TextBox_TextChanged;
        }

        private void LoadComboBoxRole()
        {
            comboBoxRole.DataSource = ListRole;
            comboBoxRole.ValueMember = "roleID";
            comboBoxRole.DisplayMember = "description";
            comboBoxRole.SelectedValue = DefaultRole;
        }

        private void InitTextBoxID()
        {
            textBoxID.TextChanged += TextBox_TextChanged;
        }

        private void InitButtonCreate()
        {
            buttonCreate.Enabled = false;

            buttonCreate.Click += (_, e) =>
            {
                // pass data to presenter
                Password = textBoxPassword.Text;
                ReEnterPassword = textBoxReEnterPassword.Text;
                ID = textBoxID.Text;
                AddedUser = GetUserFromUI();

                CreateUser?.Invoke(this, e);

                MessageBox.Show(ResponseMessage);
            };
        }

        private void InitButtonCancel()
        {
            buttonCancel.Click += (_, e) =>
            {
                this.Close();
            };
        }

        /// <summary>
        /// Collect input data
        /// </summary>
        /// <returns></returns>
        private User GetUserFromUI()
        {
            return new User
            {
                username = textBoxUsername.Text,
                roleID = (int)comboBoxRole.SelectedValue
            };
        }

        /// <summary>
        /// Disable Button Create if any TextBox is empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            buttonCreate.Enabled = true;

            foreach (TextBox textBox in tableLayoutPanel1.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(textBox.Text.Trim()))
                {
                    buttonCreate.Enabled = false;
                    break;
                }
            }
        }
    }
}
