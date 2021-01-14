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
    public class ChangePasswordPresenter
    {
        IChangePasswordView view;

        public ChangePasswordPresenter(IChangePasswordView view)
        {
            this.view = view;
            view.ChangePassword += View_ChangePassword;
        }

        private void View_ChangePassword(object sender, EventArgs e)
        {
            if (view.Password != view.ReEnterPassword)
            {
                view.IsSuccess = false;
                view.ResponseMessage = "Passwords didn't match. Try again.";
            }
            else
            {
                using (QuizManagementDataContext dataContext = new QuizManagementDataContext())
                {
                    User user = dataContext.Users.FirstOrDefault(u => u.username.Equals(view.Username));
                    EncryptPassword encryptPassword = new EncryptPassword();

                    user.password = encryptPassword.GetSaltedPassword(view.Password);
                    dataContext.SubmitChanges();

                    view.IsSuccess = true;
                    view.ResponseMessage = "Password changed successfully!";
                }
            }
        } // end method View_ChangePassword
    }
}
