using System;

namespace FortyFlavors.Core.Application.Intefaces.Infrastructure;

public interface ILoggerManager
{
    void LogInfo(string message);
    void LogWarn(string message);
    void LogError(string message);
    void LogDebug(string message);
}
