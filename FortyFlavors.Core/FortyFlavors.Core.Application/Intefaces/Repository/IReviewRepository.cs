using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface IReviewRepository : IGenericRepository<Review>
{
    Task<IEnumerable<Review>> GetReviewsByProductIdAsync(int productId);
}
