using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using BKFitness.Data;
using BKFitness.IServices;
using BKFitness.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json;
using Stripe;
using OrderService = BKFitness.IServices.OrderService;


namespace BKFitness
{
    public class Startup
    {
        public Startup (IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions> (options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            var connectionString = Configuration.GetConnectionString ("DefaultConnection");
            var migrationsAssembly = typeof (Startup).GetTypeInfo ().Assembly.GetName ().Name;
            services.AddDbContext<ApplicationDbContext> (options =>
                options.UseNpgsql (connectionString));

            services.AddIdentity<ApplicationUser, IdentityRole> ()
                .AddDefaultUI (UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext> ();
            //Password Strength Setting

            services.Configure<StripeSettings> (Configuration.GetSection ("Stripe"));
            services.AddScoped<IApplicationUser, ApplicationUserService> ();
            services.AddScoped<IClass, ClassService> ();
            services.AddScoped<ILocation, LocationService> ();
            services.AddScoped<IDayDate, DayDateService> ();
            services.AddScoped<IParq, ParqService> ();
            services.AddScoped<ITime, TimeService> ();
            services.AddScoped<IBooking, BookingService> ();
            services.AddScoped<IOrder, OrderService> ();
            services.AddScoped<ICategory, CategoryService> ();
            services.AddScoped<IData, DataService> ();
            services.AddScoped<IMembership, MembershipService> ();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor> ();
            services.AddSingleton (Configuration);
            services.AddDistributedSqlServerCache (options =>
            {
                options.ConnectionString = connectionString;
                options.SchemaName = "dbo";
                options.TableName = "SessionData";
            });
            services.AddSession (options =>
            {
                options.Cookie.Name = "SportsStore.Session";
                options.IdleTimeout = System.TimeSpan.FromHours (48);
                options.Cookie.HttpOnly = false;
            });
            services.AddSingleton<IFileProvider> (
                new PhysicalFileProvider (
                    Path.Combine (Directory.GetCurrentDirectory (), "wwwroot")));

            //   services.AddDirectoryBrowser ();
            services.AddMvc ().SetCompatibilityVersion (CompatibilityVersion.Version_2_2)
                .AddJsonOptions (opts =>
                    opts.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Serialize)
            .AddRazorPagesOptions (options =>
            {
                options.AllowAreas = true;
                options.Conventions.AuthorizeAreaFolder ("Identity", "/Account/Manage");
                options.Conventions.AuthorizeAreaPage ("Identity", "/Account/Logout");
            });
            services.ConfigureApplicationCookie (options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
            });

            services.AddAuthentication ()
                .AddGoogle (options =>
                {
                    options.ClientId = "708996912208-9m4dkjb5hscn7cjrn5u0r4tbgkbj1fko.apps.googleusercontent.com";
                    options.ClientSecret = "wdfPY6t8H8cecgjlxud__4Gh";
                });
        }

        public void Configure (IApplicationBuilder app, IHostingEnvironment env, IServiceProvider services)
        {
            StripeConfiguration.SetApiKey (Configuration.GetSection ("Stripe")["SecretKey"]);
            if (env.IsDevelopment ())
            {
                app.UseDeveloperExceptionPage ();
                app.UseDatabaseErrorPage ();
            }
            else
            {
                app.UseExceptionHandler ("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts ();
            }

            app.UseHttpsRedirection ();
            app.UseStaticFiles ();
            app.UseSession ();

            app.UseCookiePolicy ();

            app.UseAuthentication ();
            app.UseMvcWithDefaultRoute ();

            // app.UseMvc (routes =>
            // {
            //     routes.MapRoute (
            //         name: "default",
            //         template: "{controller=Home}/{action=Index}/{id?}");
            // });

            //  CreateUserRoles (services).Wait ();
        }
    }
}