using System;
using FortyFlavors.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FortyFlavors.Core.Infrastructure;


    public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Business> Businesses { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Email).IsRequired().HasMaxLength(200);
        });

        modelBuilder.Entity<Business>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(150);
        });
    }
}
