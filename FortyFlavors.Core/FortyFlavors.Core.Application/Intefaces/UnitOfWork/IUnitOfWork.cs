using System;
using FortyFlavors.Core.Application.Intefaces.Repository;

namespace FortyFlavors.Core.Application.Intefaces.UnitOfWork;

public interface IUnitOfWork:IDisposable
{
    IOrderRepository OrderRepository { get; }
    IPaymentRepository PaymentRepository { get; }
    IUserRepository UserRepository { get; }

    Task<int> SaveChangesAsync();
    void BeginTransaction();
    Task CommitAsync();
    Task RollbackAsync();
}
