
using School.Api.Models;

namespace School.Api.Repositories.Interfaces;
public interface IPaymentRepository
{
    /// <summary>
    /// Gets all payments.
    /// </summary>
    /// <returns>A list of payments.</returns>
    Task<List<PaymentModel>> GetPaymentsAsync();

    /// <summary>
    /// Gets a payment by ID.
    /// </summary>
    /// <param name="paymentId">The payment ID.</param>
    /// <returns>The payment.</returns>
    Task<PaymentModel> GetPaymentByIdAsync(int paymentId);

    /// <summary>
    /// Adds a new payment.
    /// </summary>
    /// <param name="payment">The payment to add.</param>
    /// <returns>The added payment.</returns>
    Task<PaymentModel> AddPaymentAsync(PaymentModel payment);

    /// <summary>
    /// Updates a payment.
    /// </summary>
    /// <param name="paymentId">The payment ID.</param>
    /// <param name="payment">The payment details.</param>
    /// <returns>The updated payment.</returns>
    Task<PaymentModel> UpdatePaymentAsync(int paymentId, PaymentModel payment);
}
