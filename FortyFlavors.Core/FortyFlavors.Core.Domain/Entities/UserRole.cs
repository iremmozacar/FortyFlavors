using System;

namespace FortyFlavors.Core.Domain.Entities;

public class UserRole
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string RoleName { get; set; }
}
