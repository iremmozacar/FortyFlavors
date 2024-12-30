using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class MessageException : BaseException
{
    public MessageException(string message, int errorCode) : base(message, errorCode)
    {
    }

    public static MessageException NotFound(int messageId)
    {
        return new MessageException($"Mesaj bulunamadı: {messageId}", 404);
    }

    public static MessageException InvalidOrderId(int orderId)
    {
        return new MessageException($"Geçersiz sipariş ID'si: {orderId}", 400);
    }

    public static MessageException SenderNotFound(int senderId)
    {
        return new MessageException($"Gönderen kullanıcı bulunamadı: {senderId}", 404);
    }

    public static MessageException ReceiverNotFound(int receiverId)
    {
        return new MessageException($"Alıcı kullanıcı bulunamadı: {receiverId}", 404);
    }

}
