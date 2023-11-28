using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Api.Models;
using School.Api.Repositories;
using School.Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollmentRepository _enrollmentService;

        public EnrollmentController(EnrollmentRepository enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<LanguageModel>>> GetEnrollments()
        {
            List<EnrollmentModel> enrollments = await _enrollmentService.GetEnrollmentsAsync();

            return Ok(enrollments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EnrollmentModel>> GetEnrollment(int id)
        {
            var enrollment = await _enrollmentService.GetEnrollmentByIdAsync(id);

            if (enrollment == null)
            {
                return NotFound(); // Retorne um resultado NotFound se a matrícula não for encontrada.
            }

            return Ok(enrollment);
        }

        [HttpPost]
        public async Task<ActionResult<EnrollmentModel>> PostEnrollment(EnrollmentModel enrollment)
        {
            EnrollmentModel createdEnrollment = await _enrollmentService.AddEnrollmentAsync(enrollment);

            return CreatedAtAction("GetEnrollment", new { id = createdEnrollment.ID }, createdEnrollment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEnrollment(int id, EnrollmentModel enrollment)
        {
            try
            {
                var updatedEnrollment = await _enrollmentService.UpdateEnrollmentAsync(id, enrollment);

                if (updatedEnrollment == null)
                {
                    return NotFound(); // Retorne NotFound se a matrícula não for encontrada.
                }

                return Ok(updatedEnrollment);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // Retorne BadRequest com uma mensagem de erro em caso de exceção.
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEnrollment(int id)
        {
            var enrollment = await _enrollmentService.DeleteEnrollmentAsync(id);

            if (enrollment)
            {
                return NoContent(); // Retorne NoContent se a exclusão for bem-sucedida.
            }

            return NotFound(); // Retorne NotFound se a matrícula não for encontrada.
        }
    }
}