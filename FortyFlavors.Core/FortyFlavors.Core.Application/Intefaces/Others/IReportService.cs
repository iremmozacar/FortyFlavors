using System;

namespace FortyFlavors.Core.Application.Intefaces.Others;

public interface IReportService
{
    byte[] GenerateReport(string reportType, object data);
}
