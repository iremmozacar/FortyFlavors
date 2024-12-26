using System;

namespace FortyFlavors.Core.Common;

public class Response<T>
{
    public T Data { get; set; } 
    public string Message { get; set; } 
    public bool Success { get; set; } 
    public Response(T data, string message = null, bool success = true)
    {
        Data = data;
        Message = message;
        Success = success;
    }

    public Response(string message, bool success = false)
    {
        Data = default;
        Message = message;
        Success = success;
    }
}
