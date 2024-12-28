using System;
using MediatR;

namespace FortyFlavors.Core.Application.Commands;

public class AddAdminCommand :IRequest<bool>
{
    public string AdminName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public AddAdminCommand(string adminName, string email, string password)
    {
        AdminName = adminName;
        Email = email;
        Password = password;
    }
}
