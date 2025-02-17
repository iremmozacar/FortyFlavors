using System;

namespace FortyFlavors.Core.Application.DTOs;

public class UserCreateDto
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsActive { get; set; }
}
