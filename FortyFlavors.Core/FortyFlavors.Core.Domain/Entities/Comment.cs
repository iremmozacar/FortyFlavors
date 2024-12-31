using System;

namespace FortyFlavors.Core.Domain.Entities;

public class Comment
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid UserId { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsApproved { get; set; }
    public bool IsVisible { get; set; }
    public User User { get; set; }
	public Product Product { get; set; }
    public int? BusinessId { get; set; }
}
