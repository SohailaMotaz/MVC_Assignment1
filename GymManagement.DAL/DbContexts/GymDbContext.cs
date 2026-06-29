using Microsoft.EntityFrameworkCore;
using GymManagement.DAL.Models;
using GymManagement.DAL.Configurations;

namespace GymManagement.DAL.DbContexts
{
    public class GymDbContext : DbContext{


        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Plan>(new PlanConfiguration());
        }
        public DbSet<Plan> Plans { get; set; }
    }
    

}