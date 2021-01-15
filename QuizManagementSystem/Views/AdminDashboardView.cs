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
    public partial class AdminDashboardView : Form, IAdminDashboardView
    {
        public string Username { get; set; }
        public int RoleID { get; set; }
        public List<RoleFormControl> Privilege { get; set; }

        public event EventHandler GetPrivilege;

        public AdminDashboardView(string username, int roleID)
        {
            InitializeComponent();

            Username = username;
            RoleID = roleID;

            AdminDashboardPresenter presenter = new AdminDashboardPresenter(this);

            Load += AdminDashboardView_Load;
        }

        private void AdminDashboardView_Load(object sender, EventArgs e)
        {
            GetPrivilege?.Invoke(this, e);

            // setup for based on user role
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
        }
    }
}
