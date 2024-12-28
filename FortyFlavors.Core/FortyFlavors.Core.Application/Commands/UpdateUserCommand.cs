using System;
using MediatR;
namespace FortyFlavors.Core.Application.Commands;

public class UpdateUserCommand : IRequest<bool>
{
    public int UserId { get; set; }
    public string UpdatedFirstName { get; set; }
    public string UpdatedLastName { get; set; }
    public string UpdatedEmail { get; set; }

    public UpdateUserCommand(int userId, string updatedFirstName, string updatedLastName, string updatedEmail)
    {
        UserId = userId;
        UpdatedFirstName = updatedFirstName;
        UpdatedLastName = updatedLastName;
    }
}
