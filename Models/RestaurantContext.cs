using System;
using Microsoft.EntityFrameworkCore;

namespace PracticeAPI
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Chef> Chef { get; set; }
        public DbSet<Dish> Dish { get; set; }

    }
}