using System;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

using FortyFlavors.Core.Application.Exceptions;
namespace FortyFlavors.Core.Infrastructure.Middlewares;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (BaseException baseException)
        {
            await HandleBaseExceptionAsync(context, baseException);
        }
        catch (Exception ex)
        {
            await HandleGenericExceptionAsync(context, ex);
        }
    }

    private static Task HandleBaseExceptionAsync(HttpContext context, BaseException exception)
    {
        var result = JsonSerializer.Serialize(new
        {
            statusCode = exception.StatusCode,
            message = exception.Message
        });

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = exception.StatusCode;
        return context.Response.WriteAsync(result);
    }

    private static Task HandleGenericExceptionAsync(HttpContext context, Exception exception)
    {
        var result = JsonSerializer.Serialize(new
        {
            statusCode = StatusCodes.Status500InternalServerError,
            message = "Bir hata oluştu."
        });

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        return context.Response.WriteAsync(result);
    }
}
