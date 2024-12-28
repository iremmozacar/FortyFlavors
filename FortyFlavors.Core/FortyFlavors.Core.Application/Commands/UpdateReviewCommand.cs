using System;
using MediatR;

namespace FortyFlavors.Core.Application.Commands;

public class UpdateReviewCommand:IRequest<bool>
{
    public int ReviewId { get; set; }
    public string UpdatedReviewText { get; set; }
    public int UpdatedRating { get; set; }

    public UpdateReviewCommand(int reviewId, string updatedReviewText, int updatedRating)
    {
        ReviewId = reviewId;
        UpdatedReviewText = updatedReviewText;
        UpdatedRating = updatedRating;
    }
}
