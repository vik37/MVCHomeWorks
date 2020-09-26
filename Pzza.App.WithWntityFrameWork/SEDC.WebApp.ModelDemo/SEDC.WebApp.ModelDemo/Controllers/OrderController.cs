using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.WebApp.ModelDemo.DataAccess.DB;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using SEDC.WebApp.ModelDemo.PresentationLayer.ViewModels;
using SEDC.WebApp.ModelDemo.Services.Interfaces;
using SEDC.WebApp.ModelDemo.Services.Services;

namespace SEDC.WebApp.ModelDemo.Controllers
{
    public class OrderController : Controller
    {        
        private IOrderService _orderService;
        private IUserService _userService;
        private IPizzaService _pizzaService;
        public OrderController(IOrderService orderService, IUserService userService,IPizzaService pizzaService)
        {
            _orderService = orderService;
            _userService = userService;
            _pizzaService = pizzaService;
           
        }
        public IActionResult Index(int id, string error)
        {
            ViewBag.Error = error == null ? "" : error;
            var pizza = _pizzaService.GetPizzaById(id);
            var order = new OrderVM() { Pizza = pizza };
            return View(order);
        }
        [HttpPost]
        public IActionResult Index(OrderVM orderModel)
        {
            
            if (string.IsNullOrEmpty(orderModel.User.Address))
            {                
                return RedirectToAction("Index","Order", new { id = orderModel.Pizza.Id, error = "All fields requied"});
            }

            var pizza = _pizzaService.GetPizzaById(orderModel.Pizza.Id);
            orderModel.Pizza = pizza;
            _userService.CreateNewUser(orderModel.User);
            _orderService.CreateNewOrder(orderModel);


            return RedirectToAction("OrderMenu");
        }
        
        public IActionResult OrderMenu()
        {
            var orders = _orderService.GetAllOrders();
            //var orders = _orderService.GetOrderById(id);
            return View(orders);
        }
    }
}
