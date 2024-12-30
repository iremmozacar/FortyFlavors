using System;

namespace FortyFlavors.Core.Domain.Entities;

public class Campaign
{
    public Guid Id { get; private set; }
    public Guid BusinessId { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public decimal DiscountRate { get; private set; }
    public Business Business { get; set; }

    public Campaign(Guid businessId, string title, string description, DateTime startDate, DateTime endDate, decimal discountRate)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Kampanya başlığı boş olamaz.");
        if (discountRate <= 0 || discountRate > 100)
            throw new ArgumentException("İndirim oranı 0 ile 100 arasında olmalıdır.");

        Id = Guid.NewGuid();
        BusinessId = businessId;
        Title = title;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;
        DiscountRate = discountRate;
    }
}
