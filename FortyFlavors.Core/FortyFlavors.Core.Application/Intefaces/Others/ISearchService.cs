using System;

namespace FortyFlavors.Core.Application.Intefaces.Others;

public interface ISearchService
{
    IEnumerable<T> Search<T>(string query);
}
