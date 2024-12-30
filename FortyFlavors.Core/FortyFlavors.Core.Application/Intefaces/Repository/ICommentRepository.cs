using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface ICommentRepository
{
    void AddComment(Comment comment);
    Comment GetCommentById(int commentId);
    IEnumerable<Comment> GetCommentsByProductId(int productId); 
    IEnumerable<Comment> GetCommentsByBusinessId(int businessId); 
    void UpdateComment(Comment comment);
    void DeleteComment(int commentId);
}
