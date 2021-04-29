using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxApi.Models
{
    public class PizzaBoxContext : DbContext
    {
        public PizzaBoxContext(DbContextOptions<PizzaBoxContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(s => s.Customer)
                .WithMany(a => a.Orders)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Order>()
                .HasOne(s => s.Store)
                .WithMany(a => a.Orders)
                .OnDelete(DeleteBehavior.Restrict);

        }

        public DbSet<Crust> Crusts { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPizza> OrderPizzas { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<PizzaTopping> PizzaToppings { get; set; }
    }
}
