using System;

namespace FortyFlavors.Core.Application.Intefaces.Common;

public interface IValidator<T>
{
    bool Validate(T entity);
    IEnumerable<string> GetValidationErrors(T entity);
}
