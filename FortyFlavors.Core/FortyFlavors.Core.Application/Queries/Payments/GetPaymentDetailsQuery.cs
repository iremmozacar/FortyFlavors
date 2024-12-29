using System;

namespace FortyFlavors.Core.Application.Queries.Payments;

public class GetPaymentDetailsQuery
{
    public int PaymentId { get; }

    public GetPaymentDetailsQuery(int paymentId)
    {
        PaymentId = paymentId;
    }
}
