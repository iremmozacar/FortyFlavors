using System;

namespace FortyFlavors.Core.Application.Intefaces.Infrastructure;

public interface ICacheService
{
    void Set<T>(string key, T value, TimeSpan duration);
    T Get<T>(string key);
    void Remove(string key);
}
