using System;

namespace FortyFlavors.Core.Application.Intefaces.Infrastructure;

public interface IMailService
{
    void SendEmail(string to, string subject, string body);
}
