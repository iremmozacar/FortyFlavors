using System;

namespace FortyFlavors.Core.Application.DTOs;

public class PagedResponseDto<T>
{
    public int TotalCount { get; set; }
    public int PageSize { get; set; }
    public int CurrentPage { get; set; }
    public IEnumerable<T> Items { get; set; }
}
