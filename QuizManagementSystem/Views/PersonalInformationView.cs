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
    public partial class PersonalInformationView : Form, IPersonalInformationView
    {
        public string Username { get; set; }
        public int RoleID { get; set; }
        public string RealName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<RoleFormControl> Privilege { get; set; }

        public event EventHandler LoadInfo;
        public event EventHandler Save;
        public event EventHandler GetPrivilege;

        public PersonalInformationView(string username, int roleID)
        {
            InitializeComponent();

            Username = username;
            RoleID = roleID;

            PersonalInformationPresenter presenter = new PersonalInformationPresenter(this);

            Load += PersonalInformationView_Load;
        }

        private void PersonalInformationView_Load(object sender, EventArgs e)
        {
            GetPrivilege?.Invoke(this, e);

            // setup form based on user's role
            SetupButton();
            SetupLabel();
            SetupTextBox();
            SetupDateTimePicker();
        }

        private void SetupDateTimePicker()
        {
            foreach (var privilege in Privilege)
            {
                if (dateTimePickerDateOfBirth.Name == privilege.control)
                {
                    if ((bool)privilege.invisible)
                    {
                        dateTimePickerDateOfBirth.Hide();
                    }

                    if ((bool)privilege.disable)
                    {
                        dateTimePickerDateOfBirth.Enabled = false;
                    }
                }
            }
        }

        private void SetupTextBox()
        {
            foreach (TextBox textBox in tableLayoutPanel1.Controls.OfType<TextBox>())
            {
                foreach (var privilege in Privilege)
                {
                    if (textBox.Name == privilege.control)
                    {
                        if ((bool)privilege.invisible)
                        {
                            textBox.Hide();
                        }

                        if ((bool)privilege.disable)
                        {
                            textBox.Enabled = false;
                        }
                    }
                }
            }
        }

        private void SetupLabel()
        {
            foreach (Label label in tableLayoutPanel1.Controls.OfType<Label>())
            {
                foreach (var privilege in Privilege)
                {
                    if (label.Name == privilege.control)
                    {
                        if ((bool)privilege.invisible)
                        {
                            label.Hide();
                        }

                        if ((bool)privilege.disable)
                        {
                            label.Enabled = false;
                        }
                    }
                }
            }
        }

        private void SetupButton()
        {
            foreach (Button button in tableLayoutPanel1.Controls.OfType<Button>())
            {
                foreach (var privilege in Privilege)
                {
                    if (button.Name == privilege.control)
                    {
                        if ((bool)privilege.invisible)
                        {
                            button.Hide();
                        }

                        if ((bool)privilege.disable)
                        {
                            button.Enabled = false;
                        }
                    }
                }
            }
        } // end method SetupButton
    }
}
