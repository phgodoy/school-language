using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Api.Models;
using School.Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepository _paymentService;

        public PaymentController(IPaymentRepository paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<PaymentModel>>> GetPayments()
        {
            List<PaymentModel> payments = await _paymentService.GetPaymentsAsync();

            return Ok(payments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentModel>> GetPayment(int id)
        {
            var payment = await _paymentService.GetPaymentByIdAsync(id);

            if (payment == null)
            {
                return NotFound(); // Retorne um resultado NotFound se o pagamento não for encontrado.
            }

            return Ok(payment);
        }

        [HttpPost]
        public async Task<ActionResult<PaymentModel>> PostPayment(PaymentModel payment)
        {
            PaymentModel createdPayment = await _paymentService.AddPaymentAsync(payment);

            return CreatedAtAction("GetPayment", new { id = createdPayment.ID }, createdPayment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayment(int id, PaymentModel payment)
        {
            try
            {
                var updatedPayment = await _paymentService.UpdatePaymentAsync(id, payment);

                if (updatedPayment == null)
                {
                    return NotFound(); // Retorne NotFound se o pagamento não for encontrado.
                }

                return Ok(updatedPayment);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // Retorne BadRequest com uma mensagem de erro em caso de exceção.
            }
        }
    }
}
