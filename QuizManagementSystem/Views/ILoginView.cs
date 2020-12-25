using QuizManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Views
{
    public interface ILoginView
    {    
        string Username { get; set; }
        string Password { get; set; }
        string ResponseMessage { get; set; }

        event EventHandler LoginUser;
    }
}
