using System;

namespace FortyFlavors.Core.Application.DTOs.CreateDto;

public class MessageCreateDto
{
    public int SenderId { get; set; }
    public int ReceiverId { get; set; }
    public string Content { get; set; }
    public int? OrderId { get; set; }
}
