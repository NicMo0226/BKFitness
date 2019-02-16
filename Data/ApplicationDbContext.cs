using System;
using System.Collections.Generic;
using System.Text;
using BKFitness.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BKFitness.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
        {
            public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options)
            {

            }
            public DbSet<ApplicationUser> ApplicationUsers { get; set; }
            public DbSet<ApplicationRole> ApplicationRoles { get; set; }
            public DbSet<Session> Classes { get; set; }
            public DbSet<DayDate> DayDates { get; set; }
            public DbSet<Time> Times { get; set; }
            public DbSet<Location> Locations { get; set; }
            public DbSet<Membership> Memberships { get; set; }
            public DbSet<Parq> Parqs { get; set; }
            public DbSet<Booking> Bookings { get; set; }
            public DbSet<ShoppingCart> ShoppingCarts{ get; set; }
            public DbSet<ShoppingCartItem> ShoppingCartItems{ get; set; }
            public DbSet<Order> Orders{ get; set; }
            public DbSet<OrderDetail> OrderDetails{ get; set; }
         

            protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql ("Server=localhost;Database=bkf_db;User Id=nic;Password=*******;");
            }
        }
}