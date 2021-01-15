using QuizManagementSystem.Models;
using QuizManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Presenters
{
    public class AdminDashboardPresenter
    {
        IAdminDashboardView view;

        public AdminDashboardPresenter(IAdminDashboardView view)
        {
            this.view = view;
            view.GetPrivilege += View_GetPrivilege;
        }

        private void View_GetPrivilege(object sender, EventArgs e)
        {
            string formName = "NonAdminDashboardView";

            using (QuizManagementDataContext dataContext = new QuizManagementDataContext())
            {
                view.Privilege = (from p in dataContext.RoleFormControls
                                  where p.roleID == view.RoleID && p.form == formName
                                  select p).ToList();
            }
        }
    }
}
