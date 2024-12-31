using System;
using FortyFlavors.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FortyFlavors.Core.Infrastructure;


    public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Business> Businesses { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Basket> Baskets { get; set; }
    public DbSet<BasketItem> BasketItems { get; set; }
    public DbSet<Campaign> Campaigns { get; set; }
    public DbSet<Transaction>  Transactions { get; set; }
    public DbSet<Likes> Likes{ get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }



    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    
    modelBuilder.Entity<Review>()
        .HasOne(r => r.User)
        .WithMany(u => u.Reviews)
        .HasForeignKey(r => r.UserId)
        .OnDelete(DeleteBehavior.Cascade);

   
    modelBuilder.Entity<Review>()
        .HasOne(r => r.Product)
        .WithMany(p => p.Reviews)
        .HasForeignKey(r => r.ProductId)
        .OnDelete(DeleteBehavior.Cascade);

   
    modelBuilder.Entity<Product>()
        .HasOne(p => p.Business)
        .WithMany(b => b.Products)
        .HasForeignKey(p => p.BusinessId)
        .OnDelete(DeleteBehavior.Cascade);


    modelBuilder.Entity<Campaign>()
        .HasOne(c => c.Business)
        .WithMany(b => b.Campaigns)
        .HasForeignKey(c => c.BusinessId)
        .OnDelete(DeleteBehavior.Cascade);

  
    modelBuilder.Entity<Basket>()
        .HasOne(b => b.User)
        .WithMany(u => u.Baskets)
        .HasForeignKey(b => b.UserId)
        .OnDelete(DeleteBehavior.Cascade);

    
    modelBuilder.Entity<BasketItem>()
        .HasOne(bi => bi.Basket)
        .WithMany(b => b.BasketItems)
        .HasForeignKey(bi => bi.BasketId)
        .OnDelete(DeleteBehavior.Cascade);

   
    modelBuilder.Entity<BasketItem>()
        .HasOne(bi => bi.Product)
        .WithMany()
        .HasForeignKey(bi => bi.ProductId)
        .OnDelete(DeleteBehavior.Cascade);


    modelBuilder.Entity<Order>()
        .HasOne(o => o.User)
        .WithMany(u => u.Orders)
        .HasForeignKey(o => o.UserId)
        .OnDelete(DeleteBehavior.Cascade);

 
    modelBuilder.Entity<OrderItem>()
        .HasOne(oi => oi.Order)
        .WithMany(o => o.OrderItems)
        .HasForeignKey(oi => oi.OrderId)
        .OnDelete(DeleteBehavior.Cascade);

 
    modelBuilder.Entity<OrderItem>()
        .HasOne(oi => oi.Product)
        .WithMany()
        .HasForeignKey(oi => oi.ProductId)
        .OnDelete(DeleteBehavior.Cascade);


    modelBuilder.Entity<Message>()
        .HasOne(m => m.Sender)
        .WithMany(u => u.SentMessages)
        .HasForeignKey(m => m.SenderId)
        .OnDelete(DeleteBehavior.Cascade);

    modelBuilder.Entity<Message>()
        .HasOne(m => m.Receiver)
        .WithMany(u => u.ReceivedMessages)
        .HasForeignKey(m => m.ReceiverId)
        .OnDelete(DeleteBehavior.Cascade);


    modelBuilder.Entity<Product>()
        .HasOne(p => p.Category)
        .WithMany(c => c.Products)
        .HasForeignKey(p => p.CategoryId)
        .OnDelete(DeleteBehavior.Cascade);


    modelBuilder.Entity<Comment>()
        .HasOne(c => c.Product)
        .WithMany(p => p.Comments)
        .HasForeignKey(c => c.ProductId)
        .OnDelete(DeleteBehavior.Cascade);


    modelBuilder.Entity<Comment>()
        .HasOne(c => c.User)
        .WithMany(u => u.Comments)
        .HasForeignKey(c => c.UserId)
        .OnDelete(DeleteBehavior.Cascade);


    modelBuilder.Entity<Likes>()
        .HasOne(l => l.Product)
        .WithMany(p => p.Likes)
        .HasForeignKey(l => l.ProductId)
        .OnDelete(DeleteBehavior.Cascade);

   
    modelBuilder.Entity<Likes>()
        .HasOne(l => l.User)
        .WithMany(u => u.Likes)
        .HasForeignKey(l => l.UserId)
        .OnDelete(DeleteBehavior.Cascade);


        modelBuilder.Entity<UserRole>()
            .HasData(
                new UserRole { Id = Guid.NewGuid(), RoleName = "Admin" },
                new UserRole { Id = Guid.NewGuid(), RoleName = "BusinessOwner" },
                new UserRole { Id = Guid.NewGuid(), RoleName = "Customer" }
            );

        base.OnModelCreating(modelBuilder);
}
}
