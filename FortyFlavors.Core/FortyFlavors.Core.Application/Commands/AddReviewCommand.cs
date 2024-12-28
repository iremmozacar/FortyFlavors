using System;
using MediatR;

namespace FortyFlavors.Core.Application.Commands;

public class AddReviewCommand: IRequest<bool>
{
    public int ProductId { get; set; }
    public int UserId { get; set; }
    public string ReviewText { get; set; }
    public int Rating { get; set; }

    public AddReviewCommand(int productId, int userId, string reviewText, int rating)
    {
        ProductId = productId;
        UserId = userId;
        ReviewText = reviewText;
        Rating = rating;
    }
}
