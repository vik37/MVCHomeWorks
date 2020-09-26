﻿using SEDC.WebApp.ModelDemo.DataAccess.Domain.Interfaces;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using SEDC.WebApp.ModelDemo.PresentationLayer.ViewModels;
using SEDC.WebApp.ModelDemo.Services.Helpers.Mappers.OrderMappers;
using SEDC.WebApp.ModelDemo.Services.Helpers.Mappers.PizzaMappers;
using SEDC.WebApp.ModelDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SEDC.WebApp.ModelDemo.Services.Services
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _orderRepository;
        public OrderService(IRepository<Order> orderRepo)
        {
            _orderRepository = orderRepo;
        }

        public string CreateNewOrder(OrderVM model)
        {
            var order = OrderMapper.OrderVMtoOrder(model);
            //order.Id = _orderRepository.GetAll().Count + 1;
            int response = _orderRepository.Create(order);
            if (response == -1) return "Was not successfull, please try again later!";
            return "Order successfully created!";
        }

        public string DeleteExistingOrder(int id)
        {
            int response = _orderRepository.Delete(id);
            if (response == -1) return "Was not successfull, please try again later!";
            return "Order successfully deleted!";
        }

        public List<OrderVM> GetAllOrders()
        {
            var orders = _orderRepository.GetAll();
            return OrderMapper.OrdersToOrdersVM(orders);
        }

        public OrderVM GetOrderById(int id)
        {
            var order = _orderRepository.GetById(id);
            return OrderMapper.OrderToOrderVM(order);
        }

       
    }
}
