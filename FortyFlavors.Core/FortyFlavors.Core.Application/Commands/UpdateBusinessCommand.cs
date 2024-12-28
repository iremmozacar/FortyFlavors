using System;
using MediatR;

namespace FortyFlavors.Core.Application.Commands;

public class UpdateBusinessCommand:IRequest<bool>
{
    public int BusinessId { get; set; }
    public string UpdatedBusinessName { get; set; }
    public string UpdatedContactInfo { get; set; }

    public UpdateBusinessCommand(int businessId, string updatedBusinessName, string updatedContactInfo)
    {
        BusinessId = businessId;
        UpdatedBusinessName = updatedBusinessName;
        UpdatedContactInfo = updatedContactInfo;
    }
}
