using QuizManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Views
{
    public interface IAdminDashboardView
    {
        string Username { get; set; }
        int RoleID { get; set; }
        List<RoleFormControl> Privilege { get; set; }
        event EventHandler GetPrivilege;
    }
}
