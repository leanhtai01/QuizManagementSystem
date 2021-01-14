using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Views
{
    public interface IChangePasswordView
    {
        string Username { get; set; }
        string Password { get; set; }
        string ReEnterPassword { get; set; }
        bool IsSuccess { get; set; }
        string ResponseMessage { get; set; }
        event EventHandler ChangePassword;
    }
}
