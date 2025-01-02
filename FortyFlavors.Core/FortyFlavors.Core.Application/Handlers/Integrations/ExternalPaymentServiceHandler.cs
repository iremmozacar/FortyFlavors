using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace FortyFlavors.Core.Application.Integrations.Payments
{
    public class ExternalPaymentServiceRequest : IRequest<ExternalPaymentServiceResponse>
    {
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }

        public ExternalPaymentServiceRequest(int orderId, decimal amount, string paymentMethod)
        {
            OrderId = orderId;
            Amount = amount;
            PaymentMethod = paymentMethod;
        }
    }

    public class ExternalPaymentServiceResponse
    {
        public bool Success { get; set; }
        public string TransactionId { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExternalPaymentServiceHandler : IRequestHandler<ExternalPaymentServiceRequest, ExternalPaymentServiceResponse>
    {
        private readonly ILogger<ExternalPaymentServiceHandler> _logger;

        public ExternalPaymentServiceHandler(ILogger<ExternalPaymentServiceHandler> logger)
        {
            _logger = logger;
        }

        public async Task<ExternalPaymentServiceResponse> Handle(ExternalPaymentServiceRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Initiating external payment for OrderId={OrderId}, Amount={Amount}, PaymentMethod={PaymentMethod}",
                request.OrderId, request.Amount, request.PaymentMethod);

          
            await Task.Delay(1000, cancellationToken);

          
            return new ExternalPaymentServiceResponse
            {
                Success = true,
                TransactionId = "TRANS123456789",
                ErrorMessage = null
            };
        }
    }
}