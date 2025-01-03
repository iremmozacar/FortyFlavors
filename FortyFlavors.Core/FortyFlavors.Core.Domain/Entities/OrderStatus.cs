using System;

namespace FortyFlavors.Core.Domain.Entities;

public class OrderStatus
{
    public int Id { get; private set; }
    public int OrderId { get; private set; } 
    public string Status { get; private set; } 
    public DateTime UpdatedAt { get; private set; } 
    public int UpdatedBy { get; private set; }
    public Order Order { get; set; }

    public OrderStatus(int orderId, string status, int updatedBy)
    {
        if (string.IsNullOrWhiteSpace(status))
            throw new ArgumentException("Durum bilgisi boş bırakılamaz.");

        OrderId = orderId;
        Status = status;
        UpdatedAt = DateTime.UtcNow;
        UpdatedBy = updatedBy;
    }

    public void UpdateStatus(string newStatus, int updatedBy)
    {
        if (string.IsNullOrWhiteSpace(newStatus))
            throw new ArgumentException("Yeni durum bilgisi boş bırakılamaz.");

        Status = newStatus;
        UpdatedAt = DateTime.UtcNow;
        UpdatedBy = updatedBy;
    }
}