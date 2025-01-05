using System;
using FortyFlavors.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FortyFlavors.Core.Application.Intefaces.Common;

public interface IAppDbContext
{
    DbSet<User> Users { get; set; }
    DbSet<Order> Orders { get; set; }
    DbSet<Business> Businesses { get; set; }
    DbSet<Basket> Baskets { get; set; }
    DbSet<BasketItem> BasketItems { get; set; }
    DbSet<Product> Products { get; set; }
    DbSet<OrderItem> OrderItems { get; set; }
    DbSet<Payment> Payments { get; set; }
    DbSet<Campaign> Campaigns { get; set; }
    DbSet<Category> Categories { get; set; }
    DbSet<Review> Reviews { get; set; }
    DbSet<Comment> Comments { get; set; }
    DbSet<BusinessBankAccount> BusinessBankAccounts { get; set; }
    DbSet<Message> Messages { get; set; }
    DbSet<Likes> Likes { get; set; }
    DbSet<OrderStatus> OrderStatuses { get; set; }
    DbSet<UserRole> UserRoles { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
