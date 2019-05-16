using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OdetoFood.Models
{
    public class OdetoFoodDb: DbContext
    {
        public OdetoFoodDb()
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }
    }
}