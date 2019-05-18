namespace OdetoFood.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using OdetoFood.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<OdetoFood.Models.OdetoFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OdetoFood.Models.OdetoFoodDb";
        }

        protected override void Seed(OdetoFood.Models.OdetoFoodDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant { Name = "Swagat2", City = "Hyderabad", Country = "India" },
                new Restaurant { Name = "Bawarchi", City = "Atlanta", Country = "USA" },
                new Restaurant
                {
                    Name = "Mediterranean Grill",
                    City = "Mediterranean",
                    Country = "Greece",
                    Reviews = new List<RestaurantReview>
                    {
                        new RestaurantReview {Rating = 9, Body="Great Food", ReviewerName = "Avinash"}
                    }
                });
        }
    }
}
