using QuizManagementSystem.HelperClasses;
using QuizManagementSystem.Models;
using QuizManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizManagementSystem.Presenters
{
    public class SignupPresenter
    {
        ISignupView view;
        bool isUserCreateable;

        public SignupPresenter(ISignupView view)
        {
            this.view = view;
            view.CreateUser += View_CreateUser;
            view.GetRole += View_GetRole;
        }

        private void View_CreateUser(object sender, EventArgs e)
        {
            CheckUserInfo();
            
            if (isUserCreateable)
            {
                using (QuizManagementDataContext dataContext = new QuizManagementDataContext())
                {
                    // encrypt password
                    EncryptPassword encryptPassword = new EncryptPassword();
                    view.AddedUser.password = encryptPassword.GetSaltedPassword(view.Password);

                    // insert user to database
                    dataContext.Users.InsertOnSubmit(view.AddedUser);

                    // create suitable object base on user'role
                    // insert to appropriate table
                    if (view.AddedUser.roleID == dataContext.RoleForSignups.SingleOrDefault(r => r.description.Equals("Student")).roleID)
                    {
                        StudentUser studentUser = new StudentUser();

                        studentUser.username = view.AddedUser.username;
                        studentUser.studentID = view.ID;

                        dataContext.StudentUsers.InsertOnSubmit(studentUser);
                    }
                    else
                    {
                        TeacherUser teacherUser = new TeacherUser();

                        teacherUser.username = view.AddedUser.username;
                        teacherUser.teacherID = view.ID;

                        dataContext.TeacherUsers.InsertOnSubmit(teacherUser);
                    }

                    dataContext.SubmitChanges();
                } // end using
            } // end outer if
        } // end method View_CreateUser

        private void View_GetRole(object sender, EventArgs e)
        {
            using (QuizManagementDataContext dataContext = new QuizManagementDataContext())
            {
                view.ListRole = dataContext.RoleForSignups.ToList();
                view.DefaultRole = dataContext.RoleForSignups.SingleOrDefault(r => r.description.Equals("Student")).roleID;
            }
        } // end method View_GetRole

        /// <summary>
        /// check whether user's info is valid to insert to database
        /// </summary>
        private void CheckUserInfo()
        {
            isUserCreateable = true;
            view.ResponseMessage = "Account created successfully!";

            using (QuizManagementDataContext dataContext = new QuizManagementDataContext())
            {
                // check whether Username already exist
                if (dataContext.Users.SingleOrDefault(user => user.username.Equals(view.AddedUser.username)) != null)
                {
                    isUserCreateable = false;
                    view.ResponseMessage = "Please use other Username!";
                }
                else if (!view.Password.Equals(view.ReEnterPassword)) // check whether password is the same
                {
                    isUserCreateable = false;
                    view.ResponseMessage = "Two password is not indentical!";
                }
                else // check whether ID exist
                {
                    if (view.AddedUser.roleID == dataContext.RoleForSignups.SingleOrDefault(r => r.description.Equals("Student")).roleID) // user's role is student
                    {
                        if (dataContext.Students.SingleOrDefault(student => student.studentID.Equals(view.ID)) == null)
                        {
                            isUserCreateable = false;
                            view.ResponseMessage = "Student doesn't exist!";
                        }
                        else if (dataContext.StudentUsers.SingleOrDefault(studentUser => studentUser.studentID.Equals(view.ID)) != null)
                        {
                            isUserCreateable = false;
                            view.ResponseMessage = "Student already have an account!";
                        }
                    }
                    else // user's role is teacher
                    {
                        if (dataContext.Teachers.SingleOrDefault(teacher => teacher.teacherID.Equals(view.ID)) == null)
                        {
                            isUserCreateable = false;
                            view.ResponseMessage = "Teacher doesn't exist!";
                        }
                        else if (dataContext.TeacherUsers.SingleOrDefault(teacherUser => teacherUser.teacherID.Equals(view.ID)) != null)
                        {
                            isUserCreateable = false;
                            view.ResponseMessage = "Teacher already have an account!";
                        }
                    } // end inner else
                } // end outer else
            } // end using
        } // end method CheckUserInfo
    }
}
