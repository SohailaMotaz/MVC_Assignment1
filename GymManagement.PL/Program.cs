using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using GymManagement.DAL.Repositories.Interfaces;
using GymManagement.DAL.Repositories.Classes;
using GymManagement.DAL.DbContexts;
using Microsoft.EntityFrameworkCore;




namespace GymManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<IPlanRepository, PlanRepository>();
            builder.Services.AddDbContext<GymDbContext>(options =>
            {
                options.UseSqlServer(
             builder.Configuration.GetConnectionString("DefaultConnection")
                );
            });


            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();


            app.Run();

        }
    }
}
