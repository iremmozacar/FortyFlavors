using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface ILikesRepository : IGenericRepository<Likes>
{
    Task<int> GetLikesCountByProductIdAsync(int productId);
    Task<bool> HasUserLikedAsync(int userId, int productId);
}