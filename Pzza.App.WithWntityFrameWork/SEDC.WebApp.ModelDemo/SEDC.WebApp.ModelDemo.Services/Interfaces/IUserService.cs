using SEDC.WebApp.ModelDemo.PresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.WebApp.ModelDemo.Services.Interfaces
{
    public interface IUserService
    {
        List<UserVM> GetAllUsers();
        List<UserVM> GetUsersByName(string name);
        string CreateNewUser(UserVM model);
        string DeleteExistingUser(int id);
    }
}
