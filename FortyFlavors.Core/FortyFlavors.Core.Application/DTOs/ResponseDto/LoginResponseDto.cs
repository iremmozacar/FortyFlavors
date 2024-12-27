using System;

namespace FortyFlavors.Core.Application.DTOs.ResponseDto;

public class LoginResponseDto
{
    public int UserId { get; set; }
    public string FullName { get; set; }
    public string Token { get; set; }
    public DateTime ExpirationDate { get; set; }
}
