using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET.MVC_Exercise1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.MVC_Exercise1.Controllers
{
        [Route("users")]
    public class UserController : Controller
    {
        [Route("start")]
        public IActionResult Index()
        {
            var users = StaticDB.User;
            return View(users);
        }

        [Route("details/{id:int}")]
        public IActionResult UserDetails(int id)
        {
            UserModel model = StaticDB.User.SingleOrDefault(user => user.id == id);
            return View(model);
        }

        [Route("createUserForm")]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        [Route("CreateNewUser")]
        public IActionResult CreateUser(UserModel model)
        {
            UserModel user = new UserModel()
            {
                id = model.id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age
            };
            StaticDB.User.Add(user);
            return RedirectToAction("Index");
        }

        [Route("delete/{id:int}")]
        public IActionResult DeleteUser(int id)
        {
            //StaticDB.User.Remove(model);
            UserModel model = StaticDB.User.SingleOrDefault(user => user.id == id);
            StaticDB.User.Remove(model);
            return View(model);
            


        }
    }
}
