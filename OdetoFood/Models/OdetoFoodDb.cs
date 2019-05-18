using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OdetoFood.Models
{
    public interface IOdetoFoodDb
    {
        IQueryable<T> Query<T>() where T : class;
    }
    public class OdetoFoodDb: DbContext, IOdetoFoodDb
    {
        public OdetoFoodDb()
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }

        public IQueryable<T> Query<T>() where T : class
        {
            return Set<T>();
        }
    }
}