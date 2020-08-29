using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET.MVCHomeWork_PizzaApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.MVCHomeWork_PizzaApp.Controllers
{
    [Route("Pizza")]
    public class PizzaController : Controller
    {
        [Route("start")]
        public IActionResult Index()
        {
            var pizza = PizzaDB.pizzas;
            
            return View(pizza);
        }

        [Route("details/{id:int}")]
        public IActionResult PizzaDetails(int id)
        {
            PizzaModels model = PizzaDB.pizzas.SingleOrDefault(p => p.Id == id);
            
            return View(model);
        }

        [HttpGet]
        [Route("CreatePizza")]
        public IActionResult CreatePizza()
        {
           
           ViewData["Message"] = "Create the pizza that is most desired by your customers";
            
            return View();
        }
        
        [HttpPost]
        [Route("CreatePizza")]
        public IActionResult CreatePizza(PizzaModels model)
        {
            PizzaModels pizza = new PizzaModels()
            {
                Name = model.Name,
                Ingredients = model.Ingredients,
                Size = model.Size,
                Price = model.Price,
                Currency = model.Currency,
                Id = PizzaDB.pizzas.Count + 1

            };            
                PizzaDB.pizzas.Add(pizza);
                return RedirectToAction("Index");                    
        }

        [HttpGet]
        [Route("delete/{id:int}")]
        public IActionResult DeletePizza(int id)
        {
            PizzaModels models = PizzaDB.pizzas.SingleOrDefault(p => p.Id == id);           
            return View(models);
        }

        [HttpPost]
        [Route("delete/{id:int}")]
        public IActionResult DeletePizzaById(int id)
        {
            PizzaModels models = PizzaDB.pizzas.SingleOrDefault(p => p.Id == id);
            PizzaDB.pizzas.Remove(models);
            return RedirectToAction("Index");
        }
    }
}
