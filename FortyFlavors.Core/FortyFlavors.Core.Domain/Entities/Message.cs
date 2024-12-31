using System;

namespace FortyFlavors.Core.Domain.Entities;

public class Message
{
    public Guid Id { get; set; }
    public Guid SenderId { get; set; }
    public Guid ReceiverId { get; set; }
    public DateTime SentDate { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? OrderId { get; set; }
    public bool IsRead { get; set; }
    public User Sender { get; set; }
    public User Receiver { get; set; }
}
