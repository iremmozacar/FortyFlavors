using System;

namespace FortyFlavors.Core.Application.Commands;

public class CommentCommand
{
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public string Content { get; set; }
    public int? BusinessId { get; set; }
}
