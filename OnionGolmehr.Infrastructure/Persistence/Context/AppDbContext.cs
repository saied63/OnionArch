using Microsoft.EntityFrameworkCore;
using OnionGolmehr.Domain.Entities;

public class AppDbContext : DbContext
{
    public DbSet<Country> Countries { get; set; }
    public DbSet<City> Cities { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent API configuration goes here
    }
}
