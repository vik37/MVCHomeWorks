using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.WebApp.ModelDemo.PresentationLayer.ViewModels
{
    public class UserVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
        public List<OrderVM> Orders { get; set; }
    }
}
