using System;
using FortyFlavors.Core.Application.DTOs;
using MediatR;

namespace FortyFlavors.Core.Application.Queries.Payments;

public class GetUserPaymentsQuery:IRequest<List<PaymentResponseDto>>
{
    public int UserId { get; }

    public GetUserPaymentsQuery(int userId)
    {
        UserId = userId;
    }
}
