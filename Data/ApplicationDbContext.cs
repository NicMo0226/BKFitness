using System;
using System.Collections.Generic;
using System.Text;
using BKFitness.IServices;
using BKFitness.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BKFitness.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options)
            {

            }
            public DbSet<ApplicationUser> ApplicationUsers { get; set; }

            public DbSet<Session> Classes { get; set; }
            public DbSet<DayDate> DayDates { get; set; }
            public DbSet<Time> Times { get; set; }
            public DbSet<Location> Locations { get; set; }
            public DbSet<Parq> Parqs { get; set; }
            public DbSet<Booking> Bookings { get; set; }

            public DbSet<Category> Categories { get; set; }
            public DbSet<Order> Orders { get; set; }
            public DbSet<OrderLine> Lines { get; set; }
            public DbSet<Membership> Memberships { get; set; }
            public DbSet<Product> Products { get; set; }
            protected override void OnModelCreating (ModelBuilder modelBuilder)
            {

                modelBuilder.Entity<Product> ().HasIndex (p => p.Name);
                modelBuilder.Entity<Product> ().HasIndex (p => p.PurchasePrice);
                modelBuilder.Entity<Product> ().HasIndex (p => p.RetailPrice);
                modelBuilder.Entity<Category> ().HasIndex (p => p.Name);
                modelBuilder.Entity<Category> ().HasIndex (p => p.Description);
                base.OnModelCreating (modelBuilder);
            }

            protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql ("Server=localhost;Database=bkf_db;User Id=nic;Password=10202602Mo;");
            }
        }
}