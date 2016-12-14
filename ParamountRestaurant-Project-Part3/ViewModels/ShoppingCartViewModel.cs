using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ParamountRestaurant_Project_Part3.Models;

namespace ParamountRestaurant_Project_Part3.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}