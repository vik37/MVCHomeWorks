using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.WebApp.ModelDemo.Models.Domain
{
    public class Store
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string TypePizza { get; set; }
        public Pizza pizza { get; set; }
    }
}
