using System;
using FortyFlavors.Core.Application.DTOs.DtoS;
using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Application.Intefaces.Service;

namespace FortyFlavors.Core.Infrastructure.Services;

public class ReviewService : Service<ReviewDto>, IReviewService
{
    private readonly IGenericRepository<ReviewDto> _repository;

    public ReviewService(IGenericRepository<ReviewDto> repository) : base(repository)
    {
        _repository = repository;
    }

    public async Task AddReviewAsync(ReviewDto review)
    {
        await _repository.AddAsync(review);
    }
    public async Task<IEnumerable<ReviewDto>> GetReviewsByProductAsync(int productId)
    {
        var reviews = await _repository.GetAllAsync();
        var productReviews = reviews.Where(r => r.ProductId == productId).Select(r => new ReviewDto
        {
            Id = r.Id,
            ProductId = r.ProductId,
            UserId = r.UserId,
            Comment = r.Comment,
            Rating = r.Rating
        });

        return productReviews;
    }
}
