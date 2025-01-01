using System;

namespace FortyFlavors.Core.Domain.Entities;

public class Likes
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public User User { get; set; }
    public Product Product { get; set; }
}
