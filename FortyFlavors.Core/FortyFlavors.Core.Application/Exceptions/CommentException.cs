using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class CommentException : BaseException
{
    public CommentException(string message, int errorCode) : base(message, errorCode)
    {
    }

    public static CommentException NotFound(int commentId)
    {
        return new CommentException($"Yorum bulunamadı: {commentId}", 404);
    }

    public static CommentException InvalidBusinessId(int businessId)
    {
        return new CommentException($"Geçersiz işletme ID'si: {businessId}", 400);
    }
}
