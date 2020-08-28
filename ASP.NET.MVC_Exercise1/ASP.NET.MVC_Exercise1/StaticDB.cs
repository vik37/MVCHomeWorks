using ASP.NET.MVC_Exercise1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exercise1
{
    public static class StaticDB
    {
        public static List <UserModel> User;
        static StaticDB()
        {
            User = new List<UserModel>()
            {
                new UserModel()
                {
                    id = 1,
                    FirstName = "Viktor",
                    LastName = "Zafirovski",
                    Age = 38
                },
                new UserModel()
                {
                    id = 2,
                    FirstName = "Petar",
                    LastName = "Pan",
                    Age = 25
                },
                new UserModel()
                {
                    id = 3,
                    FirstName = "Dragana",
                    LastName = "Krajova",
                    Age = 49
                }
            };

        }
    }
}
