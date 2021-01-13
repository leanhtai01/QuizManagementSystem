using QuizManagementSystem.HelperClasses;
using QuizManagementSystem.Models;
using QuizManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Presenters
{
    public class LoginPresenter
    {
        ILoginView view;

        public LoginPresenter(ILoginView view)
        {
            this.view = view;
            view.Authenticate += View_Authenticate;
        }

        private void View_Authenticate(object sender, EventArgs e)
        {
            view.RoleID = -1;

            using (QuizManagementDataContext dataContext = new QuizManagementDataContext())
            {
                if (dataContext.Users.SingleOrDefault(user => user.username.Equals(view.LoginUser.username)) != null)
                {
                    // get salted password from database
                    string saltedPassword = (from user in dataContext.Users
                                             where user.username == view.LoginUser.username
                                             select user.password).FirstOrDefault();

                    // check password
                    EncryptPassword encryptPassword = new EncryptPassword();
                    if (encryptPassword.IsPasswordValid(view.LoginUser.password, saltedPassword))
                    {
                        // get corresponding roleID
                        view.RoleID = (int)dataContext.Users.Where(user => user.username.Equals(view.LoginUser.username)).Select(user => user.roleID).FirstOrDefault();
                    }
                }
            } // end using
        } // end method View_Authenticate
    }
}
