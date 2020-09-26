
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.WebApp.ModelDemo.PresentationLayer.ViewModels
{
    public class OrderVM
    {
        public bool Delivered { get; set; }
        public UserVM User { get; set; }
        public PizzaVM Pizza { get; set; }
    }
}
