using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.MVCHomeWork_PizzaApp.Models
{
    public class PizzaModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; }

        public PizzaModels()
        {            
            Currency = "USD";
        }
    }
}
