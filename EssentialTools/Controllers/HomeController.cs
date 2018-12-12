﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EssentialTools.Models;
using Ninject;

namespace EssentialTools.Controllers {
    public class HomeController : Controller {
        private IValueCalculator calc;
        private Product[] products =
        {
            new Product {Name = "Kajak", Category = "Sporty Wodne", Price = 275M},
            new Product {Name = "Kamizelka ratunkowa", Category = "Sporty Wodne", Price = 48.95M},
            new Product {Name = "Piłka nożna", Category = "Piłka nożna", Price = 19.50M},
            new Product {Name = "Flaga narożna", Category = "Piłka nożna", Price = 34.95M}
        };

        public HomeController(IValueCalculator calcParam, IValueCalculator calc2) {
            calc = calcParam;
        }

        // GET: Home
        public ActionResult Index() {
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalValue = cart.CalculateProductTotal();
            return View(totalValue);
        }
    }
}