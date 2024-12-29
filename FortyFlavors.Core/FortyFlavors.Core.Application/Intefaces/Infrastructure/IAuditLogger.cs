using System;

namespace FortyFlavors.Core.Application.Intefaces.Infrastructure;

public interface IAuditLogger
{
    void LogAction(string user, string action, DateTime timestamp);
}
