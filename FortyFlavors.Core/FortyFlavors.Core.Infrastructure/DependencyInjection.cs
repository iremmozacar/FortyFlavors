using System;
using FortyFlavors.Core.Application.Intefaces.Infrastructure;
using FortyFlavors.Core.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FortyFlavors.Core.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<ILoggerManager, LoggerManager>();
        return services;
    }
}