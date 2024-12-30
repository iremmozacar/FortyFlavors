using System;
using FortyFlavors.Core.Application.DTOs.DtoS;
using MediatR;

namespace FortyFlavors.Core.Application.Queries.Others;

public class GetCommentsByBusinessIdQuery:IRequest<List<CommentDto>>
{
    public int BusinessId { get; set; }
}
