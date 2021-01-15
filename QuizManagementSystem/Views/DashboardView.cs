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
    public partial class DashboardView : Form, IDashboardView
    {
        public string Username { get; set; }
        public int RoleID { get; set; }
        public List<RoleFormControl> Privilege { get; set; }

        public event EventHandler GetPrivilege;

        public DashboardView(string username, int roleID)
        {
            InitializeComponent();

            Username = username;
            RoleID = roleID;

            DashboardPresenter presenter = new DashboardPresenter(this);

            Load += DashboardView_Load;
            buttonPersonalInfo.Click += (_, e) =>
            {
                PersonalInformationView personalInformationView = new PersonalInformationView(Username, RoleID);

                personalInformationView.ShowDialog();
            };
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {
            GetPrivilege?.Invoke(this, e);

            // setup form based on user's role
            SetupButton();
        } // end method NonAdminDashboardView_Load

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
