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
            view.LoadInfo += View_LoadInfo;
            //view.Save += View_Save;
            view.GetPrivilege += View_GetPrivilege;
        }

        //private void View_Save(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void View_LoadInfo(object sender, EventArgs e)
        {
            using (QuizManagementDataContext dataContext = new QuizManagementDataContext())
            {
                view.Role = (from r in dataContext.Roles
                             where r.roleID == view.RoleID
                             select r.description).FirstOrDefault();

                switch (view.RoleID)
                {
                    case 1: // teacher
                        Teacher teacher = (from tu in dataContext.TeacherUsers
                                           join t in dataContext.Teachers on tu.teacherID equals t.teacherID
                                           where tu.username == view.Username
                                           select t).FirstOrDefault();
                        view.ID = teacher.teacherID;
                        view.RealName = teacher.name;
                        view.DateOfBirth = (DateTime)teacher.dateOfBirth;
                        break;
                    case 2: // student
                        Student student = (from su in dataContext.StudentUsers
                                           join s in dataContext.Students on su.studentID equals s.studentID
                                           where su.username == view.Username
                                           select s).FirstOrDefault();
                        view.ID = student.studentID;
                        view.RealName = student.name;
                        view.DateOfBirth = (DateTime)student.dateOfBirth;
                        view.Class = (from c in dataContext.Classes
                                      where c.classID == student.classID
                                      select c.name).FirstOrDefault();
                        break;
                                 
                }
            }
        }

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
