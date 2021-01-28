﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.MVC.MODEL.DEMO.Models.ViewModels
{
    public class OrderDetailsVM
    {
		public int Id { get; set; }
		public string FullName { get; set; }
		public string Address { get; set; }
		public long Contact { get; set; }
		public string Pizza { get; set; }
		public double Price { get; set; }
	}
}
