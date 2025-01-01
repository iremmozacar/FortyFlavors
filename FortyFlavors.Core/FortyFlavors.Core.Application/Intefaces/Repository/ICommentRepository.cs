using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface ICommentRepository : IGenericRepository<Comment>
{
    Task<IEnumerable<Comment>> GetCommentsByProductIdAsync(int productId);
}
