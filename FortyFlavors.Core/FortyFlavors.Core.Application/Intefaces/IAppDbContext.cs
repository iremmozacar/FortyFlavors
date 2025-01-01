using FortyFlavors.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace FortyFlavors.Core.Application.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<OrderItem> OrderItems { get; set; }
        DbSet<Payment> Payments { get; set; }
        DbSet<Campaign> Campaigns { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Review> Reviews { get; set; }
        DbSet<Comment> Comments { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}