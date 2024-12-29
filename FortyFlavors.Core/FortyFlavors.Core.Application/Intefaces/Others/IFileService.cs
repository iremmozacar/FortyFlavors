using System;

namespace FortyFlavors.Core.Application.Intefaces.Infrastructure;

public interface IFileService
{
    void SaveFile(string path, byte[] content);
    byte[] ReadFile(string path);
    void DeleteFile(string path);
}
