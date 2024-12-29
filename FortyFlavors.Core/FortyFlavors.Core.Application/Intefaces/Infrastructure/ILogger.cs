using System;

namespace FortyFlavors.Core.Application.Intefaces.Infrastructure;

public interface ILogger
{
    void LogInfo(string message);
    void LogError(string message, Exception ex);
}
