
using School.Api.Models;
using School.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

public class PaymentRepository : IPaymentRepository
{
    private readonly TaskSystemDBContext _taskSystemDBContext;

    public PaymentRepository(TaskSystemDBContext taskSystemDBContext)
    {
        _taskSystemDBContext = taskSystemDBContext;
    }

    /// <inheritdoc />
    public async Task<PaymentModel> AddPaymentAsync(PaymentModel payment)
    {
        await _taskSystemDBContext.Payments.AddAsync(payment);
        await _taskSystemDBContext.SaveChangesAsync();
        return payment;
    }

    /// <inheritdoc />
    public async Task<PaymentModel> GetPaymentByIdAsync(int paymentId)
    {
        return  _taskSystemDBContext.Payments.FirstOrDefault(x => x.ID == paymentId);
    }

    /// <inheritdoc />
    public async Task<List<PaymentModel>> GetPaymentsAsync()
    {
        return await _taskSystemDBContext.Payments.ToListAsync();
    }

    /// <inheritdoc />
    public async Task<PaymentModel> UpdatePaymentAsync(int paymentId, PaymentModel paymentData)
    {
        PaymentModel payment = await GetPaymentByIdAsync(paymentId);

        if (payment == null)
        {
            throw new Exception("Usuário não foi encontrado");
        }
        _taskSystemDBContext.Entry(payment).CurrentValues.SetValues(paymentData);

        await _taskSystemDBContext.SaveChangesAsync();

        return payment;
    }
}
