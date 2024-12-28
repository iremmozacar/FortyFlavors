using System;
using MediatR;

namespace FortyFlavors.Core.Application.Commands;

public class DeleteProductCommand : IRequest<bool>
{
    public int ProductId { get; set; }

    public DeleteProductCommand(int productId)
    {
        ProductId = productId;
    }
}
