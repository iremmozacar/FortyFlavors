using System;

namespace FortyFlavors.Core.Application.Intefaces.Infrastructure;

public interface INotfication
{
    void Notify(string userId, string message);
}
