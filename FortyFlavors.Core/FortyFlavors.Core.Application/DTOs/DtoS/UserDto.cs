using System;

namespace FortyFlavors.Core.Application.DTOs.DtoS;

public class UserDto
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public bool IsActive { get; set; }
}
