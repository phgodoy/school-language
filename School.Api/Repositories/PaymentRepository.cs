
using School.Api.Models;
using School.Api.Repositories.Interfaces;

public class PaymentRepository : IPaymentRepository
{
    private readonly TaskSystemDBContext _taskSystemDBContext;
    public PaymentRepository(TaskSystemDBContext taskSystemDBContext)
    {
        _taskSystemDBContext = taskSystemDBContext;
    }

    public Task<PaymentModel> AddPaymentAsync(PaymentModel payment)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeletePaymentAsync(int paymentId)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentModel> GetPaymentByIdAsync(int paymentId)
    {
        throw new NotImplementedException();
    }

    public Task<List<PaymentModel>> GetPaymentsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<PaymentModel> UpdatePaymentAsync(int paymentId, PaymentModel payment)
    {
        throw new NotImplementedException();
    }
}
