using Microsoft.EntityFrameworkCore;
using NewsApp.Domain.Entities;

namespace NewsApp.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<News> News { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}