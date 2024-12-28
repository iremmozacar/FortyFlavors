using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class UserNotFoundException : BaseException
{
    public UserNotFoundException(string message= "Kullanıcı bulunamadı.") : base(message, 404)
    {
    }
}
