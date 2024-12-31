using System;

namespace FortyFlavors.Core.Domain.Entities;

public class Likes
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public User User { get; set; }
    public Product Product { get; set; }
}
