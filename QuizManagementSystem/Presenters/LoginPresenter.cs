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
           bool isLoginUser; 
           public LoginPresenter(ILoginView v)
            {
            this.view = v;
            v.LoginUser += V_LoginUser;
           

           }

       
        private void V_LoginUser(object sender, EventArgs e)
        {
            CheckUserExist();
            if (isLoginUser)
            {
                view.ResponseMessage = "Login successfully!";
            }
            else
                view.ResponseMessage = "Login failed!";
        }
        /// <summary>
        /// check whether user's exits in database
        /// </summary>
        private void CheckUserExist()
        {
            using (QuizManagementDataContext dataContext = new QuizManagementDataContext())
            {
                // check whether Username already exist
                if (dataContext.Users.SingleOrDefault(user => user.username.Equals(view.Username)) != null)
                {
                    // select password from user              
                    var passwordQuery =
                        (from user in dataContext.Users
                         where user.username == view.Username
                         select user.password).Single();


                    EncryptPassword encryptPassword = new EncryptPassword();
                    if (encryptPassword.IsPasswordValid(view.Password, passwordQuery))
                    {
                        isLoginUser = true;
                    }
                    else
                    {
                        isLoginUser = false;
                    }
                }
                else
                {
                    isLoginUser = false;
                }
            }
        }
    }
}
