using SEDC.WebApp.ModelDemo.PresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.WebApp.ModelDemo.Services.Interfaces
{
    public interface IOrderService
    {
        List<OrderVM> GetAllOrders();
        OrderVM GetOrderById(int id);
        string CreateNewOrder(OrderVM model);
        string DeleteExistingOrder(int id);
        //List<OrderPizzaVM> GetOrderByUserAndPizzaId();
    }
}
