using System;
using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Infrastructure.Repositories;

public class CommentRepository : ICommentRepository
{
    public void AddComment(Comment comment)
    {
        throw new NotImplementedException();
    }

    public void DeleteComment(int commentId)
    {
        throw new NotImplementedException();
    }

    public Comment GetCommentById(int commentId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Comment> GetCommentsByBusinessId(int businessId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Comment> GetCommentsByProductId(int productId)
    {
        throw new NotImplementedException();
    }

    public void UpdateComment(Comment comment)
    {
        throw new NotImplementedException();
    }
}
