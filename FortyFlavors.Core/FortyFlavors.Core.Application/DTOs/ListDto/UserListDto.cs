using System;

namespace FortyFlavors.Core.Application.DTOs.ListDto;

public class UserListDto
{
    public int UserId { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
}
