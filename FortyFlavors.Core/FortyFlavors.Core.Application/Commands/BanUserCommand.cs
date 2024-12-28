using System;
using MediatR;

namespace FortyFlavors.Core.Application.Commands;

public class BanUserCommand : IRequest<bool>
{
    public int UserId { get; set; }
    public string Reason { get; set; }

    public BanUserCommand(int userId, string reason)
    {
        UserId = userId;
        Reason = reason;
    }
}
