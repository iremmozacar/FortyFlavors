using System;

namespace FortyFlavors.Core.Application.DTOs.ResponseDto;

public class UserResponseDto
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public bool IsActive { get; set; }
}
