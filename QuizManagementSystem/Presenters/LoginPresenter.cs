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
            view.IsSuccess = false;

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
                        view.IsSuccess = true;
                    }
                }
            } // end using
        } // end method View_Authenticate
    }
}
