using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ParamountRestaurant_Project_Part3.Models;

namespace ParamountRestaurant_Project_Part3.Controllers
{
    public class MenuController : Controller
    {
        private RestaurantContext db = new RestaurantContext();

        // GET: Menu
        public ActionResult Index()
        {
            return View(db.FoodItems.ToList());
        }

        // GET: Menu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodItem foodItem = db.FoodItems.Find(id);
            if (foodItem == null)
            {
                return HttpNotFound();
            }
            return View(foodItem);
        }


    }
}
