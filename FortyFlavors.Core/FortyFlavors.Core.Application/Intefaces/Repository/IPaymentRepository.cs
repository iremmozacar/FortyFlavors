using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface IPaymentRepository
{
    void AddPayment(Payment payment);
    Payment GetPaymentById(int paymentId);
    Payment GetPaymentByOrderId(int orderId);
    IEnumerable<Payment> GetPaymentsByUserId(int userId); 
    IEnumerable<Payment> GetAllPayments(); 
    void UpdatePayment(Payment payment);
    void DeletePayment(int paymentId);
}
