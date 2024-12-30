using System;

namespace FortyFlavors.Core.Application.DTOs.DtoS;

public class CommentDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? BusinessId { get; set; }
}
