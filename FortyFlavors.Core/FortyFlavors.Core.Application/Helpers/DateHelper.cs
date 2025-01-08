using System;

namespace FortyFlavors.Core.Application.Helpers;

public class DateHelper
{
    public static string ToReadableDate(DateTime date)
    {
        return date.ToString("dd MMM yyyy HH:mm");
    }
}
