
using School.Api.Models;

namespace School.Api.Repositories.Interfaces;
public interface IPaymentRepository
{
    Task<List<PaymentModel>> GetPaymentsAsync();
    Task<PaymentModel> GetPaymentByIdAsync(int paymentId);
    Task<PaymentModel> AddPaymentAsync(PaymentModel payment);
    Task<PaymentModel> UpdatePaymentAsync(int paymentId, PaymentModel payment);
    Task<bool> DeletePaymentAsync(int paymentId);
}
