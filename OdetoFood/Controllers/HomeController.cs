using OdetoFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdetoFood.Controllers
{
    public class HomeController : Controller
    {
        OdetoFoodDb _db = new OdetoFoodDb();

        public ActionResult Index(string searchTerm = null)
        {
            var model = 
                    _db.Restaurants
                        .OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                        .Where(r=>searchTerm ==null || r.Name.StartsWith(searchTerm))
                        .Take(10)
                        .Select(r => new RestaurantListViewModel
                        {
                            Id = r.Id,
                            Name = r.Name,
                            City = r.City,
                            Country = r.Country,
                            CountOfReviews = r.Reviews.Count()
                        });

            if(Request.IsAjaxRequest())
            {
                return PartialView("_Restaurants", model);
            }

            return View(model);
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            //ViewBag.Locations = "Atlanta, GA, US";
            var model = new AboutModel();
            model.Name = "Avinash";
            model.Location = "Atlanta, GA, USA";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}