using System;
using MediatR;

namespace FortyFlavors.Core.Application.Commands;

public class DeleteUserCommand : IRequest<bool>
{
    public int UserId { get; set; }

    public DeleteUserCommand(int userId)
    {
        UserId = userId;
    }
}
