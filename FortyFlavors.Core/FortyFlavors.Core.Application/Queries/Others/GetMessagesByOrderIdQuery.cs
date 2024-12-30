using System;
using FortyFlavors.Core.Application.DTOs.DtoS;
using MediatR;

namespace FortyFlavors.Core.Application.Queries.Others;

public class GetMessagesByOrderIdQuery:IRequest<List<MessageDto>>
{
    public int OrderId { get; set; }
}
