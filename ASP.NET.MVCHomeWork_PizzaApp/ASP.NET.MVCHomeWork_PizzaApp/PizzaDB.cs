using ASP.NET.MVCHomeWork_PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.MVCHomeWork_PizzaApp
{
    public static class PizzaDB
    {
        public static List<PizzaModels> pizzas;
        static PizzaDB()
        {
            pizzas = new List<PizzaModels>()
            {
                new PizzaModels()
                {
                    Id = 1,
                    Name = "Margarita",
                    //Ingredients = "pellet, yellow cheese",       
                    Ingredients = new List<string>()
                    {
                        "pellet", "yellow cheese"
                    },
                    Size = "Medium",
                    Price = 4.25
                },
                new PizzaModels()
                {
                    Id = 2,
                    Name = "Parmidjana",
                    //Ingredients = "pellet, yellow cheese, prosciutto, parmesan",
                    Ingredients = new List<string>()
                    {
                        "pellet", "yellow cheese", "prosciutto", "parmesan"
                    },
                    Size = "Family",
                    Price = 11.65
                },
                 new PizzaModels()
                {
                    Id = 3,
                    Name = "Kapricioza",
                    //Ingredients = "pellet, yellow cheese, ham, mushrooms",
                    Ingredients = new List<string>()
                    {
                        "pellet", "yellow cheese", "ham", "mushrooms"
                    },
                    Size = "small",
                    Price = 3.19
                },
                new PizzaModels()
                {
                    Id = 4,
                    Name = "Pizza Macedonia",
                    //Ingredients = "pellet, yellow cheese, mushrooms, ham, cheese, vegetables",
                    Ingredients = new List<string>()
                    {
                        "pellet", "yellow cheese", "mushrooms", "ham", "cheese", "vegetables"
                    },
                    Size = "Large",
                    Price = 6.96
                },
                new PizzaModels()
                {
                    Id = 5,
                    Name = "Parmidjana",
                   // Ingredients = "pellet, yellow cheese, prosciutto, parmesan",
                   Ingredients = new List<string>()
                   {
                       "pellet", "yellow cheese", "prosciutto", "parmesan"
                   },
                    Size = "Medium",
                    Price = 4.83
                },
                new PizzaModels()
                {
                    Id = 6,
                    Name = "Closed Pizza",
                    //Ingredients = "ketchup, yellow cheese, ham",
                    Ingredients = new List<string>()
                    {
                        "ketchup", "yellow cheese", "ham"
                    },
                    Size = " / ",
                    Price = 2.09
                }
            };
        }
    }
}
