using System;
using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Infrastructure.Repositories;

public class PaymentRepository : IPaymentRepository
{
    public void AddPayment(Payment payment)
    {
        throw new NotImplementedException();
    }

    public void DeletePayment(int paymentId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Payment> GetAllPayments()
    {
        throw new NotImplementedException();
    }

    public Payment GetPaymentById(int paymentId)
    {
        throw new NotImplementedException();
    }

    public Payment GetPaymentByOrderId(int orderId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Payment> GetPaymentsByUserId(int userId)
    {
        throw new NotImplementedException();
    }

    public void UpdatePayment(Payment payment)
    {
        throw new NotImplementedException();
    }
}
