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
        User LoginUser { get; set; }
        bool IsSuccess { get; set; }
        event EventHandler Authenticate;
    }
}
