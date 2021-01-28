using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP.NET.MVC.MODEL.DEMO.Models;
using ASP.NET.MVC.MODEL.DEMO.Models.Domain;
using ASP.NET.MVC.MODEL.DEMO.Models.ViewModels;

namespace ASP.NET.MVC.MODEL.DEMO.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            User person = new User() { FirstName = "Bob", LastName = "Bobsky", Address = "Bob Street", Phone = 0800234234 };
            Order order = new Order() { Id = 12, User = person, Pizza = "Kapri", Price = 10.5 };
            
            ViewBag.Order = "ORDER";
            return View(order);
        }
        public IActionResult Details()
        {
            User person = new User() { FirstName = "Bob", LastName = "Bobsky", Address = "Bob Street", Phone = 0800234234 };
            Order order = new Order() { Id = 12, User = person, Pizza = "Kapri", Price = 10.5 };
            OrderDetailsVM orderDetails = new OrderDetailsVM()
            {
                Id = order.Id,
                FullName = $"{person.FirstName} {person.LastName}",
                Address = person.Address,
                Contact = person.Phone,
                Pizza = order.Pizza,
                Price = order.Price
            };
            return View(orderDetails);
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
