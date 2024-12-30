using System;

namespace FortyFlavors.Core.Domain.Entities;

public class Likes
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int UserId { get; set; }
}
