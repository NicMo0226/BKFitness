using System;
using System.Reflection;
using System.Threading.Tasks;

using BKFitness.Data;
using BKFitness.IServices;
using BKFitness.Models;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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

            services.AddIdentity<ApplicationUser, ApplicationRole> ()
                .AddDefaultUI (UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext> ();
            //Password Strength Setting
            services.Configure<IdentityOptions> (options =>
            {
                // Password settings
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 6;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes (30);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.RequireUniqueEmail = true;
            });
            services.AddScoped<IApplicationUser, ApplicationUserService> ();
            services.AddScoped<IApplicationRole, ApplicationRoleService> ();
            services.AddScoped<IClass ,ClassService> ();
            services.AddScoped<ILocation, LocationService> ();
            services.AddScoped<IDayDate, DayDateService> ();
            services.AddScoped<IParq, ParqService> ();
            services.AddScoped<IMembership, MembershipService> ();
            services.AddScoped<ITime, TimeService> ();
            services.AddScoped<IBooking, BookingService> ();
            services.AddSingleton (Configuration);
            services.AddMvc ().SetCompatibilityVersion (CompatibilityVersion.Version_2_2)
                .AddRazorPagesOptions (options =>
                {
                    options.AllowAreas = true;
                    options.Conventions.AuthorizeAreaFolder ("Identity", "/Account/Manage");
                    options.Conventions.AuthorizeAreaPage ("Identity", "/Account/Logout");
                });
            services.ConfigureApplicationCookie (options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes (30);
                options.LoginPath = "/Account/Login"; // If the LoginPath is not set here,
                // ASP.NET Core will default to /Account/Login
                options.LogoutPath = "/Account/Logout"; // If the LogoutPath is not set here,
                // ASP.NET Core will default to /Account/Logout
                options.AccessDeniedPath = "/Account/AccessDenied"; // If the AccessDeniedPath is
                // not set here, ASP.NET Core 
                // will default to 
                // /Account/AccessDenied
                options.SlidingExpiration = true;
            });
            // services.AddAuthorization (options =>
            // {
            //     options.AddPolicy ("RequireMembership", policy => policy.RequireRole ("ZumbaMember, ClubberciseMember"));
            // });
            services.AddAuthentication ()
                .AddGoogle (options =>
                {
                    options.ClientId = "708996912208-9m4dkjb5hscn7cjrn5u0r4tbgkbj1fko.apps.googleusercontent.com";
                    options.ClientSecret = "wdfPY6t8H8cecgjlxud__4Gh";
                });
        }
        // This method gets called by the runtime.Use this method to configure the HTTP request pipeline.
        // private async Task CreateUserRoles (IServiceProvider serviceProvider)
        // {
        //     var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>> ();
        //     var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>> ();
        //     IdentityResult roleResult;
        //     //Adding Admin Role
        //     var roleCheck = await RoleManager.RoleExistsAsync ("Admin");

        //     if (!roleCheck)
        //     {
        //         //create the roles and seed them to the database
        //         roleResult = await RoleManager.CreateAsync (new IdentityRole ("Admin"));
        //     }
        //     //Assign Admin role to the main User here we have given our newly registered 
        //     //login id for Admin management
        //     ApplicationUser user = await UserManager.FindByEmailAsync ("n@n.n");

        //     var User = new ApplicationUser ();
        //     await UserManager.AddToRoleAsync (user, "Admin");
        // }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env, IServiceProvider services)
        {
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
            app.UseCookiePolicy ();

            app.UseAuthentication ();

            app.UseMvc (routes =>
            {
                routes.MapRoute (
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

          //  CreateUserRoles (services).Wait ();
        }
    }
}