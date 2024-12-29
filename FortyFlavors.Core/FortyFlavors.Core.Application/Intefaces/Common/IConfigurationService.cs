using System;

namespace FortyFlavors.Core.Application.Intefaces.Common;

public interface IConfigurationService
{
    string GetSetting(string key);
    void SetSetting(string key, string value);
}
