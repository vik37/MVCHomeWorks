using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Enums;
using SEDC.WebApp.ModelDemo.Services.Interfaces;

namespace SEDC.WebApp.ModelDemo.Controllers
{
    public class HomeController : Controller
    {
        private IPizzaService _pizzaService;
        public HomeController(IPizzaService pizzas)
        {
            _pizzaService = pizzas;
        }
        public IActionResult Pizza()
        {
            
            ViewBag.Pizza = "PIZZA";
            ViewBag.Viktorius = "VIKTORIUS";
            return View();
        }

        
        public IActionResult Index()
        {
             
            ViewData["Heading"] = "Pizzas menu";
            ViewBag.Title = "Welcome to our pizza app!";
            var allPizzas = _pizzaService.GetAllPizzas();
            ViewBag.small = allPizzas.Select(p => p.Size.GetType());

            // How we map list of Pizza (domain model) to list of PizzaVM (viewModel)
            return View(allPizzas);
        }

        public IActionResult PizzaDetails(int id)
        {
            var pizza = _pizzaService.GetPizzaById(id);
            var allPizzas = _pizzaService.GetAllPizzas().Select(p => p.Id).ToList();
            int maxPizzaId = allPizzas.Max();
            int minPizzaId = allPizzas.Min();
            if (pizza.Id == maxPizzaId)
            {
                ViewBag.isHideBtnRight = "";
            }
            if (pizza.Id == minPizzaId)
            {
                ViewBag.isHideBtnLeft = "";
            }
            
            return View(pizza);
        }
        public IActionResult PizzaSize(PizzaSize pizzaSize)
        {
            var pizza = _pizzaService.GetPizzasBySize(pizzaSize);
            //ViewBag.Size = pizzaSize;
            return View(pizza);
        }
       

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

    }
}
