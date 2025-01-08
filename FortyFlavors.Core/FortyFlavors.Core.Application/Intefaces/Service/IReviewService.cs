using System;
using FortyFlavors.Core.Application.DTOs.CreateDto;
using FortyFlavors.Core.Application.DTOs.DtoS;

namespace FortyFlavors.Core.Application.Intefaces.Service;

public interface IReviewService : IService<ReviewDto>
{
    Task AddReviewAsync(ReviewDto review);
}
