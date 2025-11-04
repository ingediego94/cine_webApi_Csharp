using cine.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace cine.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>()
            .HasIndex("DocNumber")
            .IsUnique();

        modelBuilder.Entity<Client>()
            .HasIndex("Email")
            .IsUnique();

        modelBuilder.Entity<Movie>()
            .HasIndex("MovieCode")
            .IsUnique();
        
        base.OnModelCreating(modelBuilder);
    }

    // Creating tables on the DB:
    public DbSet<Client> clients_tb { get; set; }
    public DbSet<Movie> movies_tb { get; set; }
    public DbSet<Ticket> tickets_tb { get; set; }
    
}