using QuizManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizManagementSystem.Views
{
    public interface ISignupView
    {
        User AddedUser { get; set; }
        string Password { get; set; }
        string ReEnterPassword { get; set; }
        string ID { get; set; }
        List<RoleForSignup> ListRole { get; set; }
        int DefaultRole { get; set; }
        string ResponseMessage { get; set; }
        event EventHandler GetRole;
        event EventHandler CreateUser;
    }
}
