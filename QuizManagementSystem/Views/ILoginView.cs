using QuizManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Views
{
    interface ILoginView
    {
        User LoginUser { get; set; }
        string ResponseMessage { get; set; }
    }
}
