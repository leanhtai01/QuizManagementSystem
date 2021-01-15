using QuizManagementSystem.Models;
using QuizManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Presenters
{
    public class PersonalInformationPresenter
    {
        IPersonalInformationView view;

        public PersonalInformationPresenter(IPersonalInformationView view)
        {
            this.view = view;
            //view.LoadInfo += View_LoadInfo;
            //view.Save += View_Save;
            view.GetPrivilege += View_GetPrivilege;
        }

        //private void View_Save(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void View_LoadInfo(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void View_GetPrivilege(object sender, EventArgs e)
        {
            string formName = "PersonalInformationView";

            using (QuizManagementDataContext dataContext = new QuizManagementDataContext())
            {
                view.Privilege = (from p in dataContext.RoleFormControls
                                  where p.roleID == view.RoleID && p.form == formName
                                  select p).ToList();
            }
        }
    }
}
