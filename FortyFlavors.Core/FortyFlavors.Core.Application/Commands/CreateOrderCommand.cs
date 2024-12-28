using System;
using FortyFlavors.Core.Domain.Entities;
using MediatR;
namespace FortyFlavors.Core.Application.Commands;

public class CreateOrderCommand : IRequest<bool>
{
    public int UserId { get; set; }          
    public List<int> ProductIds { get; set; } 
    public decimal TotalAmount { get; set; } 

    public CreateOrderCommand(int userId, List<int> productIds, decimal totalAmount)
    {
        UserId = userId;
        ProductIds = productIds;
        TotalAmount = totalAmount;
    }
}
