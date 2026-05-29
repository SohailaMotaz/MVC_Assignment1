using Microsoft.EntityFrameworkCore;
using GymManagement.Models;
using GymManagement.Models.Configurations;

namespace GymManagement.DbContexts
{
    public class GymDbContext : DbContext{
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(
          @"Server=localhost,1433;Database=BankManagementSystem;User Id=SA;Password=SQLConnect1!;TrustServerCertificate=True;"
          , sqlOptions =>
          { sqlOptions.EnableRetryOnFailure(maxRetryCount: 5, maxRetryDelay: TimeSpan.FromSeconds(10), errorNumbersToAdd: null); });

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Plan>(new PlanConfiguration());
        }
        public DbSet<Plan> Plans { get; set; }
    }
    

}