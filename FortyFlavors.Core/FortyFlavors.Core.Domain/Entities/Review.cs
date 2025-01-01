using System;

namespace FortyFlavors.Core.Domain.Entities;

public class Review
{
    public int Id { get; private set; }
    public int UserId { get; private set; }
    public int ProductId { get; private set; }
    public string Comment { get; private set; }
    public int Rating { get; private set; }

    public User User { get; set; }
    public Product Product { get; set; }

    public Review(int userId, int productId, string comment, int rating)
    {
        if (string.IsNullOrWhiteSpace(comment))
            throw new ArgumentException("Yorum boş olamaz.");
        if (rating < 1 || rating > 5)
            throw new ArgumentException("Puan 1 ile 5 arasında olmalıdır.");

        Id = Id;
        UserId = userId;
        ProductId = productId;
        Comment = comment;
        Rating = rating;
    }

    public void UpdateComment(string newComment)
    {
        if (string.IsNullOrWhiteSpace(newComment))
            throw new ArgumentException("Yeni yorum boş olamaz.");
        Comment = newComment;
    }

    public void UpdateRating(int newRating)
    {
        if (newRating < 1 || newRating > 5)
            throw new ArgumentException("Yeni puan 1 ile 5 arasında olmalıdır.");
        Rating = newRating;
    }
}
