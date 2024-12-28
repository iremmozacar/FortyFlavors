using System;
using MediatR;

namespace FortyFlavors.Core.Application.Commands;

public class RegisterBusinessCommand : IRequest<int>
{

    public string BusinessName { get; set; }
    public string OwnerName { get; set; }
    public string ContactInfo { get; set; }

    public RegisterBusinessCommand(string businessName, string ownerName, string contactInfo)
    {
        BusinessName = businessName;
        OwnerName = ownerName;
        ContactInfo = contactInfo;
    }
}
