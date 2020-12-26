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
           bool isPassNotNull;
           public LoginPresenter(ILoginView v)
           {
                this.view = v;
                v.LoginUser += V_LoginUser;        
           }
       
        private void V_LoginUser(object sender, EventArgs e)
        {
            CheckUserExist();
            using (QuizManagementDataContext dataContext = new QuizManagementDataContext())
            {
                // select password from user              
                var passwordQuery =
                    (from user in dataContext.Users
                     where user.username == view.Username
                     select user.password).Single();

                if (passwordQuery == "")
                {
                    // encrypt password
                    EncryptPassword encryptpassword = new EncryptPassword();
                    // 
                    string passHash = encryptpassword.GetSaltedPassword(view.Username);

                    // Query the database for the row to be updated.
                    var query =
                    from us in dataContext.Users
                    where us.username == view.Username
                    select us;

                    // Execute the query, and change the column values
                    // you want to change.
                    foreach (User us in query)
                    {
                        us.password = passHash;
                        // Insert any additional changes to column values.                      
                    }
                    // insert user to database
                    
                    dataContext.SubmitChanges();

                    isLoginUser = true;
                    isPassNotNull = true;
                }
                else
                {
                    EncryptPassword encryptPassword = new EncryptPassword();
                    if (encryptPassword.IsPasswordValid(view.Password, passwordQuery))
                    {
                        isLoginUser = true;
                        isPassNotNull = false;
                    }
                    else
                    {
                        isLoginUser = false;
                    }
                }
                
            }
            if (isLoginUser == true && isPassNotNull == true)
            {
                view.ResponseMessage = "Password changed is: Username";
            }
            else if(isLoginUser == true && isPassNotNull == false)
            {
                view.ResponseMessage = "Login succesfully!";
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
                    isLoginUser = true;
                }
                else
                {
                    isLoginUser = false;
                }
            }
        }
    }
}
