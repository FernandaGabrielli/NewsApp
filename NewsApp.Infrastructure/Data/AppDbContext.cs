using Microsoft.EntityFrameworkCore;
using NewsApp.Domain.Entities;

namespace NewsApp.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { } // Construtor sem parâmetros

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<News> News { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Configuração para uso em tempo de design (migrações)
                optionsBuilder.UseSqlServer("Server=localhost;Database=NewsAppDb;Trusted_Connection=True;");
            }
        }
    }
}