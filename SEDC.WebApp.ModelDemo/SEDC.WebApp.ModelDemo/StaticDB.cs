using SEDC.WebApp.ModelDemo.Models.Domain;
using SEDC.WebApp.ModelDemo.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.WebApp.ModelDemo
{
    public static class StaticDb
    {
        public static List<Order> Orders;
        public static List<Pizza> Menu;
        public static List<User> Users;
        public static List<Store> Store;

        static StaticDb()
        {
            Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    Adress = "Bob Street",
                    Phone = 080012312345
                }
            };
            Menu = new List<Pizza>()
            {
                new Pizza()
                {
                    Id = 1,
                    Name = "Kapri",
                    Price = 7,
                    Size = PizzaSize.Small,
                    Ingredients = new List<string>()
                    {
                        "pellet", "yellow cheese"
                    }
                },
                new Pizza()
                {
                    Id = 2,
                    Name = "Kapri",
                    Price = 8,
                    Size = PizzaSize.Medium,
                    Ingredients = new List<string>()
                    {
                        "pellet", "yellow cheese", "prosciutto", "parmesan"
                    }
                },
                new Pizza()
                {
                    Id = 3,
                    Name = "Kapri",
                    Price = 9,
                    Size = PizzaSize.Family,
                     Ingredients = new List<string>()
                    {
                        "pellet", "yellow cheese", "mushrooms", "ham", "cheese", "vegetables"
                    }
                }
            };
            Orders = new List<Order>()
            {
                //new Order()
                //{
                //    Id = 1,
                //    User = Users[0],
                //    Pizza = Menu[0],
                //    Delivered = false
                //}
                new Order()
                {
                    Id = 1,
                    PizzaId = Users[0].Id,
                    UserId = Menu[0].Id,
                    Delivered = false
                },
                
                new Order()
                {
                    Id = 1,
                    PizzaId = Users[1].Id,
                    UserId = Menu[1].Id,
                    Delivered = true
                },

            };
            Store = new List<Store>()
            {
                new Store()
                {
                    Id = 1,
                    Amount = 16,
                    TypePizza = "Kapri",
                    pizza = Menu[0]
                },
                new Store()
                {
                    Id = 2,
                    Amount = 10,
                    TypePizza = "Kapri",
                    pizza = Menu[1]
                },
                new Store()
                {
                    Id = 3,
                    Amount = 7,
                    TypePizza = "Kapri",
                    pizza = Menu[2]
                },

            };
        }
    }
}
