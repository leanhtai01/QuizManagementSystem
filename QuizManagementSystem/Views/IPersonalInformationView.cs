using QuizManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Views
{
    public interface IPersonalInformationView
    {
        string Username { get; set; }
        int RoleID { get; set; }
        string Role { get; set; }
        string ID { get; set; }
        string RealName { get; set; }
        string Class { get; set; }
        DateTime DateOfBirth { get; set; }
        List<RoleFormControl> Privilege { get; set; }
        event EventHandler LoadInfo;
        event EventHandler Save;
        event EventHandler GetPrivilege;
    }
}
