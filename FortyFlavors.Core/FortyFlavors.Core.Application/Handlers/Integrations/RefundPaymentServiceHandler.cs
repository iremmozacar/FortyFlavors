using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace FortyFlavors.Core.Application.Integrations.Payments
{
    public class RefundPaymentServiceRequest : IRequest<RefundPaymentServiceResponse>
    {
        public int PaymentId { get; set; }
        public decimal RefundAmount { get; set; }
        public string Reason { get; set; }

        public RefundPaymentServiceRequest(int paymentId, decimal refundAmount, string reason)
        {
            PaymentId = paymentId;
            RefundAmount = refundAmount;
            Reason = reason;
        }
    }

    public class RefundPaymentServiceResponse
    {
        public bool Success { get; set; }
        public string RefundTransactionId { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class RefundPaymentServiceHandler : IRequestHandler<RefundPaymentServiceRequest, RefundPaymentServiceResponse>
    {
        private readonly ILogger<RefundPaymentServiceHandler> _logger;

        public RefundPaymentServiceHandler(ILogger<RefundPaymentServiceHandler> logger)
        {
            _logger = logger;
        }

        public async Task<RefundPaymentServiceResponse> Handle(RefundPaymentServiceRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Processing refund for PaymentId={PaymentId}, RefundAmount={RefundAmount}, Reason={Reason}",
                request.PaymentId, request.RefundAmount, request.Reason);

       
            await Task.Delay(1000, cancellationToken);

          
            return new RefundPaymentServiceResponse
            {
                Success = true,
                RefundTransactionId = "REFUND123456789",
                ErrorMessage = null
            };
        }
    }
}